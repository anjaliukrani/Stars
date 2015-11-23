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
namespace Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StarField(100);
        }

        public void StarField(int stars)
        {
            //make graphics and brush
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen drawPen = new Pen(Color.Red, 3);

            //random number
            Random randNum = new Random();
            int rand;
            int counter = 0;
            rand = randNum.Next(1, 101);

            //popping up random stars
            rand = randNum.Next(1, 101);
            while (counter <= stars)
            {
                counter++;
                int xValue = randNum.Next(0, this.Width);
                int yValue = randNum.Next(0, this.Height);


                g.FillRectangle(drawBrush, xValue, yValue, 5, 5);

                Thread.Sleep(10);

            }
        }
    private void button1_Click(object sender, EventArgs e)
        {
            StarField(100);
        }
    }
}
