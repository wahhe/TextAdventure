/// created by : Wah He
/// date       : Nov. 6
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LostV2
{
    public partial class Donut : Form
    {
        int scene = 0;  // tracks what part of the game the user is at
        Random randGen = new Random();

        // make sound player here
        SoundPlayer player = new SoundPlayer(Properties.Resources.Donuts_Go_Nuts_);
        
        public Donut()
        {
            InitializeComponent();

            //display initial message and options
            outputLabel.Text = "One day, Mr.Steel asked you to get him a donut. \nWill you go for him?";
            redLabel.Text = "Yes";
            blueLabel.Text = "No";

            // put sound in player
            // play
            player.Play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.B)       //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 2)
                {
                    scene = 0;
                }
                else if (scene == 3)
                {
                    scene = 0;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 6)
                {
                    scene = 7;
                }
                else if (scene == 7)
                {
                    scene = 8;
                }
                else if (scene == 8)
                {
                    scene = 0;
                }
                else if (scene == 9)
                {
                    scene = 0;
                }
                else if (scene == 10)
                {
                    scene = 0;
                }

            }
            else if (e.KeyCode == Keys.M)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 2)  
                {
                    this.Close();
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 3)
                {
                    this.Close();   //close the program
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 5)
                {
                    this.Close();   //close the program
                }
                else if (scene == 6)  //80% chance to success
                {
                    int chance = randGen.Next(1, 101);
                    if (chance > 80)
                    {
                        scene = 7;
                    }
                    else
                    {
                        scene = 11;
                    }
                }
                else if (scene == 7)
                {
                    scene = 9;
                }
                else if (scene == 8)
                {
                    this.Close();
                }
                else if (scene == 9)
                {
                    this.Close();
                }
                else if (scene == 10)
                {
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.N)  //yellow button press
            {
                if (scene == 7)
                {
                    scene = 10;
                }
            }
            

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "One day, Mr.Steel asked you to get him a donut. \nWill you go for him?";
                    redLabel.Text = "Sure, I love Mr.Steel.";
                    blueLabel.Text = "Not a chance!";
                    yellowlabel.Text = "";
                    break;
                case 1:
                    outputLabel.Text = "You went out from the classroom. \nWill you turn left or right? ";
                    redLabel.Text = "Left";
                    blueLabel.Text = "Right";
                    yellowlabel.Text = "";
                    break;
                case 2:
                    player.Stop();
                    player = new SoundPlayer(Properties.Resources.Oh_No_No);
                    player.Play();

                    outputLabel.Text = "You got kicked out from his class. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowlabel.Text = "";
                    break;
                case 3:
                    player.Stop();
                    player = new SoundPlayer(Properties.Resources.Oh_No_No);
                    player.Play();

                    outputLabel.Text = "You got caught by Mr.Cassone. \nPlay again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowlabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "Mr. Armstrong is walking on the hallway. \nWill you go say hi to him or ignore and walk by? ";
                    redLabel.Text = "Mr.Armstrong is crazy! I'd better ignore him and walk by."; 
                    blueLabel.Text = "Oh I like Mr.Armstrong, I should go say hi to him";
                    yellowlabel.Text = "";
                    break;
                case 5:
                    player.Stop();
                    player = new SoundPlayer(Properties.Resources.Oh_No_No);
                    player.Play();

                    outputLabel.Text = "Mr.Armstrong told Mr.Cassone that you are skipping classes, so you got caught by Mr.Cassone. \nPlay again? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowlabel.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "Mr. Armstrong likes to see people skipping Mr. Steel's classes.\nSo he wants to give u a $5 gift card for skipping Mr. Steel's math class.\nWill you accpect or refuse his kindness?";
                    redLabel.Text = "Definitely accept! ";
                    blueLabel.Text = "No, I'm good.";
                    yellowlabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "You went to Tim Horton and got donut and coffee. \nWhat will you do next?";
                    redLabel.Text = "Definitely walk back, no rush!";
                    blueLabel.Text = "Run Back, I don't wanna Mr.Steel to wait too long.";
                    yellowlabel.Text = "I should go home immediately and enjoy the donut and coffee";
                    break;
                case 8:
                    outputLabel.Text = "You brought the donut back to Mr.steel. \nHe gave you a chance to retake your worst test in return. \nPlay again?? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowlabel.Text = "";
                    break;
                case 9:
                    player.Stop();
                    player = new SoundPlayer(Properties.Resources.Oh_No_No);
                    player.Play();

                    outputLabel.Text = "The donut fell off as you ran back to school, and u stepped on it accidently. \nPlay again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowlabel.Text = "";

                    break;
                case 10:
                    player.Stop();
                    player = new SoundPlayer(Properties.Resources.Oh_No_No);
                    player.Play();

                    outputLabel.Text = "Mr. Steel was so mad that you ate the donut.\nHe decided to delect your best mark in the exam. \nPlay again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowlabel.Text = "";
                    break;
                case 11:
                    player.Stop();
                    player = new SoundPlayer(Properties.Resources.Oh_No_No);
                    player.Play();

                    outputLabel.Text = "Mr. Armstrong was so mad because you don't accept his kindness.\nSo he locked u in the 208. \nPlay again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowlabel.Text = "";
                    break;
                default:
                    break;
            }
        }

        //private void redLabel_Click(object sender, EventArgs e)
       

        //private void yellowlabel_Click(object sender, EventArgs e)

        //private void redLabel_Click(object sender, EventArgs e) 
    }

}
