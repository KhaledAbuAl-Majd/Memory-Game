using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MemoryGame.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MemoryGame
{

    public partial class Form1 : Form
    {
        public class clsMemoryGame
        {
            struct stGameStatus
            {
                public byte GameTime;
                public byte TimeLeft;
                public byte FullScore;
                public byte Score;
            }
            static Form1 frm;
            Image[] images;
            Guna2PictureBox[] Boxes;
            Guna2PictureBox OpenedBox1, OpenedBox2;
            bool IsRightChoice;
            byte NumOfOpenedBoxes;
            byte PreStartTime;
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

                for (byte i = 0; i < GameStatus.FullScore; i++)
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

                for (byte i = 0; i < GameStatus.FullScore; i++) 
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
                foreach (Guna2PictureBox pb in Boxes)
                {
                    DiscoverBox(pb);
                }
            }
            void CoverAllBoxes()
            {
                foreach (Guna2PictureBox pb in Boxes)
                    CoverBox(pb);
            }
            void EnableOrDisableBox(Guna2PictureBox pb, bool Value)
            {
                pb.Enabled = Value;
            }
            void EnableOrDisableAllBoxes(bool Value)
            {
                foreach (Guna2PictureBox pb in Boxes)
                    EnableOrDisableBox(pb, Value);
            }
            void ChangeBoxBackColor(Guna2PictureBox pb,Color color)
            {
                pb.BackColor = color;
            }
            void ChangeAllBoxesBackColor(Color color)
            {
                foreach(Guna2PictureBox pb in Boxes)
                {
                    ChangeBoxBackColor(pb, color);
                }
            }
            void BoxesIsSame()
            {
                GameStatus.Score++;
                IsRightChoice = true;
                EnableOrDisableBox(OpenedBox1, false);
                EnableOrDisableBox(OpenedBox2, false);
                ChangeBoxBackColor(OpenedBox1, Color.LimeGreen);
                ChangeBoxBackColor(OpenedBox2, Color.LimeGreen);
                ChangeScoreLabelValue();
                ChangeScoreProogressBarValue();
                CheckWin();
            }
            void BoxesIsNotSame()
            {
                IsRightChoice = false;
                EnableOrDisableBox(OpenedBox1, true);
                
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
            void ResultMessage(string Message, MessageDialogIcon icon)
            {
                frm.guna2MessageDialog1.Icon = icon;
                frm.guna2MessageDialog1.Show(Message, "Game Result");
            }
            void ChangeResultLable(string Text)
            {
                frm.lblResult.Text = Text;
            }
            void GameOver()
            {
                EnableOrDisableTimer(false);
                EnableOrDisableAllBoxes(false);
                ChangePlay_Stop_ResetButtonTextAndToolTip("Reset", "Press To Reset");
                GameMode = enGameMode.End;
            }
            void CheckWin()
            {
                if (GameStatus.Score == GameStatus.FullScore) 
                {
                    GameOver();
                    ResultMessage("Game Over, You Win", MessageDialogIcon.Information);
                    ChangeResultLable("Win");
                }
            }
            void TimeOver()
            {
                GameOver();
                DiscoverAllBoxes();
                ResultMessage("Time Over,You Lose", MessageDialogIcon.Error);
                ChangeResultLable("Lose");
            }
            void EnableOrDisableLevelComboBox(bool Value)
            {
                frm.cbLevel.Enabled = Value;
            }
            void ResetBoxes()
            {
                CoverAllBoxes();
                EnableOrDisableAllBoxes(false);
                //ChangeAllBoxesBackColor(Color.Transparent);

                foreach (Guna2PictureBox pb in Boxes)
                {
                    pb.Tag = null;
                    ChangeBoxBackColor(pb, Color.Transparent);
                }
            }
            void ChangeTimeLeftAndTimeLabels()
            {
                GameStatus.TimeLeft = GameStatus.GameTime;
                ChangeTimerLableValue();
                ChangeTimerProgressBarValue();
            }
            void ChangeGameTime(byte Value)
            {
                GameStatus.GameTime = Value;
                frm.cpbTimer.Maximum = GameStatus.GameTime;
                frm.cpbTimer.Value = GameStatus.GameTime;
                ChangeTimeLeftAndTimeLabels();
            }
            void ChangePlay_Stop_ResetButtonTextAndToolTip(string btnText,string ToolTipText)
            {
                frm.btnStart_Pause_Reset.Text = btnText;
                frm.guna2HtmlToolTip1.SetToolTip(frm.btnStart_Pause_Reset, ToolTipText);
            }
            async void Start()
            {
                EnableOrDisableLevelComboBox(false);
                DiscoverAllBoxes();
                await Task.Delay(PreStartTime * 1000);
                CoverAllBoxes();
                EnableOrDisableTimer(true);
                EnableOrDisableAllBoxes(true);
                ChangePlay_Stop_ResetButtonTextAndToolTip("Stop", "Press To Pause");
                GameMode = enGameMode.Playing;
            }
            void Stop()
            {
                EnableOrDisableTimer(false);
                EnableOrDisableAllBoxes(false);
                ChangePlay_Stop_ResetButtonTextAndToolTip("Resume", "Press To Resume");
                GameMode = enGameMode.Stopped;
            }
            void Resume()
            {
                EnableOrDisableTimer(true);
                EnableOrDisableAllBoxes(true);
                ChangePlay_Stop_ResetButtonTextAndToolTip("Stop", "Press To Pause");
                GameMode = enGameMode.Playing;
            }
            void Reset()
            {
                ResetBoxes();
                EnableOrDisableLevelComboBox(true);
                ChangePlay_Stop_ResetButtonTextAndToolTip("Start", "Press To Start");
                GameMode = enGameMode.ReadyToStart;
                IsRightChoice = true;
                RandomizeImagesArray();
                SetBoxsImageIndexRandomInTag();
                GameStatus.Score = 0;
                ChangeScoreLabelValue();
                ChangeScoreProogressBarValue();
                ChangeScoreProogressBarValue();
                ChangeTimeLeftAndTimeLabels();
                ChangeResultLable("");
                //GameStatus.TimeLeft = GameStatus.GameTime;
                //ChangeTimerLableValue();
                //ChangeTimerProgressBarValue();
            }
          

            public enum enLevel { Easy, Medium, Hard, VeryHard }
            public enum enGameMode { ReadyToStart, Playing, Stopped, End }

            public enLevel Level;

            public enGameMode GameMode;
            public clsMemoryGame(Form1 form)
            {
                frm = form;
                InitializeBoxesArray();
                GameStatus.FullScore = Convert.ToByte(Boxes.Length / 2);
                InitializeImagesArray();
                Reset();
                GameMode = enGameMode.ReadyToStart;
                PreStartTime = 3;  
            }
            public void ClickOnBox(Guna2PictureBox pb)
            {
                if (NumOfOpenedBoxes == 0)
                {
                    CheckIsThereBoxesWillClosed();
                    EnableOrDisableBox(pb, false);
                    DiscoverBox(pb);
                    NumOfOpenedBoxes++;
                    OpenedBox1 = pb;
                    return;
                }

                if (NumOfOpenedBoxes == 1)
                {
                    DiscoverBox(pb);
                    NumOfOpenedBoxes = 0;
                    OpenedBox2 = pb;
                    CheckBoxesIsSame();
                }
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
            public void LevelChanged()
            {
                switch (Level)
                {
                    case enLevel.Easy:
                        ChangeGameTime(80);
                        break;

                    case enLevel.Medium:
                        ChangeGameTime(50);
                        break;

                    case enLevel.Hard:
                        ChangeGameTime(30);
                            break;

                    case enLevel.VeryHard:
                        ChangeGameTime(15);
                        break;

                }
            }
            public void ClickOnPlay_Stop_Resut_Button()
            {
                switch (GameMode)
                {
                    case clsMemoryGame.enGameMode.ReadyToStart:
                        Start();
                        break;

                    case clsMemoryGame.enGameMode.Playing:
                        Stop();
                        break;

                    case clsMemoryGame.enGameMode.Stopped:
                        Resume();
                        break;

                    case clsMemoryGame.enGameMode.End:
                        Reset();
                        break;

                }
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
            cbLevel.SelectedIndex = 0;
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
            MemoryGame.ClickOnPlay_Stop_Resut_Button();
        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemoryGame.Level = (clsMemoryGame.enLevel)cbLevel.SelectedIndex;
            MemoryGame.LevelChanged();
        }
    }

}
