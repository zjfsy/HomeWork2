using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using AlertDialog = Android.App.AlertDialog;

namespace Hello_Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            Button button = FindViewById<Button>(Resource.Id.but);
            button.Click += delegate {
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                AlertDialog alertDialog = builder.SetTitle("Hello").SetMessage("Hello I am a great C# programmer!").SetPositiveButton("OK", (s, e) => { Toast.MakeText(this, "you click ok", ToastLength.Short).Show(); }).Create();
                alertDialog.Show();
            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }
	}
}

