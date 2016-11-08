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

namespace LostV2
{
    public partial class Donut : Form
    {
        int scene = 0;  // tracks what part of the game the user is at
        Random randGen = new Random();
        public Donut()
        {
            InitializeComponent();

            //display initial message and options
            outputLabel.Text = "One day, Mr.Steel asked you to get him a donut. Will you go for him?";
            redLabel.Text = "Yes";
            blueLabel.Text = "No";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 3;
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
                    scene = 9;
                }

            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 6)
                {
                    int chance = randGen.Next(1, 101);
                    if (chance < 80)
                    {
                        scene = 8;
                    }
                    else
                    {
                        scene = 12;
                    }
                }
                else if (scene == 7)
                {
                    scene = 10;
                }
                else if (scene == 7)
                {
                    scene = 11;
                }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "One day, Mr.Steel asked you to get him a donut. \nWill you go for him?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 1:
                    outputLabel.Text = "You went out from the classroom. \nWill you turn left or right? ";
                    redLabel.Text = "Left";
                    blueLabel.Text = "Right";
                    break;
                case 2:
                    outputLabel.Text = "You got kicked out from his class. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 3:
                    outputLabel.Text = "You got caught by Mr.Cassone. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No"; 
                    break;
                case 4:
                    outputLabel.Text = "Mr. Armstrong is walking on the hallway. \nWill you go say hi to him or ignore and walk by? ";
                    redLabel.Text = "Ignore and walk By";
                    blueLabel.Text = "Go say hi to him";
                    break;
                case 5:
                    outputLabel.Text = "Mr.Armstrong told Mr.Cassone that you are skipping classes. \nSo you got caught by Mr.Cassone. Play again? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "Mr. Armstrong likes to see people skipping Mr. Steel's classes.\nSo he wants to give u a $5 gift card for skipping Mr. Steel's math class.\nWill you accpect or refuse his kindness?";
                    redLabel.Text = "Accept";
                    blueLabel.Text = "Refuse";
                    break;
                case 7:
                    outputLabel.Text = "You went to Timmy and got donut and coffee. \nWill you run back, walk back or just go home with the coffee and donut?";
                    redLabel.Text = "Walk Back";
                    blueLabel.Text = "Run Back";
                    yellowlabel.Text = "Go Home eat the donut and drink the coffee";
                    break;
                default:
                    break;
            }
        }

    }

}
