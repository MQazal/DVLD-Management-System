# DVLD Management System

A Windows desktop application for managing the operations of a **Driving & Vehicle License Department (DVLD)** — people, drivers, license applications, tests, and issued licenses — built with **C#, WinForms, ADO.NET, and SQL Server**, following a strict **3-Tier Architecture**.

---

## Table of Contents

- [Overview](#overview)
- [Architecture](#architecture)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Database](#database)

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
