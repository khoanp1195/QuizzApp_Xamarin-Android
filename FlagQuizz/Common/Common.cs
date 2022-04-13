using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlagQuizz.Common
{
    public class Common
    {
        public const int EASY_MODE_NUM = 30;
        public const int MEDIUM_MODE_NUM = 60;
        public const int HARD_MODE_NUM = 90;
        public const int HARDEST_MODE_NUM = 120;

        public enum MODE
        {
            EASY,
            MEDIUM,
            HARD,
            HARDEST
           
        }
    }
}