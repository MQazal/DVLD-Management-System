using System;

namespace DVLD_PresentationLayer.Global_Classes
{
    public class clsFormat
    {
        public static string SetDateFormat(DateTime Date, string DateFormat)
        {
            return Date.ToString(DateFormat);
        }
    }
}