using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooConcepts
{
    public class Date
    {
        // Definimos nuestros atributos privados
        private int _year;
        private int _month;
        private int _day;

        // Snipets para contuctor (ctor + TAB + TAB)
        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(day, month, year); 
        }

        private int CheckDay(int day, int month, int year)
        {
            // Validamos Bisiesto (Cada 4 si, cada 100 no, cada 400 si)
            if (month == 2 && day == 29 && IsLeapYear(year))
                return day;
            
            // Declaramos arreglo de días por mes 
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

            if (day >= 1 && day <= daysPerMonth[month])
                return day;

            throw new DayException($"Invalid day: {day}");
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;

        }

        private int CheckMonth(int month)
        {
            if (month >= 1 && month <=12)
                return month;

            throw new MonthException($"Invalid month: {month}");
        }

        // Sobreescribimos el ToString
        public override string ToString()
        {
            return $"{_day:00}/{_month:00}/{_year}";
        }
    }
}
