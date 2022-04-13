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

namespace FlagQuizz.Model
{
    public class Ranking
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public Ranking(int Id,int Score)
        {
            this.Id = Id;
            this.Score = Score;
        }
    }
}