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

using MyBookStore.Adapters; 

namespace MyBookStore.Fragments
{
    public class FavoriteBooksFragment : BaseFragment
    {

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState); 

        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

            FindViews();
            HandleEvents();

            allBooks = bookService.GetFavoriteBooks();
            booksListView.Adapter = new BookListAdapter(this.Activity, allBooks); 



        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.FavoriteBooksFragment, container, false); 
        }
    }
}