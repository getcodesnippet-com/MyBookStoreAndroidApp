using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyBookStore.Core.Service;
using MyBookStore.Core.Model;

namespace MyBookStore
{
   

    [Activity(Label = "BookDetailActivity")]
    public class BookDetailActivity : Activity
    {
        private Book book;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.BookDetail);

            int bookId = Intent.GetIntExtra("SelectedBookId", 0);

            BookService service = new BookService();
            book = service.GetBookById(bookId);

            FindViews(); 
             

        }

        private void FindViews()
        {

            FindViewById<TextView>(Resource.Id.textBookName).Text = book.Name;
            FindViewById<TextView>(Resource.Id.textDescription).Text = book.Description;
            FindViewById<TextView>(Resource.Id.textCategory).Text = book.CategoryName;
            FindViewById<TextView>(Resource.Id.textAvailable).Text = "Available: " + book.Available;
            FindViewById<TextView>(Resource.Id.textPrice).Text = "Price: $" + book.Price; 

        }
    }
}