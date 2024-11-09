using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLiNhanSu_YT
{
    public class date
    {
        private int year;
        private int month;
        private int day;

        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
        public int Day { get => day; set => day = value; }

        public bool IsLeapYear(int year) // Kiểm tra năm nhuận
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        public int CheckDay(int day) // Kiểm tra ngày hợp lệ
        {
            int[] daysOfMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(month), "Tháng không hợp lệ. Giá trị phải từ 1 đến 12.");
            }

            // Kiểm tra số ngày trong tháng
            if (day < 1 || day > daysOfMonth[month])
            {
                if (month == 2 && IsLeapYear(year) && day == 29)
                {
                    return day; // Cho phép ngày 29 trong tháng 2 nếu là năm nhuận
                }
                throw new ArgumentOutOfRangeException(nameof(day), "Ngày không hợp lệ. Giá trị phải phù hợp với tháng đã cho.");
            }
            return day;
        }
        public int ValidateMonth(int month) // Kiểm tra tháng hợp lệ
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(month), "Tháng không hợp lệ. Giá trị phải từ 1 đến 12.");
            }
            return month;
        }
        public date(int year, int month, int day)
        {
            Year = year;
            Month = ValidateMonth(month);
            Day = CheckDay(day);
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}\n";
        }

        public date String_ToDate(string s)
        {
            string[] ss=s.Split('/');
            return new date(int.Parse(ss[0]), int.Parse(ss[1]), int.Parse(ss[2]));
        }
    }
}