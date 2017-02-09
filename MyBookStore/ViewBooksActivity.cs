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
using MyBookStore.Core.Service;
using MyBookStore.Fragments; 

namespace MyBookStore
{
    [Activity(Label = "View Books")]
    public class ViewBooksActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ViewBooks);

            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            AddTab("Favorites", new FavoriteBooksFragment());
            AddTab("Category A", new CategoryAFragment());
            AddTab("Category B", new CategoryBFragment());
            AddTab("Category C", new CategoryCFragment()); 


        }

        private void AddTab(string tabText, Fragment view)
        {
            var tab = this.ActionBar.NewTab();
            tab.SetText(tabText);

            tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e)
            {
                var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);
                if (fragment != null)
                    e.FragmentTransaction.Remove(fragment);

                e.FragmentTransaction.Add(Resource.Id.fragmentContainer, view);
            };

            tab.TabUnselected += delegate (object sender, ActionBar.TabEventArgs e)
            {
                e.FragmentTransaction.Remove(view); 
            };

            this.ActionBar.AddTab(tab); 
            
        }

    }
}