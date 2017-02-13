using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gaugeD
{
    public partial class Form1 : Form
    {
        int mouse_down = 1;
        float x,y,x1,y1,x2,y2,x3,y3,r;
        bool openDrawCircle = false;
        bool openDrawLine = false;

        public Form1()
        {
            InitializeComponent();
        }

        drawcircle drawC = new drawcircle();
        drawline drawL = new drawline();
        point_to_line_distance rusltD = new point_to_line_distance();

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Drawing.Graphics graphics = this.CreateGraphics();
            //System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(100, 100, 200, 200);
            //graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            //graphics.DrawRectangle(System.Drawing.Pens.Red, rectangle);
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
         
            //System.Drawing.Graphics graphics = this.CreateGraphics();
            //System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(100, 100, 200, 200);
            //graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            //graphics.DrawRectangle(System.Drawing.Pens.Red, rectangle);

            if (drawC != null)
            {               
                //graphics.DrawEllipse(Pens.Red, Convert.ToSingle(textBox1.Text), Convert.ToSingle(textBox2.Text), 200, 200);
                //graphics.DrawEllipse(Pens.Red, (x - r-1), (y - r-1), r*2, r*2);
                //e.Graphics.DrawEllipse(Pens.Red, (x - r - 1), (y - r - 1), r * 2, r * 2);
                
                drawC.Redraw(e.Graphics);
             
                
            }

            if (drawL != null)
            {

                //e.Graphics.DrawLine(Pens.Black, x2, y2, x3, y3);
                drawL.Redraw(e.Graphics);
            }
                    
        }

        private void drawCircle_Click(object sender, EventArgs e)
        {
           
                openDrawCircle = true;
                openDrawLine = false;
                        
                x_point.Text = "x座標:";
                y_point.Text = "y座標:";
                x1_point.Text = "x1座標:";
                y1_point.Text = "y1座標:";
                mouse_down = 1;
        }      

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //drawC = new drawcircle(x,y,x1,y1);
            if (openDrawCircle == true)
            {
                if (mouse_down == 1)
                {
                    x = e.X;
                    y = e.Y;
                    x_point.Text ="x座標:" + e.X.ToString();
                    y_point.Text ="y座標:" + e.Y.ToString();
                }
                else if (mouse_down == 2)
                {
                    x1 = e.X;
                    y1 = e.Y;
                    x1_point.Text = "x1座標:" + e.X.ToString();
                    y1_point.Text = "y1座標:" + e.Y.ToString();

                    drawC.drawcircle_point(x, y, x1, y1);
                    drawC.distanceR();
          
                    openDrawLine = true;
                    Refresh();
                }
                mouse_down++;     
            }

           

            if (openDrawLine == true)
            {
                if (mouse_down == 1)
                {
                    x2 = e.X;
                    y2 = e.Y;
                    x2_point.Text = "x2座標:" + e.X.ToString();
                    y2_point.Text = "y2座標:" + e.Y.ToString();

                }
                else if (mouse_down == 2)
                {
                    x3 = e.X;
                    y3 = e.Y;
                    x3_point.Text = "x3座標:" + e.X.ToString();
                    y3_point.Text = "y3座標:" + e.Y.ToString();

                    drawL.drawline_point(x2, y2, x3, y3);
                 
                    openDrawCircle = true;
                    Refresh();
                }
                mouse_down++;
            }
           
        }

        private void drawLine_Click(object sender, EventArgs e)
        {
            openDrawLine = true;
            openDrawCircle = false;

            x2_point.Text = "x2座標:";
            y2_point.Text = "y2座標:";
            x3_point.Text = "x3座標:";
            y3_point.Text = "y3座標:";
            mouse_down = 1;
        }

        private void clculate_Click(object sender, EventArgs e)
        {
            //y=-(a/b)x+c
            //pt1.Y=X * a + b
            //pt2.Y=X * a + b
            //m = (y3 - y2) / (x3 - x2);
            //b = y3 - (m * x3);
            //rusltDistance = (Math.Abs((m * x) - y + b)) / (Math.Sqrt(m*m + (-1)*(-1)));
            rusltD.rusltDistance_math(x, y, x2, y2, x3, y3);
            ruslt.Text = rusltD.rusltDistance_math(x, y, x2, y2, x3, y3).ToString();
                      
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "x座標" + e.X + "y座標" + e.Y;
        }
    }
}
