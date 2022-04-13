using Android.App;
using Android.Widget;
using Android.OS;
using Android.Database.Sqlite;
using static Android.Widget.SeekBar;
using System;
using Android.Content;
using Android.Support.V7.App;

namespace FlagQuizz.Acitivty
{
    [Activity(Label = "XamarinFlagsQuizApp", MainLauncher = false, Icon = "@drawable/icon",Theme ="@style/AppTheme")]
    public class HomeActivity : AppCompatActivity, IOnSeekBarChangeListener
    {
        SeekBar seekBar;
        TextView txtMode;
        Button btnPlay, btnScore;
        DbHelper.DbHelper db;
        SQLiteDatabase sqliteDB;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.home_fragment);

            db = new DbHelper.DbHelper(this);
            sqliteDB = db.WritableDatabase;

            seekBar = FindViewById<SeekBar>(Resource.Id.seekBar);
            txtMode = FindViewById<TextView>(Resource.Id.txtMode);
            btnPlay = FindViewById<Button>(Resource.Id.btnPlay);
            btnScore = FindViewById<Button>(Resource.Id.btnScore);

            seekBar.SetOnSeekBarChangeListener(this);
            btnPlay.Click += delegate {
                Intent intent = new Intent(this, typeof(Playing));
                intent.PutExtra("MODE", getPlayMode());
                StartActivity(intent);
                Finish();
            };
            btnScore.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Score));
                StartActivity(intent);
                Finish();
            };
        }


        private String getPlayMode()
        {
            if (seekBar.Progress == 0)
                return Common.Common.MODE.EASY.ToString();
            else if (seekBar.Progress == 1)
                return Common.Common.MODE.MEDIUM.ToString();
            else if (seekBar.Progress == 2)
                return Common.Common.MODE.HARD.ToString();
            else
                return Common.Common.MODE.HARDEST.ToString();
        }

        public void OnProgressChanged(SeekBar seekBar, int progress, bool fromUser)
        {
          
                txtMode.Text = getPlayMode().ToUpper();
        }

        public void OnStartTrackingTouch(SeekBar seekBar)
        {
         
        }

        public void OnStopTrackingTouch(SeekBar seekBar)
        {
           
        }
    }
}

