using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
/*
 * Created by: Tiva Rait
 * Created on: 27-03-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Walking Man 
 * This program shows a man walking fast
*/

namespace WalkingManTivaR
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            // Declaring constants and variables
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            // Continue through this loop until MAX_FRAMES is reached
            while  (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    this.picWalkMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    this.picWalkMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    this.picWalkMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    this.picWalkMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    this.picWalkMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    this.picWalkMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    this.picWalkMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    this.picWalkMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    this.picWalkMan.Image = Properties.Resources.walk9;
                }
                else if (pictureFrameCounter == 10)
                {
                    this.picWalkMan.Image = Properties.Resources.walk10;
                }

                // To Slow down the process
                Thread.Sleep(150);
                //Refresh the form
                this.Refresh();
                //Increment picture counter
                pictureFrameCounter = pictureFrameCounter + 1;

            }
        }
    }
}
