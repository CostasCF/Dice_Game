using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace p19057_diceGame
{
    
    public partial class Form1 : Form
    {
        private List<User> Userlist;
   
        int countDown = 20;
        Random random;
        int randomImage;
        int sum;
        int score;
        string username;

       

        public Form1()
        {
             InitializeComponent();
             Userlist = new List<User>();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            warningMsgLevel.Hide();
            warningMsgName.Hide();
            usernameBox.BackColor = Color.FromArgb(248, 232, 208);
            dicePictureBox.BackColor = Color.FromArgb(42, 34, 15);
            scoreListView.BackColor = Color.FromArgb(248, 232, 208);
            random = new Random();
            firstMenu.Show();
            secondMenu.Hide();
            thirdMenu.Hide();
            gamePnl.Hide();
            ingamePnl.Hide();
            tryAgainPnl.Hide();
            dicePictureBox.Hide();
            infoPanel.Hide();
            tryAgainPnl.BackColor = Color.FromArgb(100, 0, 0, 0);
      

        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            secondMenu.Show();
            firstMenu.Hide();

            
          
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            firstMenu.Show();
            secondMenu.Hide();
            
            

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //username error handling
            if (usernameBox.TextLength == 0)
            {
                warningMsgName.Show();
            }
            else { warningMsgName.Hide(); }
            //level selection error handling
            if (!(hardOption.Checked || normalOption.Checked || easyOption.Checked))
            {
                warningMsgLevel.Show();
            }
            else { warningMsgLevel.Hide(); }

            //easy level handling
            if (easyOption.Checked && usernameBox.TextLength>=1)
            {
              
                gamePnl.Show();
                ingamePnl.Show();
                dicePictureBox.Show();
                secondMenu.Hide();
                firstMenu.Hide();
            
                if (timeCountdown.Enabled)
                {
                    easyLevelTimer.Enabled = false;
                    timeCountdown.Enabled = false;
                }
                else
                {
                    easyLevelTimer.Enabled = true;
                    timeCountdown.Enabled = true;
                }
            }
            

            //normal level handling
            if (normalOption.Checked && usernameBox.TextLength >= 1)
            {
          
                gamePnl.Show();
                ingamePnl.Show();
                dicePictureBox.Show();
                secondMenu.Hide();
                firstMenu.Hide();
                
                if (timeCountdown.Enabled)
                {
                    normalLevelTimer.Enabled = false;
                    timeCountdown.Enabled = false;
                }
                else
                {
                    normalLevelTimer.Enabled = true;
                    timeCountdown.Enabled = true;
                }
            }
       
            //hard level handling
            if (hardOption.Checked && usernameBox.TextLength >= 1)
            {
               
                gamePnl.Show();
                ingamePnl.Show();
                dicePictureBox.Show();
                secondMenu.Hide();
                firstMenu.Hide();
              
                if (timeCountdown.Enabled)
                {
                    hardLevelTimer.Enabled = false;
                    timeCountdown.Enabled = false;
                }
                else
                {
                    hardLevelTimer.Enabled = true;
                    timeCountdown.Enabled = true;
                }
            }
            

            
        }

        private void returntoTheMainMenu_Click(object sender, EventArgs e)
        {
            warningMsgLevel.Hide();
            warningMsgName.Hide();
            tryAgainPnl.Hide();
            //επαναφορα δεδομενων
            countDown = 20;
            sum = 0;
            sumLabel.Text = sum.ToString();
            dicePictureBox.Enabled = true;
            // ListViewItem item = new ListViewItem();
           // User myuser = new User(usernameBox.Text,playerid, sumLabel.Text);
            // βαζουμε το αντικειμενο με τα δεδομενα του παιχτη στην λιστα
            
            firstMenu.Show();
            gamePnl.SendToBack();
            gamePnl.Hide();

           
            
           
        }

        //μεθοδος αποθήκευσης αρχείων
        private void dataSaving(string username,int score, string level) {
            User myuser = new User(username, score,level);
            Userlist.Add(myuser);
            StreamWriter tw = File.AppendText("@Savedlist.txt");
            tw.WriteLine(myuser.Username);
            tw.WriteLine(myuser.Score);
            tw.WriteLine(myuser.Level);
            tw.Close();
        }

        //μεθοδος ευρεσης λιστας με τα μεγιστα σκορ
        private void dataArranging()
         {
            var fileLines = File.ReadAllLines("@Savedlist.txt");

          for (int i = 0; i + 2 < fileLines.Length; i += 3)
            {
              scoreListView.Items.Add(
                    new ListViewItem(new[]
                    {
                fileLines[i],
                fileLines[i + 1],
                fileLines[i + 2],
                    }));
            }

            // Resize the columns
            for (int i = 0; i < scoreListView.Columns.Count; i++)
            {
                scoreListView.Columns[i].Width = -2;
            }
        }

        private void dicePictureBox_Click(object sender, EventArgs e)
        {
         
            sum += randomImage;
            sumLabel.Text = sum.ToString();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            tryAgainPnl.Hide();
            countDown = 20;
            sum = 0;
            sumLabel.Text = sum.ToString();
            dicePictureBox.Enabled = true;
            if (easyOption.Checked)
            {
                if (timeCountdown.Enabled)
                {
                    easyLevelTimer.Enabled = false;
                    timeCountdown.Enabled = false;
                }
                else
                {
                    easyLevelTimer.Enabled = true;
                    timeCountdown.Enabled = true;
                }
            }
            if (normalOption.Checked)
            {
                if (timeCountdown.Enabled)
                {
                    normalLevelTimer.Enabled = false;
                    timeCountdown.Enabled = false;
                }
                else
                {
                    normalLevelTimer.Enabled = true;
                    timeCountdown.Enabled = true;
                }
            }
            if (hardOption.Checked)
            {
                if (timeCountdown.Enabled)
                {
                    hardLevelTimer.Enabled = false;
                    timeCountdown.Enabled = false;
                }
                else
                {
                    hardLevelTimer.Enabled = true;
                    timeCountdown.Enabled = true;
                }
            }
        }

        private void scoreBtn_Click(object sender, EventArgs e)
        {
            scoreListView.Items.Clear();
            dataArranging();
            thirdMenu.Show();
            firstMenu.Hide();
            secondMenu.Hide();

        }

        private void returnScoreboardBtn_Click(object sender, EventArgs e)
        {
            firstMenu.Show();
            thirdMenu.Hide();
        }

        //συχρονισμος ρολογιων και δυσκολια παιχνιδιου
        private void timer1_Tick(object sender, EventArgs e)
        {
            countDown--;
            timerLabel.Text = countDown.ToString();
            if (countDown == 0)
            {
                timeCountdown.Enabled = false;
                dicePictureBox.Enabled = false;
            }
        }

        private void easyLevelTimer_Tick(object sender, EventArgs e)
        {
            randomImage = random.Next(1, 7);
            dicePictureBox.ImageLocation = "images/" + randomImage.ToString() + ".png";
            int x1, y1;
            x1 = random.Next(ingamePnl.Width - dicePictureBox.Width);
            y1 = random.Next(ingamePnl.Height - dicePictureBox.Height);
            dicePictureBox.Location = new Point(x1, y1);
            if (countDown == 0)
            {
                username = usernameBox.Text;
                score = sum;
                dataSaving(username, score, "easy"); //κληση dataSaving για αποθήκευση δεδομένων μολις το χρονομετρο παει στο 0.
                tryAgainPnl.Show();
                easyLevelTimer.Enabled = false;
            }

        }

        private void normalLevelTimer_Tick(object sender, EventArgs e)
        {
            randomImage = random.Next(1, 7);
            dicePictureBox.ImageLocation = "images/" + randomImage.ToString() + ".png";
            int x1, y1;
            x1 = random.Next(ingamePnl.Width - dicePictureBox.Width);
            y1 = random.Next(ingamePnl.Height - dicePictureBox.Height);
            dicePictureBox.Location = new Point(x1, y1);
            if (countDown == 0)
            {
                username = usernameBox.Text;
                score = sum*2;
                dataSaving(username, score, "normal"); //κληση dataSaving για αποθήκευση δεδομένων μολις το χρονομετρο παει στο 0.
                tryAgainPnl.Show();
                normalLevelTimer.Enabled = false;
            }

        }
        private void hardLevelTimer_Tick(object sender, EventArgs e)
        {
            randomImage = random.Next(1, 7);
            dicePictureBox.ImageLocation = "images/" + randomImage.ToString() + ".png";
            int x1, y1;
            x1 = random.Next(ingamePnl.Width - dicePictureBox.Width);
            y1 = random.Next(ingamePnl.Height - dicePictureBox.Height);
            dicePictureBox.Location = new Point(x1, y1);
            if (countDown == 0)
            {
                username = usernameBox.Text;
                score = sum*3;
                dataSaving(username, score, "hard"); //κληση dataSaving για αποθήκευση δεδομένων μολις το χρονομετρο παει στο 0.
                tryAgainPnl.Show();
                hardLevelTimer.Enabled = false;
            }

        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            infoPanel.Show();
            firstMenu.Hide();
        }

        private void returnInfoButton_Click(object sender, EventArgs e)
        {
            firstMenu.Show();
            infoPanel.Hide();
        }
    }
    
}
