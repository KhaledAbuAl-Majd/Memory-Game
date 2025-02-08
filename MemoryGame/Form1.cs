using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MemoryGame.Properties;

namespace MemoryGame
{

    public partial class Form1 : Form
    {
        public class clsMemoryGame
        {
            struct stGameStatus
            {
                public byte GameTime;
                public byte NumOfOpenedBoxes;
                public byte TimeLeft;
                public byte Score;

            }
            static Form1 frm;
            Image[] images;
            Guna2PictureBox[] Boxes;
            Guna2PictureBox OpenedBox1, OpenedBox2;
            bool IsRightChoice;
            stGameStatus GameStatus;
            void InitializeImagesArray()
            {
                images = new Image[] {Resources.shark_2317422_1920,Resources.owl_7515292_1920
                ,Resources.Tiger,Resources.animals_1298747_1920,Resources.penguin_42936_1920,
                Resources.falcon_5508863_1920,Resources.dog_7453842_1920,Resources.cartoon_7918608_1920,
                Resources.ai_generated_8647702_1920,Resources.elephant_8809485_1920,Resources.rabbit,
                Resources.Lion
                }; 
            }
            void RandomizeImagesArray()
            {
                Random rand = new Random();

                for(byte i = 0; i < Boxes.Length / 2; i++)
                {
                    short randomindex = Convert.ToInt16(rand.Next(images.Length));
                    Image temp = images[i];
                    images[i] = images[randomindex];
                    images[randomindex] = temp;
                }
            }
            void InitializeBoxesArray()
            {
                Boxes = new Guna2PictureBox[] {
                    frm.pb1, frm.pb2, frm.pb3,frm.pb4, frm.pb5,frm.pb6,frm.pb7,frm.pb8,
                frm.pb9,frm.pb10,frm.pb11,frm.pb12,frm.pb13,frm.pb14,frm.pb15,frm.pb16 };
            }
            void SetBoxsImageIndexRandomInTag()
            {
                Random rand = new Random();

                for(byte i = 0; i < Boxes.Length/2; i++)
                {
                    for (byte j = 0; j < 2; j++)
                    {

                        byte IndexOfBox = 0;
                        do
                        {
                            IndexOfBox = Convert.ToByte(rand.Next(Boxes.Length));

                        } while (Boxes[IndexOfBox].Tag != null);

                        Boxes[IndexOfBox].Tag = i;
                    }
                }

            }
            void DiscoverBox(Guna2PictureBox pb)
            {
                pb.Image = images[Convert.ToByte(pb.Tag)];
            }
            void CoverBox(Guna2PictureBox pb)
            {
                pb.Image = Resources.question_mark_96;
            }
            void DiscoverAllBoxes()
            {
                foreach(Guna2PictureBox pb in Boxes)
                {
                    DiscoverBox(pb);
                }
            }
            void CoverAllBoxes()
            {
                foreach (Guna2PictureBox pb in Boxes)
                    CoverBox(pb);
            }
            void EnableOrDisableBox(Guna2PictureBox pb,bool Value)
            {
                pb.Enabled = Value;
            }
            void EnableOrDisableAllBoxes(bool Value)
            {
                foreach (Guna2PictureBox pb in Boxes)
                    EnableOrDisableBox(pb,Value);
            }
            void BoxesIsSame()
            {
                GameStatus.Score++;
                IsRightChoice = true;
                EnableOrDisableBox(OpenedBox1, false);
                EnableOrDisableBox(OpenedBox2, false);
                ChangeScoreLabelValue();
                ChangeScoreProogressBarValue();
                CheckWin();
            }
            void BoxesIsNotSame()
            {
                IsRightChoice = false;
                //CoverBox(OpenedBox1);
                //CoverBox(OpenedBox2);
            }
            void CheckBoxesIsSame()
            {
                if (OpenedBox1.Tag.ToString() == OpenedBox2.Tag.ToString())
                    BoxesIsSame();
                else
                    BoxesIsNotSame();
            }
            void CheckIsThereBoxesWillClosed()
            {
                if (IsRightChoice)
                    return;

                CoverBox(OpenedBox1);
                CoverBox(OpenedBox2);
            }
            void EnableOrDisableTimer(bool Value)
            {
                frm.timer1.Enabled = Value;
            }
            void ChangeScoreLabelValue()
            {
                frm.lblScore.Text = GameStatus.Score.ToString() + "/" + (Boxes.Length / 2).ToString();
            }
            void ChangeScoreProogressBarValue()
            {
                frm.cpbScore.Value = GameStatus.Score;
            }
            void ChangeTimerLableValue()
            {
                frm.lblTimer.Text = GameStatus.TimeLeft.ToString("D2"); 
            }
            void ChangeTimerProgressBarValue()
            {
                frm.cpbTimer.Value = GameStatus.TimeLeft;
            }
            void ResultMessage(string Message ,MessageDialogIcon icon )
            {
                frm.guna2MessageDialog1.Icon = icon;
                frm.guna2MessageDialog1.Show(Message, "Game Result");
            }
            void GameOver()
            {
                EnableOrDisableTimer(false);
                EnableOrDisableAllBoxes(false);
            }
            void CheckWin()
            {
                if (GameStatus.Score == Boxes.Length / 2)
                {
                    GameOver();
                    ResultMessage("You Win", MessageDialogIcon.Information);
                }
            }
            void TimeOver()
            {
                GameOver();
                DiscoverAllBoxes();
                ResultMessage("You Are Lose",MessageDialogIcon.Error);
            }

