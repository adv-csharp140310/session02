﻿using System.Globalization;
using System.Text;

namespace session02.Utils;
public static class DateUtil
{
    static List<string> monthNames = new List<string>() {
                "فروردین", "اردیبهشت", "خرداد",
                "تیر", "مرداد",  "شهریور",
                "مهر", "آبان", "آذر",
                "دی", "بهمن", "اسفند"
            };

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

    public static string GetJalaliMonthName(DateTime date)
    {
        //if/switch/array
        var pc = new PersianCalendar();
        var month = pc.GetMonth(date);
        var result = "";

        //switch (month)
        //{
        //    case 1: return "فروردین";
        //    case 2: return "اردیبهشت";
        //    case 3:
        //        return "خرداد";
        //    case 4:
        //        return "تیر";
        //    case 5:
        //        return "مرداد";
        //    case 6:
        //        return "شهریور";
        //    case 7:
        //        return "مهر";
        //    case 8:
        //        return "آبان";
        //    case 9:
        //        return "آذر";
        //    case 10:
        //        return "دی";
        //    case 11:
        //        return "بهمن";
        //    case 12:
        //        return "اسفند";
        //    default: throw new Exception("Wrong DATE!!");
        //}

        /***
         * Statment
         * Expression
         */

        //return month switch
        //{
        //    1 => "فروردین",
        //    2 => "اردیبهشت",
        //    3 => "خرداد",
        //    4 => "تیر",
        //    5 => "مرداد",
        //    6 => "شهریور",
        //    7 => "مهر",
        //    8 => "آبان",
        //    9 => "آذر",
        //    10 => "دی",
        //    11 => "بهمن",
        //    12 => "اسفند",
        //    _ => throw new Exception("Wrong DATE!!"),
        //};

        return monthNames[month - 1];
    }

    public static string GetJalaliSeason(DateTime date)
    {
        //if/switch/pattern matching
        var pc = new PersianCalendar();
        var month = pc.GetMonth(date);

        var result = "زمستان";
        //switch (month)
        //{
        //    case 1:
        //    case 2:
        //    case 3:
        //        return "بهار";
        //    case 4:
        //    case 5:
        //    case 6:
        //        return "زمستان";
        //    case 7:
        //    case 8:
        //    case 9:
        //        return "پاییز";
        //    case 10:
        //    case 11:
        //    case 12:
        //        return "زمستان";
        //}

        //switch (month)
        //{
        //    case 1 or 2 or 3:      
        //        return "بهار";
        //    case 4:
        //    case 5:
        //    case 6:
        //        return "تابستان";
        //    case 7:
        //    case 8:
        //    case 9:
        //        return "پاییز";
        //    default:
        //        return "زمستان";
        //}


        return month switch
        {
            var m when m <= 3 => "بهار",
            4 or 5 or 6 => "تابستان",
            7 or 8 or 9 => "پاییز",
            _ => "زمستان",
        };




        return result;
    }


}
