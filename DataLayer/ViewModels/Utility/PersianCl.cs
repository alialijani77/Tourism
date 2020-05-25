using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DataLayer.ViewModels.Utility
{
    public static class PersianCl
    {
        public static string ToShamsi(this DateTime Value)
        {
            PersianCalendar cl = new PersianCalendar();
            return cl.GetYear(Value).ToString() + "/" + cl.GetMonth(Value).ToString("00") + "/" + cl.GetDayOfMonth(Value).ToString("00");
        }
    }
}
