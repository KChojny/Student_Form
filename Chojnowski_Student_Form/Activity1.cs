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
    public class Activity1 : AppCompatActivity
    {
        TextView textView;
        Button btnSave;
        Button btnNext;
        Button btnBack;
        StreamWriter sw;
        readonly string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
        public static string file;
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout1);

            btnSave = FindViewById<Button>(Resource.Id.button1);
            btnNext = FindViewById<Button>(Resource.Id.button2);
            btnBack = FindViewById<Button>(Resource.Id.button3);

            textView = FindViewById<TextView>(Resource.Id.textView2);
            textView.Text = Student.StudentDetails();

            file = Path.Combine(path, "Students.txt");
            if (!File.Exists(file))
            {
                using StreamWriter sw = File.CreateText(file);
                sw.WriteLine("Students");
                sw.WriteLine("----------");
            }
            else
            {
                using StreamWriter sw = new StreamWriter(file, true); ;
            }

            btnSave.Click += BtnSave_Clicked;
            btnNext.Click += BtnNext_Clicked;
            btnBack.Click += BtnBack_Clicked;            
        }

        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            string student = Student.StudentDetails();
            string[] studendsProperties = student.Split("\n");

            using (StreamWriter sw = new StreamWriter(file, true))
            {
                for (int i = 0; i < studendsProperties.Length; i++)
                    sw.WriteLine(studendsProperties[i]);
                sw.WriteLine("----------");
                sw.Close();
            }
            
        }

        private void BtnNext_Clicked(object sender, EventArgs e) 
        {
            StartActivity(typeof(Activity2));
        }

        private void BtnBack_Clicked(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}