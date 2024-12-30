using System.Globalization;
using System.Text;

namespace session02.Utils;
public static class DateUtil
{
    public static string MiladiToJalali(DateTime date)
    {
        //DRY - Don't Repeat Yourself 

        var pc = new PersianCalendar();
        var year = pc.GetYear(date);
        var month = pc.GetMonth(date).ToString("0#");
        var day = pc.GetDayOfMonth(date).ToString("0#");

        //String concat 
        var result = year + "/" + month + "/" + day;

        //String format
        result = String.Format("{0}/{1}/{2}", year, month, day);

        //String template / string interpolation
        result = $"{year}/{month}/{day}";


        var sb = new StringBuilder();
        sb.Append(year);
        sb.Append("/");
        sb.Append(month);
        sb.Append("/");
        sb.Append(day);
        result = sb.ToString();


        return result; 
    }
}
