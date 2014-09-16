using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Book_Reader_Manager.Model
{
    public class Book
    {
        //public at
        string _name;
        int _pages;
        int _readedPages;
        ObservableCollection<Reading> _readings = new ObservableCollection<Reading>();
       

        public Book(string name, int pages)
        {
            init(name, pages);
        }

        protected void init(string name, int pages)
        {
            Name = name;
            Pages = pages;
            ReadedPages = 0;
        }

        public Reading addReading(int weight = 1)
        {
            Reading reading = new Reading(this, weight);
            _readings.Add(reading);
            return reading;
        }

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                _pages = value;
            }
        }

        public int ReadedPages
        {
            get
            {
                return _readedPages;
            }
            set
            {
                _readedPages = value;
            }
        }

        public int RemainingPages
        {
            get
            {
                return _pages - _readedPages;
            }
        }

        public bool Readed
        {
            get
            {
                return _readedPages >= _pages;
            }
        }

        public int TotalWeight
        {
            get
            {
                int total = 0;
                foreach(var reading in _readings)
                {
                    total += reading.Weight;
                }

                return total;
            }
        }
    }
}
