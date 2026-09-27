# DVLD Management System

A Windows desktop application for managing the operations of a **Driving & Vehicle License Department (DVLD)** — people, drivers, license applications, tests, and issued licenses — built with **C#, WinForms, ADO.NET, and SQL Server**, following a strict **3-Tier Architecture**.

> 📚 This project follows the DVLD course from **Programming Advices** (Backend Development Track, Course #19), and is intended as a learning/portfolio project demonstrating layered architecture in a real-world-style domain.

---

## Table of Contents

- [Overview](#overview)
- [Architecture](#architecture)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Database](#database)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Setup](#setup)
  - [Running the App](#running-the-app)
- [Known Limitations](#known-limitations)
- [Roadmap Ideas](#roadmap-ideas)
- [Contributing](#contributing)
- [License](#license)

---

## Overview

DVLD Management System digitizes the core workflow of a licensing department:

- Registering **people** and turning them into **drivers**
- Submitting and tracking **license applications** (new, renewal, replacement, international)
- Scheduling and recording **driving tests**
- **Issuing**, **detaining**, and **releasing** driving licenses
- Managing **system users** and role-based access via login

The application is built around a classic **3-layer** design so that UI, business rules, and database access are cleanly separated and independently maintainable.

## Architecture

```
DVLD_PresentationLayer   →  WinForms UI (forms, user controls, the main shell)
        ↓
DVLD_BusinessLogicLayer  →  Domain classes & business rules (validation, orchestration)
        ↓
DVLD_DataAccessLayer     →  ADO.NET data access (raw SqlClient, parameterized SQL)
        ↓
SQL Server Database
```

- **Presentation Layer** never talks to the database directly — it only calls into the Business Layer.
- **Business Layer** exposes rich domain objects (e.g. `clsPerson`, `clsDriver`, `clsLicense`) that wrap CRUD operations and business rules.
- **Data Access Layer** contains one `...Data` class per entity (e.g. `clsPersonData`, `clsLicenseData`) responsible purely for executing SQL via `SqlConnection` / `SqlCommand` and mapping results back.

## Features

| Module | Capabilities |
|---|---|
| **Authentication** | Login screen, session-based current user (`clsGlobalUser`), change password |
| **People** | Add / update / find / list people, view full profile |
| **Drivers** | List drivers, promote a person to a driver |
| **Applications** | Application types management; Local Driving License applications (create, list, view); Renew, Replace lost/damaged, Release detained license, International license applications |
| **Tests** | Test types management, schedule a test appointment, record test results, list appointments |
| **Licenses** | Issue a driving license for the first time, view local/international license info, license history per person, detain a license, license classes management |
| **Users** | Add / update / list / view system users, change password, activate/deactivate |
| **Main Shell** | `frmMain` acts as the MDI-style hub routing to every module above |

## Tech Stack

- **Language:** C#
- **UI Framework:** Windows Forms (WinForms)
- **Target Framework:** .NET Framework 4.8
- **Data Access:** ADO.NET (`System.Data.SqlClient`) with parameterized queries — no ORM
- **Database:** Microsoft SQL Server
- **Architecture:** 3-Tier (Presentation / Business Logic / Data Access), split into three separate Class Library / WinForms projects
- **IDE:** Visual Studio (solution provided as `.slnx`)

## Project Structure

```
DVLD-Management-System/
├── DVLD_PresentationLayer/        # WinForms UI project (startup project)
│   ├── Authentication/            # Login form
│   ├── People/                    # Person forms & controls
│   ├── Drivers/                   # Driver list
│   ├── Applications/              # Application Types, Local/International applications,
│   │                               #   Renew, Replace, Release Detained License
│   ├── Licenses/                  # Issue license, Detain license, License history, Local/Intl. license info
│   ├── Tests/                     # Test types, schedule/record test appointments
│   ├── Users/                     # User management, change password
│   ├── Global Classes/            # Shared helpers (clsGlobalUser, clsFormat, clsUtil)
│   ├── frmMain.cs                 # Main application shell / menu
│   └── DVLD_PresentationLayer.slnx
├── DVLD_BusinessLogicLayer/       # Domain/business classes (clsPerson, clsDriver, clsLicense, ...)
├── DVLD_DataAccessLayer/          # Data access classes (clsPersonData, clsLicenseData, ...)
└── README.md
```

## Database

The application expects a SQL Server database with (at least) the following tables/views, inferred from the queries in the Data Access Layer:

- `People`
- `Users`
- `Drivers` (and a `Drivers_View`)
- `Countries`
- `ApplicationTypes`
- `Applications`
- `LocalDrivingLicenseApplications` (and `vw_LocalDrivingLicenseApplicationDetails`)
- `LicenseClasses`
- `Licenses`
- `InternationalLicenses`
- `DetainedLicenses` (and `detainedLicenses_View`)
- `TestTypes`
- `Tests`
- `TestAppointments` (and `TestAppointments_View`)

> ⚠️ **No `.sql` schema script is currently included in this repository.** You will need to create the database and these tables/views yourself (matching the column names used in each `cls...Data.cs` file), or add and commit a schema script for others to use.

## Getting Started

### Prerequisites

- **Visual Studio** 2019/2022 (with ".NET desktop development" workload) or later
- **.NET Framework 4.8** developer pack
- **SQL Server** (Express, Developer, or full edition) + SQL Server Management Studio (optional, for setting up the database)

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/MQazal/DVLD-Management-System.git
   ```
2. **Create the database** in SQL Server with the tables/views listed in [Database](#database).
3. **Configure the connection string.**
   The data layer calls `clsDataAccessSettings.ConnectionString` (in `DVLD_DataAccessLayer/clsDataAccessSettings.cs`), but this file currently ships **without** a `ConnectionString` value defined. Add one before running the app, e.g.:
   ```csharp
   public static class clsDataAccessSettings
   {
       public static string ConnectionString =
           @"data source=.;initial catalog=DVLD;integrated security=true;";
   }
   ```
   Adjust the server name / authentication mode to match your local SQL Server instance.
4. **Fix hardcoded image paths (if needed).** Some forms (`frmLogin`, `frmMain`, etc.) load images from an absolute local path (e.g. `C:\Programming Path\Programming Advices.com\...`). Update these paths to point to image assets available on your machine, or replace them with resources embedded via the `Resources` folder.
5. **Open the solution** `DVLD_PresentationLayer/DVLD_PresentationLayer.slnx` in Visual Studio.
6. **Restore/Build** the solution (Build → Rebuild Solution). All three projects (Presentation, Business Logic, Data Access) will build in dependency order.

### Running the App

- Set **`DVLD_PresentationLayer`** as the startup project (it usually is by default, see `Program.cs`).
- Press **F5** / **Start** to launch.
- Log in with a user that already exists in your `Users` table (create one directly in the database for the first run, since there is no public "sign up" screen).

## Known Limitations

- Passwords are stored and compared as **plain text** in the `Users` table — not suitable for production use without adding hashing (e.g. BCrypt/PBKDF2) in the Data/Business layer.
- Several forms reference **absolute, machine-specific file paths** for images, which will throw a `FileNotFoundException` on any machine other than the original author's.
- No automated tests, no `.sql` schema/migration scripts, and no CI configuration are currently included.
- Built on the legacy **.NET Framework** (WinForms) rather than .NET (Core)/WPF/MAUI.

## Roadmap Ideas

- [ ] Ship a `Database/Schema.sql` script (and sample seed data) so the project runs out of the box
- [ ] Move the connection string to `App.config` and support encrypted/secret configuration
- [ ] Hash and salt user passwords
- [ ] Replace hardcoded image paths with embedded resources
- [ ] Add unit tests for the Business Logic Layer
- [ ] Add role-based authorization (currently authentication only)

## Contributing

Issues and pull requests are welcome. If you plan a larger change, please open an issue first to discuss what you'd like to change.

## License

No license file is currently included in this repository. All rights are reserved by the author unless a license is added — please open an issue or contact the maintainer if you'd like to use this project under specific terms.
