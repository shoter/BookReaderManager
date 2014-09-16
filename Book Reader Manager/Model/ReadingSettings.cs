using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Reader_Manager.Model
{
    class ReadingSettings
    {
        Dictionary<DayOfWeek, int> _weekdayWeight = new Dictionary<DayOfWeek, int>();

        public Dictionary<DayOfWeek, int> WeekdayWeight
        {
            get { return _weekdayWeight; }
        }

        public ReadingSettings Default
        {
            get
            {
                ReadingSettings defaultSettings = new ReadingSettings();
                defaultSettings.WeekdayWeight[DayOfWeek.Monday] = 1;
                defaultSettings.WeekdayWeight[DayOfWeek.Tuesday] = 1;
                defaultSettings.WeekdayWeight[DayOfWeek.Wednesday] = 1;
                defaultSettings.WeekdayWeight[DayOfWeek.Thursday] = 1;
                defaultSettings.WeekdayWeight[DayOfWeek.Friday] = 1;
                defaultSettings.WeekdayWeight[DayOfWeek.Saturday] = 2;
                defaultSettings.WeekdayWeight[DayOfWeek.Sunday] = 3;
                return defaultSettings;
            }
        }
    }
}
