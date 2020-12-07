using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p19057_diceGame
{
    class User
    {
        private string username,level;
        private int  score;
        public User(string username, int score, string level)
        {
            this.Username =username;
            this.Score = score;
            this.level= level;
             ;
        }

        public string Username { get => username; set => username = value; }
        public string Level { get => level; set => level = value; }
        public int Score { get => score; set => score = value; }
    }
}
