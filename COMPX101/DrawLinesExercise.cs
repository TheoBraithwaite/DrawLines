using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPX101
{
    public partial class FormDrawLines : Form
    {
        public FormDrawLines()
        {
            InitializeComponent();
        }

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            //Version 1 Scratch Pad.

            //Create a graphics object called paper which is
            //Connected to the picturebox specified.
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            //Create a pen object called pen1
            //In the colour blue with a width of 5
            Pen pen1 = new Pen(Color.Blue, 5);
            //Create a red pen with a width of 2
            //Pen pen2 = new Pen(Color.Red, 2);

            Point startPoint = new Point(10, 30);
            Point endPoint = new Point(100, 200);
            Point thirdPoint = new Point(150, 100);
            int x = 140;
            int y = 50;

            //Draw a blue line between the 2 point objects.
            paper.DrawLine(pen1, startPoint, endPoint);

            //Draw a second blue line from endPoint to thirdPoint.
            paper.DrawLine(pen1, endPoint, thirdPoint);

            //Draws a rectangle at the coordinates specified and the width and height specified
            //x and y being the top left hand corner of the rectangle, 100 being the width and 50 being the height.
            paper.DrawRectangle(pen1, x, y, 100, 50);

            ////Draws a line using the pen specified and
            ////Using the coordinates specified.

            paper.DrawLine(pen1, 10, 30, 100, 200);

            //Change the colour of pen1 to red
            pen1.Color = Color.Red;

            //Change the width of the pen to 2
            pen1.Width = 2;

            //Draw a red line
            paper.DrawLine(pen1, 150, 100, 250, 200);

            //Draw line from top left to bottom right
            paper.DrawLine(pen1, 0, 0, pictureBoxDisplay.Width, pictureBoxDisplay.Height);

            ////Ex 6 - It draws a triangle
            //paper.DrawLine(pen1, 100, 50, 150, 100);
            //paper.DrawLine(pen1, 150, 100, 50, 100);
            //paper.DrawLine(pen1, 50, 100, 100, 50);

            //Ex 8 - need to change all the coordinates
        }
    }
}
