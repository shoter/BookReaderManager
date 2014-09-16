using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Reader_Manager.Model
{
    public class Reading
    {
        private Book _book;
        private int _weight;

        public Reading(Book book)
        {
            init(book, 1);
        }

        public Reading(Book book, int weight)
        {
            init(book, weight);
        }

        private void init(Book book, int weight)
        {
            Book = book;
            Weight = weight;
        }

        public Book Book
        {
            get { return _book; }
            set { _book = value; }
        }

        public int Weight
        {
            get { return _weight;  }
            set { _weight = value; }
        }

        public int Pages
        {
            get
            {
                int totalPages = Book.Pages;
                int totalWeight = Book.TotalWeight;
                return (int)(((float)Weight / (float)totalWeight) * (float)totalPages);
            }
        }
    }
}
