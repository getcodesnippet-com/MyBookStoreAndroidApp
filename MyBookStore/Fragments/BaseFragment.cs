using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

using MyBookStore.Core.Model;
using MyBookStore.Core.Service;

namespace MyBookStore.Fragments
{
    public class BaseFragment : Fragment
    {

        protected ListView booksListView;
        protected List<Book> allBooks;
        protected BookService bookService;

        public BaseFragment()
        {
            bookService = new BookService();

        }


        protected void HandleEvents()
        {
            booksListView.ItemClick += BooksListView_ItemClick;

        }

        protected void FindViews()
        {
            booksListView = this.View.FindViewById<ListView>(Resource.Id.booksListView); 
        }



        private void BooksListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {

            var book = allBooks[e.Position];

            var intent = new Intent();
            intent.SetClass(this.Activity, typeof(BookDetailActivity));
            intent.PutExtra("SelectedBookId", book.BookId);
            StartActivityForResult(intent, 200); 
        

        }

       
    }
}