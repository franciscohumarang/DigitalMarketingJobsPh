using System;
namespace digitalmarketingjobs.ph.Helper
{
    public static class GeneralHelper
    {
         
        public static string GetDaysAgo(DateTime objDateTime)
        {
            
            TimeSpan ts = DateTime.Now.ToUniversalTime().Subtract(objDateTime);
            int intDays = ts.Days;

            if (intDays > 0)
                return string.Format("{0}d ago", intDays);
            else
                return "new";
        }
    }
}
