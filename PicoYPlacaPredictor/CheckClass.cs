using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoYPlacaPredictor
{
    class CheckClass
    {
        public bool performCheck(string _plate, int _hour, int _minute, string _date)
        {
            string plate = checkLastDigit(_plate);
            bool controlledHours = checkTime(_hour, _minute);
            string date = parseDate(_date);

            if ((plate == "1" || plate == "2") && date =="Monday" && controlledHours)
            {
                return true;
            }
            if ((plate == "3" || plate == "4") && date == "Tuesday" && controlledHours)
            {
                return true;
            }
            if ((plate == "5" || plate == "6") && date == "Wednesday" && controlledHours)
            {
                return true;
            }
            if ((plate == "7" || plate == "8") && date == "Thursday" && controlledHours)
            {
                return true;
            }
            if ((plate == "9" || plate == "0") && date == "Friday" && controlledHours)
            {
                return true;
            }
            else { return false; }
        }
        private string checkLastDigit(string _plate)
        {
            string lastDigit;
            string temp = _plate.Trim();            
            lastDigit = temp.Substring(temp.Length - 1);
            return lastDigit;
        }

        private int formatHour(int _hour, int _minute)
        {
            int temp = _hour * 100;
            int finalhour = temp + _minute;

            return finalhour;
        }
        private bool checkTime(int _hour, int _min)
        {
            int hour = formatHour(_hour, _min);
            if (0700 <= hour && hour <= 0930)
            {
                return true;
            }
            if (1600 <= hour && hour <= 1930)
            {
                return true;
            }
            else
            {
                return false;
            };
        }
        private string parseDate(string day)
        {
            string[] temp = day.Split(',');
            return temp[0];
        }



    }
}
