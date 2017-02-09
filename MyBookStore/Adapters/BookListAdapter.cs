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
using MyBookStore.Core.Model;

namespace MyBookStore.Adapters
{
    public class BookListAdapter : BaseAdapter<Book>
    {
        List<Book> items;
        Activity context; 

        public BookListAdapter(Activity context, List<Book> items) : base()
        {
            this.items = items;
            this.context = context; 
        }


        //indexer 
        public override Book this[int position]
        {
            get
            {
                return items[position]; 
            }
        }

        public override int Count
        {
            get
            {
                return items.Count; 
            }
        }

        public override long GetItemId(int position)
        {
            return position; 
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position]; 


            if (convertView == null)
            {
                convertView = context.LayoutInflater.Inflate(Resource.Layout.BookRowView, null); 
            }

            convertView.FindViewById<TextView>(Resource.Id.bookNameTextView).Text = item.Name;
            convertView.FindViewById<TextView>(Resource.Id.bookDescriptionTextView).Text = item.Description;
            convertView.FindViewById<TextView>(Resource.Id.bookPriceTextView).Text = "Price: $ " + item.Price;
            convertView.FindViewById<TextView>(Resource.Id.bookAvailableTextView).Text = "Available: " + item.Available;


            return convertView; 
        }
    }
}