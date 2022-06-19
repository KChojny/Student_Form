using Android.App;
using Android.OS;
using Android.Widget;
using System;
using System.IO;
using AndroidX.AppCompat.App;

namespace Chojnowski_Student_Form
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true,
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class Activity2 : AppCompatActivity
    {
        Button btnLoadFile;
        Button btnClose;
        TextView textView;
        ScrollView scrollView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout2);

            btnLoadFile = FindViewById<Button>(Resource.Id.button1);
            btnClose = FindViewById<Button>(Resource.Id.button2);
            textView = FindViewById<TextView>(Resource.Id.textView1);
            scrollView = FindViewById<ScrollView>(Resource.Id.scrollView1);

            StreamReader sr = File.OpenText(Activity1.file);
            string entireText = "";

            string s;
            while ((s = sr.ReadLine()) != null)
            {
                entireText += s + "\n";
            }
            sr.Close();
            scrollView.Enabled = true;
            textView.Text = entireText;

            btnLoadFile.Click += BtnLoadFile_Clicked;
            btnClose.Click += BtnClose_Clicked;
        }

        private void BtnLoadFile_Clicked(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText(Activity1.file);
            string entireText = "";

            string s;
            while ((s = sr.ReadLine()) != null)
            {
                entireText += s + "\n";
            }
            sr.Close();
            scrollView.Enabled = true;
            textView.Text = entireText;
        }

        private void BtnClose_Clicked(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}