            public enum enGameMode { Play, Start, Stop, End }

            public enGameMode GameMode;
            public clsMemoryGame(Form1 form)
            {
                frm = form;
                InitializeBoxesArray();
                InitializeImagesArray();
                GameStatus.GameTime = 50;//
                frm.cpbTimer.Maximum = GameStatus.GameTime;
                Reset();
                //SetBoxsImageIndexRandomInTag();
                //IsRightChoice = true;
                //EnableOrDisableAllBoxes(false);
                //frm.cpbTimer.Value = GameStatus.GameTime;
                //frm.lblTimer.Text = GameStatus.GameTime.ToString();
               
            }
            public void ClickOnBox(Guna2PictureBox pb)
            {
                if (GameStatus.NumOfOpenedBoxes == 0)
                {
                    CheckIsThereBoxesWillClosed();
                    DiscoverBox(pb);
                    GameStatus.NumOfOpenedBoxes++;
                    OpenedBox1 = pb;
                    return;
                }

                if (GameStatus.NumOfOpenedBoxes == 1)
                {
                    DiscoverBox(pb);
                    GameStatus.NumOfOpenedBoxes = 0;
                    OpenedBox2 = pb;
                    CheckBoxesIsSame();
                }
            }
            public void Start()
            {
                EnableOrDisableTimer(true);
                EnableOrDisableAllBoxes(true);
            }
            public void TimerTick()
            {
                if (GameStatus.TimeLeft > 0)
                {
                    GameStatus.TimeLeft--;
                    ChangeTimerLableValue();
                    ChangeTimerProgressBarValue();
                }
                else
                {
                    TimeOver();
                }
            }
            public void Reset()
            {
                CoverAllBoxes();
                EnableOrDisableAllBoxes(false);
                IsRightChoice = true;
                RandomizeImagesArray();
                SetBoxsImageIndexRandomInTag();
                GameStatus.Score = 0;
                ChangeScoreLabelValue();
                ChangeScoreProogressBarValue();
                ChangeScoreProogressBarValue();
                GameStatus.TimeLeft = GameStatus.GameTime;
                ChangeTimerLableValue();
                ChangeTimerProgressBarValue();
            }


        }
        public Form1()
        {
            InitializeComponent();
        }

        clsMemoryGame MemoryGame;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            MemoryGame = new clsMemoryGame(this);
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb13_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb14_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb15_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void pb16_Click(object sender, EventArgs e)
        {
            MemoryGame.ClickOnBox((Guna2PictureBox)sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MemoryGame.TimerTick();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MemoryGame.GameMode == clsMemoryGame.enGameMode.Play)
                MemoryGame.Start();

        //    switch (MemoryGame.GameMode)
        //    {
        //        case clsMemoryGame.enGameMode.
        //    MemoryGame.Start();
        //    }
        }
    }

}
