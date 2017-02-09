using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Core.Model
{
    public class Book
    {
        public Book ()
        {

        }

        public int BookId
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string ShortDescription
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string ImagePath
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
        }

        public bool Available
        {
            get;
            set;
        }

        public bool IsFavorite
        {
            get;
            set;
        }

        public string CategoryName
        {
            get;
            set;
        }




    }
}
