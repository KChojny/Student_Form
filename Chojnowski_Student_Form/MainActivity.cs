using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace Chojnowski_Student_Form
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true,
    ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
     
    public class MainActivity : AppCompatActivity
    {
        Button button1;
        EditText editText1, editText2, editText3, editText4, editText5, editText6;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            button1 = FindViewById<Button>(Resource.Id.button1);
            editText1 = FindViewById<EditText>(Resource.Id.editText1);
            editText2 = FindViewById<EditText>(Resource.Id.editText2);
            editText3 = FindViewById<EditText>(Resource.Id.editText3);
            editText4 = FindViewById<EditText>(Resource.Id.editText4);
            editText5 = FindViewById<EditText>(Resource.Id.editText5);
            editText6 = FindViewById<EditText>(Resource.Id.editText6);

            button1.Click += SumbitClick;
        }
        private void SumbitClick(object sender, EventArgs e)
        {
            Student.SetName(editText1.Text);
            Student.SetSurname(editText2.Text);
            Student.SetStudentNo(Convert.ToInt32(editText3.Text));
            Student.SetEmail(editText4.Text);
            Student.SetFaculty(editText5.Text);
            Student.SetPhoneNo(editText6.Text);
            StartActivity(typeof(Activity1));
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}