using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Core.Model
{
    public class Category
    {
        public Category()
        {

        }

        public int CategoryId
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string ImagePath
        {
            get;
            set;
        }

        public List<Book> Books
        {
            get;
            set;
        }
    }
}
