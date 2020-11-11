using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_3A713113.Properties;

namespace WP_2020_01_HW02_3A713113
{
    public partial class Form1 : Form
    {
        List<Image> chen = new List<Image>();
        int check = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //result.Add(Resources._1);
            chen.Add(Resources._1);
            chen.Add(Resources._2);
            chen.Add(Resources._3);
            chen.Add(Resources._4);
            chen.Add(Resources._5);
            chen.Add(Resources._6);
            chen.Add(Resources._7);
            chen.Add(Resources._8);
            chen.Add(Resources._9);
            chen.Add(Resources._10);
            chen.Add(Resources._11);
            chen.Add(Resources._12);
            chen.Add(Resources._13);
            chen.Add(Resources._14);
            chen.Add(Resources._15);
            chen.Add(Resources._16);
            chen.Add(Resources._17);
            chen.Add(Resources._18);
            chen.Add(Resources._19);
            chen.Add(Resources._20);
            chen.Add(Resources._21);
            chen.Add(Resources._22);
            chen.Add(Resources._23);
            chen.Add(Resources._24);
            chen.Add(Resources._25);
            chen.Add(Resources._26);
            chen.Add(Resources._27);
            chen.Add(Resources._28);
            chen.Add(Resources._29);
            chen.Add(Resources._30);
            chen.Add(Resources._31);
            chen.Add(Resources._32);
            chen.Add(Resources._33);
            chen.Add(Resources._34);
            chen.Add(Resources._35);
            chen.Add(Resources._36);
            chen.Add(Resources._37);
            chen.Add(Resources._38);
            chen.Add(Resources._39);
            chen.Add(Resources._40);
            chen.Add(Resources._41);
            chen.Add(Resources._42);
            chen.Add(Resources._43);
            chen.Add(Resources._44);
            chen.Add(Resources._45);
            chen.Add(Resources._46);
            chen.Add(Resources._47);
            chen.Add(Resources._48);
            chen.Add(Resources._49);
            chen.Add(Resources._50);
            chen.Add(Resources._51);
            chen.Add(Resources._52);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int xindex = (new Random()).Next(51) + 1;//產生亂數
            int y = (new Random()).Next(4) + 1;
            if (check != xindex)//檢查是否與上張牌相同
            {
                pictureBox1.Image = chen[xindex];
                check = xindex;
            }
            else//相同的話
            {
                if (xindex >= check)
                {
                    pictureBox1.Image = chen[xindex - y];
                }
                if (xindex <= check)
                {
                    pictureBox1.Image = chen[xindex + y];
                }


            }

       
        }
    } }
