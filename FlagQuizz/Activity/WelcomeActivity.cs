using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using AndroidX.ConstraintLayout.Widget;
using FlagQuizz.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlagQuizz.Acitivty
{
    [Activity(Label = "WelcomeActivity",NoHistory =true,MainLauncher =true) ]
    public class WelcomeActivity : AppCompatActivity
    {
        TextView txtSigin;
        Button btnRegister;

        ConstraintLayout enter, exit;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.welcome);

            txtSigin = FindViewById<TextView>(Resource.Id.txtSigin);
            btnRegister = FindViewById<Button>(Resource.Id.btnRegister);


            enter = (ConstraintLayout)FindViewById(Resource.Id.wait1);
            exit = (ConstraintLayout)FindViewById(Resource.Id.wait1);


            txtSigin.Click += TxtSigin_Click;
            btnRegister.Click += BtnRegister_Click;
            // Create your application here
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(RegisterActivity));
            StartActivity(intent);
            OverridePendingTransition(Resource.Animation.abc_fade_in, Resource.Animation.abc_popup_exit);
        }

        private void TxtSigin_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(LoginActivity));
            StartActivity(intent);
        }
    }
}