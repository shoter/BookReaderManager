using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Book_Reader_Manager.Interfaces;

namespace Book_Reader_Manager.Model
{
    public class ReadingDay : ICopyable
    {
        public static ObservableCollection<ReadingDay> _days = new ObservableCollection<ReadingDay>();

        DateTime _date;
        ObservableCollection<Reading> _readings = new ObservableCollection<Reading>();

        protected ReadingDay()
        {
            _date = DateTime.Now;
        }

        static ReadingDay()
        {
            _days.Add(new ReadingDay());
        }

        protected ReadingDay(DateTime date)
        {
            _date = date;
        }

        public static ReadingDay Get(DateTime date)
        {
            return Get(date.Year, date.Month, date.Day);
        }

        public static ReadingDay Get(int year, int month, int day)
        {
            int index = Index(year, month, day);
            if (index < 0) throw new Exception("Wrong date!");
            if (index >= _days.Count)
            {
                InsertDaysTo(index);
            }
            ReadingDay readingDay = _days[index];
            return readingDay;
        }

        private static void InsertDaysTo(int index)
        {
            ReadingDay last = _days.Last();
            DateTime date = last._date;
            for(int i = Index(date);i < index;++i)
            {
                date.AddDays(1);
                ReadingDay day = new ReadingDay(date);
                _days.Add(day);
            }
        }

        public static int Index(int year, int month, int day)
        {
            ReadingDay first = _days[0];
            DateTime firstDate = first._date;
            DateTime secondDate = new DateTime(year, month, day);
            return (int)(secondDate - firstDate).TotalDays;
        }

        public static int Index(DateTime time)
        {
            return Index(time.Year, time.Month, time.Day);
        }

        public static ReadingDay operator +(ReadingDay lhm, Reading rhm)
        {
            lhm._readings.Add(rhm);
            return lhm;
        }

        public virtual object Copy()
        {
            ReadingDay copy = new ReadingDay(_date);
            foreach( var reading in Readings )
            {
                copy += reading;
            }
            return copy;
        }

        #region Properties

        public ObservableCollection<Reading> Readings
        {
            get
            {
                return _readings;
            }

            protected set
            {
                _readings = value;
            }
        }

        public DayOfWeek DayOfWeek
        {
            get
            {
                return _date.DayOfWeek;
            }
        }

        public int Day
        {
            get
            {
                return _date.Day;
            }
        }

        public int month
        {
            get
            {
                return _date.Month;
            }
        }

        public int Year
        {
            get
            {
                return _date.Year;
            }
        }

        #endregion
    }
}
