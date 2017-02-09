using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;
using Android.Content;

namespace MyBookStore
{
    [Activity(Label = "MyBookStore", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        
        private Button buttonViewBooks;
        private Button buttonViewCart;
        private Button buttonAboutApp; 
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Log.Info("MyBookStore", "This is info message"); 


            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);


            buttonViewBooks = FindViewById<Button>(Resource.Id.buttonViewBooks);
            buttonViewCart = FindViewById<Button>(Resource.Id.buttonViewCart);
            buttonAboutApp = FindViewById<Button>(Resource.Id.buttonAboutApp);



            buttonViewBooks.Click += ButtonViewBooks_Click;
            buttonViewCart.Click += ButtonViewCart_Click;
            buttonAboutApp.Click += ButtonAboutApp_Click;
            

            
        }

        private void ButtonAboutApp_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(AboutAppActivity));
            StartActivity(intent); 

        }

        private void ButtonViewCart_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(ViewCartActivity));
            StartActivity(intent); 

        }

        private void ButtonViewBooks_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(ViewBooksActivity));
            StartActivity(intent); 

        }
    }
}

