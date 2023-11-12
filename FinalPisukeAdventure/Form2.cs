using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPisukeAdventure
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int count = 0; int score = 0;
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("掰掰！！！", "結束", MessageBoxButtons.OK);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("確定要離開嗎？", "小遊戲", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            KeyPreview = true;

            pictureBox1.Location = new Point(20, 270);   //主角
            label5.Location = new Point(-4, 126);        //第一條跑道
            label6.Location = new Point(-4, 255);         //第二條跑道
            label7.Location = new Point(-4, 384);         //第三條跑道

            pictureBox2.Location = new Point(1250, 140); //披薩
            pictureBox3.Location = new Point(1350, 140); //炸彈
            pictureBox4.Location = new Point(1450, 140); //薯條
            pictureBox11.Location = new Point(1600, 140); //披薩

            pictureBox5.Location = new Point(1250, 270); //熱狗
            pictureBox6.Location = new Point(1350, 270); //漢堡
            pictureBox7.Location = new Point(1450, 270); //炸彈
            pictureBox12.Location = new Point(1600, 270); //熱狗

            pictureBox8.Location = new Point(1250, 400);//炸彈
            pictureBox9.Location = new Point(1350, 400); //薯條
            pictureBox10.Location = new Point(1450, 400); //披薩
            pictureBox13.Location = new Point(1550, 400); //炸彈

            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count = Convert.ToInt32(label2.Text) - 1;
            label2.Text = count.ToString();
            if (count == 0)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                Form3 cForm = new Form3();
                cForm.FormClosed += new FormClosedEventHandler(Form3_FormClosed);
                cForm.Show();
                this.Hide();
                cForm.show_form2_data(label4.Text);
            }
            if (count == 51)
            {
                pictureBox3.Visible = true;
                pictureBox3.Location = new Point(1500, 140);  //第一條跑道的位置                  
                test1();
                pictureBox5.Visible = true;
                pictureBox5.Location = new Point(1300, 270);  //第二條跑道的位置 
                test2();
                pictureBox9.Visible = true;
                pictureBox9.Location = new Point(1450, 400);  //第二條跑道的位置 
                test3();
            }
            if (count == 46)
            {
                pictureBox2.Visible = true;
                pictureBox2.Location = new Point(1350, 140);  //第一條跑道的位置  
                //pictureBox4.Location = new Point(1400, 140);  //第一條跑道的位置             
                test1();
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1450, 270);  //第二條跑道的位置
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1500, 270);  //第二條跑道的位置
                test2();
                // pictureBox10.Location = new Point(1300, 400);  //第3條跑道的位置
                pictureBox8.Visible = true;
                pictureBox8.Location = new Point(1450, 400);  //第3條跑道的位置
                test3();
            }
            if (count == 40)
            {
                //pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                //pictureBox2.Location = new Point(1350, 140);  //第一條跑道的位置  
                pictureBox3.Location = new Point(1450, 140);  //第一條跑道的位置             
                test1();
                pictureBox5.Visible = true;
                pictureBox5.Location = new Point(1450, 270);  //第2條跑道的位置             
                test2();
                pictureBox9.Visible = true;
                pictureBox9.Location = new Point(1250, 400);  //第3條跑道的位置 
                //pictureBox8.Location = new Point(1300, 400);  //第3條跑道的位置
                test3();
            }
            if (count == 36)
            {
                //pictureBox2.Location = new Point(1300, 140);  //第一條跑道的位置 
                //test1();
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1450, 270);  //第2條跑道的位置    
                //pictureBox7.Location = new Point(1550, 270);
                test2();
                pictureBox8.Visible = true;
                pictureBox8.Location = new Point(1250, 400);  //第3條跑道的位置
                pictureBox13.Visible = true;
                pictureBox13.Location = new Point(1550, 400);
                test3();
            }
            if (count == 35)
            {
                //pictureBox11.Location = new Point(1450, 140);
                //test1();
                pictureBox12.Visible = true;
                pictureBox12.Location = new Point(1500, 270);
            }
            if (count == 32)
            {
                //pictureBox2.Visible = true;
                pictureBox11.Visible = true;
                pictureBox11.Location = new Point(1350, 140);  //第一條跑道的位置 
                test1();
                //pictureBox5.Location = new Point(1350, 270);  //第2條跑道的位置             
                //test2();
                pictureBox10.Visible = true;
                pictureBox10.Location = new Point(1350, 400);  //第3條跑道的位置
                pictureBox9.Visible = true;
                pictureBox9.Location = new Point(1600, 400);  //第3條跑道的位置
                test3();
            }
            if (count == 27)
            {
                pictureBox4.Visible = true;
                pictureBox4.Location = new Point(1450, 140);  //第一條跑道的位置 
                test1();
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1450, 270);  //第二條跑道的位置
                pictureBox5.Visible = true;
                pictureBox5.Location = new Point(1350, 270);  //第2條跑道的位置
                test2();
                pictureBox8.Visible = true;
                pictureBox8.Location = new Point(1350, 400);  //第3條跑道的位置
                test3();
            }
            if (count == 20)
            {
                pictureBox3.Visible = true;
                pictureBox3.Location = new Point(1400, 140);  //第一條跑道的位置 
                //pictureBox11.Location = new Point(1450, 140);
                test1();
                //pictureBox7.Location = new Point(1350, 270);  //第二條跑道的位置  
                pictureBox12.Visible = true;
                pictureBox12.Location = new Point(1550, 270);
                test2();
                pictureBox9.Visible = true;
                pictureBox9.Location = new Point(1250, 400);  //第3條跑道的位置
                pictureBox13.Visible = true;
                pictureBox13.Location = new Point(1550, 400);
                test3();
            }
            if (count == 16)
            {
                pictureBox2.Visible = true;
                pictureBox2.Location = new Point(1300, 140);  //第一條跑道的位置 
                test1();
                //pictureBox6.Location = new Point(1450, 270);  //第二條跑道的位置                
                // test2();
                pictureBox10.Visible = true;
                pictureBox10.Location = new Point(1450, 400);  //第3條跑道的位置
                test3();
            }
            if (count == 13)
            {
                pictureBox4.Visible = true;
                pictureBox4.Location = new Point(1500, 140);  //第一條跑道的位置 
                test1();
                pictureBox5.Visible = true;
                pictureBox5.Location = new Point(1550, 270);  //第二條跑道的位置                
                test2();
                pictureBox8.Visible = true;
                pictureBox8.Location = new Point(1350, 400);  //第3條跑道的位置
                pictureBox9.Visible = true;
                pictureBox9.Location = new Point(1600, 400);  //第3條跑道的位置
                test3();
            }
            if (count == 9)
            {
                //pictureBox2.Location = new Point(1300, 140);  //第一條跑道的位置 
                //test1();
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1450, 270);  //第二條跑道的位置                
                test2();
                //pictureBox10.Location = new Point(1350, 400);  //第3條跑道的位置              
                //test3();
            }
            if (count == 6)
            {
                // pictureBox5.Location = new Point(1300, 270);  //第二條跑道的位置 
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, 270);  //第二條跑道的位置                
                test2();
                pictureBox8.Visible = true;
                pictureBox8.Location = new Point(1350, 400);  //第3條跑道的位置
                test3();
            }
            if (count == 5)
            {
                pictureBox3.Visible = true;
                pictureBox3.Location = new Point(1300, 140);
                test1();
                pictureBox12.Visible = true;
                pictureBox12.Location = new Point(1550, 270);
                test2();
                pictureBox13.Visible = true;
                pictureBox13.Location = new Point(1300, 400);
                test3();
            }
            if (count == 3)
            {
                pictureBox11.Visible = true;
                pictureBox11.Location = new Point(1300, 140);
                test1();
                pictureBox10.Visible = true;
                pictureBox10.Location = new Point(1400, 400);
                test3();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left -= 120;            //披薩            
            pictureBox3.Left -= 90;            //炸彈//改90
            pictureBox4.Left -= 60;            //薯條//改70 
            pictureBox11.Left -= 55;
            test1();
            pictureBox5.Left -= 100;           //熱狗
            pictureBox6.Left -= 80;            //漢堡
            pictureBox7.Left -= 60;            //炸彈  
            pictureBox12.Left -= 55;
            test2();
            pictureBox8.Left -= 110;        //炸彈  
            pictureBox9.Left -= 90;        //薯條
            pictureBox10.Left -= 85;       //披薩  
            pictureBox13.Left -= 75;
            test3();
            if (score < 20)
            {
                timer2.Interval = 500;
            }
            else if (score >= 20 && score < 40)
            {
                timer2.Interval = 350;
            }
            else if (score >= 40)
            {
                timer2.Interval = 200;
            }
        }

        private void test1()
        {
            int pl_x1, p1_x2, p1_y1, p1_y2;
            int p2_x1, p2_x2, p2_y1, p2_y2;
            int p3_x1, p3_x2, p3_y1, p3_y2;
            int p4_x1, p4_x2, p4_y1, p4_y2;
            int p11_x1, p11_x2, p11_y1, p11_y2;

            pl_x1 = pictureBox1.Left;
            p1_y1 = pictureBox1.Top;
            p1_x2 = pl_x1 + pictureBox1.Width;
            p1_y2 = p1_y1 + pictureBox1.Height;

            p2_x1 = pictureBox2.Left;
            p2_y1 = pictureBox2.Top;
            p2_x2 = p2_x1 + pictureBox2.Width;
            p2_y2 = p2_y1 + pictureBox2.Height;

            p3_x1 = pictureBox3.Left;
            p3_y1 = pictureBox3.Top;
            p3_x2 = p3_x1 + pictureBox3.Width;
            p3_y2 = p3_y1 + pictureBox3.Height;

            p4_x1 = pictureBox4.Left;
            p4_y1 = pictureBox4.Top;
            p4_x2 = p4_x1 + pictureBox4.Width;
            p4_y2 = p4_y1 + pictureBox4.Height;

            p11_x1 = pictureBox11.Left;
            p11_y1 = pictureBox11.Top;
            p11_x2 = p11_x1 + pictureBox11.Width;
            p11_y2 = p11_y1 + pictureBox11.Height;

            if ((p1_x2 >= p2_x1) && (p2_x1 <= p1_x2) && (p2_x1 >= pl_x1) && (p2_y1 >= p1_y1) && (p1_y2 == p2_y2)) //披薩
                                                                                                                  //全部改這條 if ((p1_x2 >= p2_x1) && (p2_x1 <= p1_x2) && (p2_x1 >= pl_x1) && (p2_y1 >= p1_y1) && (p1_y2 == p2_y2))
            {
                score = Convert.ToInt32(label4.Text) + 3;
                label4.Text = score.ToString();
                pictureBox2.Visible = false;
            }
            if ((p1_x2 >= p3_x1) && (p3_x1 <= p1_x2) && (p3_x1 >= pl_x1) && (p3_y1 >= p1_y1) && (p1_y2 == p3_y2))  //炸彈
            {
                score = Convert.ToInt32(label4.Text) - 2;
                label4.Text = score.ToString();
                pictureBox3.Visible = false;
            }
            if ((p1_x2 >= p4_x1) && (p4_x1 <= p1_x2) && (p4_x1 >= pl_x1) && (p4_y1 >= p1_y1) && (p1_y2 == p4_y2))  //薯條
            {
                score = Convert.ToInt32(label4.Text) + 1;
                label4.Text = score.ToString();
                pictureBox4.Visible = false;
            }
            if ((p1_x2 >= p11_x1) && (p11_x1 <= p1_x2) && (p11_x1 >= pl_x1) && (p11_y1 >= p1_y1) && (p1_y2 == p11_y2))  //披薩
            {
                score = Convert.ToInt32(label4.Text) + 3;
                label4.Text = score.ToString();
                pictureBox11.Visible = false;
            }
        }
        private void test2()
        {
            int pl_x1, p1_x2, p1_y1, p1_y2;
            int p5_x1, p5_x2, p5_y1, p5_y2;
            int p6_x1, p6_x2, p6_y1, p6_y2;
            int p7_x1, p7_x2, p7_y1, p7_y2;
            int p12_x1, p12_x2, p12_y1, p12_y2;

            pl_x1 = pictureBox1.Left;
            p1_y1 = pictureBox1.Top;
            p1_x2 = pl_x1 + pictureBox1.Width;
            p1_y2 = p1_y1 + pictureBox1.Height;

            p5_x1 = pictureBox5.Left;
            p5_y1 = pictureBox5.Top;
            p5_x2 = p5_x1 + pictureBox5.Width;
            p5_y2 = p5_y1 + pictureBox5.Height;

            p6_x1 = pictureBox6.Left;
            p6_y1 = pictureBox6.Top;
            p6_x2 = p6_x1 + pictureBox6.Width;
            p6_y2 = p6_y1 + pictureBox6.Height;

            p7_x1 = pictureBox7.Left;
            p7_y1 = pictureBox7.Top;
            p7_x2 = p7_x1 + pictureBox7.Width;
            p7_y2 = p7_y1 + pictureBox7.Height;

            p12_x1 = pictureBox12.Left;
            p12_y1 = pictureBox12.Top;
            p12_x2 = p12_x1 + pictureBox12.Width;
            p12_y2 = p12_y1 + pictureBox12.Height;

            if ((p1_x2 >= p5_x1) && (p5_x1 <= p1_x2) && (p5_x1 >= pl_x1) && (p5_y1 >= p1_y1) && (p1_y2 == p5_y2))  //熱狗
            {
                score = Convert.ToInt32(label4.Text) + 1;
                label4.Text = score.ToString();
                pictureBox5.Visible = false;
            }
            if ((p1_x2 >= p6_x1) && (p6_x1 <= p1_x2) && (p6_x1 >= pl_x1) && (p6_y1 >= p1_y1) && (p1_y2 == p6_y2))  //漢堡
            {
                score = Convert.ToInt32(label4.Text) + 3;
                label4.Text = score.ToString();
                pictureBox6.Visible = false;
            }
            if ((p1_x2 >= p7_x1) && (p7_x1 <= p1_x2) && (p7_x1 >= pl_x1) && (p7_y1 >= p1_y1) && (p1_y2 == p7_y2))  //炸彈
            {
                score = Convert.ToInt32(label4.Text) - 2;
                label4.Text = score.ToString();
                pictureBox7.Visible = false;
            }
            if ((p1_x2 >= p12_x1) && (p12_x1 <= p1_x2) && (p12_x1 >= pl_x1) && (p12_y1 >= p1_y1) && (p1_y2 == p12_y2))  //炸彈
            {
                score = Convert.ToInt32(label4.Text) + 1;
                label4.Text = score.ToString();
                pictureBox12.Visible = false;
            }
        }
        private void test3()
        {
            int pl_x1, p1_x2, p1_y1, p1_y2;
            int p8_x1, p8_x2, p8_y1, p8_y2;
            int p9_x1, p9_x2, p9_y1, p9_y2;
            int p10_x1, p10_x2, p10_y1, p10_y2;
            int p13_x1, p13_x2, p13_y1, p13_y2;

            pl_x1 = pictureBox1.Left;
            p1_y1 = pictureBox1.Top;
            p1_x2 = pl_x1 + pictureBox1.Width;
            p1_y2 = p1_y1 + pictureBox1.Height;

            p8_x1 = pictureBox8.Left;
            p8_y1 = pictureBox8.Top;
            p8_x2 = p8_x1 + pictureBox8.Width;
            p8_y2 = p8_y1 + pictureBox8.Height;

            p9_x1 = pictureBox9.Left;
            p9_y1 = pictureBox9.Top;
            p9_x2 = p9_x1 + pictureBox9.Width;
            p9_y2 = p9_y1 + pictureBox9.Height;

            p10_x1 = pictureBox10.Left;
            p10_y1 = pictureBox10.Top;
            p10_x2 = p10_x1 + pictureBox10.Width;
            p10_y2 = p10_y1 + pictureBox10.Height;

            p13_x1 = pictureBox13.Left;
            p13_y1 = pictureBox13.Top;
            p13_x2 = p13_x1 + pictureBox13.Width;
            p13_y2 = p13_y1 + pictureBox13.Height;

            if ((p1_x2 >= p8_x1) && (p8_x1 <= p1_x2) && (p8_x1 >= pl_x1) && (p8_y1 >= p1_y1) && (p1_y2 == p8_y2))  //炸彈
            {
                score = Convert.ToInt32(label4.Text) - 2;
                label4.Text = score.ToString();
                pictureBox8.Visible = false;
            }

            if ((p1_x2 >= p9_x1) && (p9_x1 <= p1_x2) && (p9_x1 >= pl_x1) && (p9_y1 >= p1_y1) && (p1_y2 == p9_y2))  //薯條
            {
                score = Convert.ToInt32(label4.Text) + 1;
                label4.Text = score.ToString();
                pictureBox9.Visible = false;
            }

            if ((p1_x2 >= p10_x1) && (p10_x1 <= p1_x2) && (p10_x1 >= pl_x1) && (p10_y1 >= p1_y1) && (p1_y2 == p10_y2))  //披薩
            {
                score = Convert.ToInt32(label4.Text) + 3;
                label4.Text = score.ToString();
                pictureBox10.Visible = false;
            }
            if ((p1_x2 >= p13_x1) && (p13_x1 <= p1_x2) && (p13_x1 >= pl_x1) && (p13_y1 >= p1_y1) && (p1_y2 == p13_y2))  //炸彈
            {
                score = Convert.ToInt32(label4.Text) - 2;
                label4.Text = score.ToString();
                pictureBox13.Visible = false;
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: { pictureBox1.Top -= 130; } break;
                case Keys.Down: { pictureBox1.Top += 130; } break;
            }
            if (pictureBox1.Top <= 215)
            {
                pictureBox1.Location = new Point(20, 140);
            }
            else if (pictureBox1.Top >= 400)
            {
                pictureBox1.Location = new Point(20, 400);
            }

        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            Width = this.Size.Width;
            Height = this.Size.Height;
        }
    }
}
