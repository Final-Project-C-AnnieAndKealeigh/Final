using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WillowWoods
{
    public partial class WillowWoodsForm : Form
    {
        public WillowWoodsForm()
        {
            InitializeComponent();
        }

      
        private void firstNextbtn_Click(object sender, EventArgs e)
        {
            OnceUponlbl.Visible = false;
            storylbl.Visible = true;
            next2btn.Visible = true;
        }

        private void next2btn_Click_1(object sender, EventArgs e)
        {
            storylbl.Visible = false;
            firstNextbtn.Visible = false;
            willowWoodslbl.Visible = true;
            continuebtn.Visible = true;

        }

        private void continuebtn_Click_1(object sender, EventArgs e)
        {
            IntroPanel.Visible = true; 
        }

        private void nextOnebtn_Click(object sender, EventArgs e)
        {
            continuebtn.Visible = false;
            wispDialogOnelbl.Visible = false;
            youDialogOnelbl.Visible = true;
            nextTwobtn.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nextTwobtn.Visible = false;
            youDialogOnelbl.Visible = false;
            youDialog2lbl.Visible = true;
            next3btn.Visible = true;

        }

        private void next3btn_Click(object sender, EventArgs e)
        {
            next3btn.Visible = false;
            youDialog2lbl.Visible = false;
            youDialog3lbl.Visible = true;
            next4btn.Visible = true;

        }

        private void next4btn_Click(object sender, EventArgs e)
        {
            next4btn.Visible = false;
            youDialog3lbl.Visible = false;
            wispDialog2lbl.Visible = true;
            next5btn.Visible = true;
        }

        private void next5btn_Click(object sender, EventArgs e)
        {
            next4btn.Visible = false;
            mazePanel.Visible = true;
        
        }
 
        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            Point startPoint = mazePanel.Location;
            Cursor.Position = PointToScreen(startPoint);

        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            nextMazebtn.Visible = true;
        }
        private void okbtn_Click(object sender, EventArgs e)
        {
            next5btn.Visible = false;
        }
        private void nextMazebtn_Click(object sender, EventArgs e)
        {
            swordPanel.BringToFront();
            swordPanel.Visible = true;
        }

        private void next1btn_Click(object sender, EventArgs e)
        {
            youDialog1lbl.Visible = false;
            youDialogTwolbl.Visible = true;
            nextsword2btn.Visible = true;
        }

        private void nextsword2btn_Click(object sender, EventArgs e)
        {
            youDialogTwolbl.Visible = false;
            next1btn.Visible = false;
            wispDialog1lbl.Visible = true;
            pickUpbtn.Visible = true;
        }

        private void pickUpbtn_Click(object sender, EventArgs e)
        {
            nextsword2btn.Visible = false;
            wispDialog1lbl.Visible = false;
            wisppic.Visible = false;
            swordDescriptionlbl.Visible = true;
            swordpic.Visible = true;
            continueSwordbtn.Visible = true;

        }

        private int a = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            a++;
            int min = 1;
            int max = 100;
            int chance;
            Random ranNumberGenerator = new Random();
            chance = ranNumberGenerator.Next(min, max);

            do
            {
                if (chance < 50)
                {
                    wispHit1lbl.Visible = true;

                    if (a == 2)
                    {
                        wispHit1lbl.Visible = false;
                        wispHit2lbl.Visible = true;

                    }
                    else if (c > 2)
                    {
                        wispHit2lbl.Visible = false;
                        monsterPic.Visible = false;
                        monsterPic.SendToBack();
                        defeatlbl.Visible = true;
                        monsterContinuebtn.Visible = true;

                    }
                }
                else
                {
                    wispMisslbl.Visible = true;

                    if (a == 2)
                    {
                        wispMisslbl.Visible = false;
                        wispHit1lbl.Visible = true;
                    }
                    else if (c > 2)
                    {
                        wispHit1lbl.Visible = false;
                        wispHit1lbl.SendToBack();
                        monsterPic.Visible = false;
                        defeatlbl.Visible = true;
                        monsterContinuebtn.Visible = true;
                    }
                }
                
                
            } while (a > 3);

        }

        private void continueSwordbtn_Click(object sender, EventArgs e)
        {
            Monsterpanel.Visible = true;
            Monsterpanel.BringToFront();
            Monsterpanel.Show();
        }

        private void monsterContinuebtn_Click(object sender, EventArgs e)
        {
            doorPanel.Visible = true;
            doorPanel.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int userChoice;
            userChoice = Convert.ToInt32(userChoicetxt.Text);

            if (userChoice == 1)
            {
                Monsterpanel.Visible = true;
                Monsterpanel.BringToFront();
            }
            else if (userChoice == 2)
            {
                endingpanel.Visible = true;
                endingpanel.BringToFront();

            }
        }

        private int c = 0;
        private void nextEndbtn_Click(object sender, EventArgs e)
        {
            c++;
            do
            {
                
                if (c == 2)
                {
                    scene1lbl.Visible = false;
                    sunsetPicBox.Visible = true;
                }
                else if (c == 3)
                {
                    sunsetPicBox.Visible = false;
                    wispEndDialoglbl.Visible = true;
                    wispEndPic.Visible = true;
                }
                else if (c == 4)
                {
                    wispEndDialoglbl.Visible = false;
                    youEndDialoglbl.Visible = true;
                }
                else if (c == 5)
                {
                    youEndDialoglbl.Visible = false;
                    wispEndDialog2lbl.Visible = true;
                }
                else if (c == 6)
                {
                    wispEndDialog2lbl.Visible = false;
                    scene2lbl.Visible = true;
                }
                else if (c == 7)
                {
                    scene2lbl.Visible = false;
                    wispEndPic.Visible = false;
                    sunsetPicBox.Visible = true;
                }
                else if (c == 8)
                {
                    sunsetPicBox.Visible = false;
                    wispEndPic.Visible = true;
                    youEndDialog3lbl.Visible = true;
                }
                else if (c == 9)
                {
                    youEndDialog3lbl.Visible = false;
                    wispEndDialog3lbl.Visible = true;
                }
                else if ( c == 10)
                {
                    wispEndDialog3lbl.Visible = false;
                    youEndDialog4lbl.Visible = true;
                }
                else if (c == 11)
                {
                    youEndDialog4lbl.Visible = false;
                    wispEndDialog4lbl.Visible = true;
                }
                else if (c == 12)
                {
                    wispEndDialog4lbl.Visible = false;
                    scene3lbl.Visible = true;
                }
                else if (c == 13)
                {
                    scene3lbl.Visible = false;
                    wispEndDialog5lbl.Visible = true;
                } 
                else if (c == 14)
                {
                    wispEndDialog5lbl.Visible = false;
                    scene4lbl.Visible = true;
                }
                else if (c == 15)
                {
                    scene4lbl.Visible = false;
                    scene5lbl.Visible = true;
                }
                else if (c == 16)
                {
                    scene5lbl.Visible = false;
                    wispEndPic.Visible = false;
                    endlbl.Visible = true;
                }
            } while (c > 16);

            nextEndbtn.Visible = false;
            endbtn.Visible = true;
            
        }

        private void endbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
     
}
