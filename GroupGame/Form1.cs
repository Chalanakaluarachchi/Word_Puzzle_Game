using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxA.AllowDrop = true;
            pictureBoxB.AllowDrop = true;
            pictureBoxC.AllowDrop = true;
            pictureBoxD.AllowDrop = true;
            pictureBoxE.AllowDrop = true;
            pictureBoxF.AllowDrop = true;
            pictureBoxG.AllowDrop = true;
            pictureBoxH.AllowDrop = true;
            lblwinner.Visible = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var image = pictureBox1.Image;
            if (image == null) return;
            image.Tag = "6";
            if (pictureBox1.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("6"))
            {
                pictureBox1.Image = null;
                int counta = 1;
                int scroe = Convert.ToInt32(lblScrore.Text);
                int resultSc = counta + scroe;

                if (pictureBox4.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("6"))
                {
                    lblScrore.Text = Convert.ToString(resultSc);
                }
            }
            if (pictureBoxA.Image != null && pictureBoxB.Image != null && pictureBoxC.Image != null && pictureBoxD.Image != null && pictureBoxE.Image != null && pictureBoxF.Image != null && pictureBoxG.Image != null && pictureBoxH.Image != null)
            {
                lblwinner.Visible = true;
            }
        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void pictureBoxF_DragDrop(object sender, DragEventArgs e)
        {
            Image image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            if (image.Tag.Equals("6"))
            {
                pictureBoxF.Image = image;
            }
            else
            {
                image.Tag = "0";
            }
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            var image = pictureBox7.Image;
            if (image == null) return;
            image.Tag = "1";
            if (pictureBox7.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("1"))
            {
                pictureBox7.Image = null;
                int counta = 1;
                int scroe = Convert.ToInt32(lblScrore.Text);
                int resultSc = counta + scroe;

                if (pictureBox4.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("1"))
                {
                    lblScrore.Text = Convert.ToString(resultSc);
                }
            }
            if (pictureBoxA.Image != null && pictureBoxB.Image != null && pictureBoxC.Image != null && pictureBoxD.Image != null && pictureBoxE.Image != null && pictureBoxF.Image != null && pictureBoxG.Image != null && pictureBoxH.Image != null)
            {
                lblwinner.Visible = true;
            }
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            var image = pictureBox5.Image;
            if (image == null) return;
            image.Tag = "2";
            if (pictureBox5.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("2"))
            {
                pictureBox5.Image = null;
                int counta = 1;
                int scroe = Convert.ToInt32(lblScrore.Text);
                int resultSc = counta + scroe;

                if (pictureBox4.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("2"))
                {
                    lblScrore.Text = Convert.ToString(resultSc);
                }
            }
            if (pictureBoxA.Image != null && pictureBoxB.Image != null && pictureBoxC.Image != null && pictureBoxD.Image != null && pictureBoxE.Image != null && pictureBoxF.Image != null && pictureBoxG.Image != null && pictureBoxH.Image != null)
            {
                lblwinner.Visible = true;
            }
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            var image = pictureBox6.Image;
            if (image == null) return;
            image.Tag = "3";
            if (pictureBox6.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("3"))
            {
                pictureBox6.Image = null;
                int counta = 1;
                int scroe = Convert.ToInt32(lblScrore.Text);
                int resultSc = counta + scroe;

                if (pictureBox4.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("3"))
                {
                    lblScrore.Text = Convert.ToString(resultSc);
                }
            }
            if (pictureBoxA.Image != null && pictureBoxB.Image != null && pictureBoxC.Image != null && pictureBoxD.Image != null && pictureBoxE.Image != null && pictureBoxF.Image != null && pictureBoxG.Image != null && pictureBoxH.Image != null)
            {
                lblwinner.Visible = true;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            var image = pictureBox2.Image;
            if (image == null) return;
            image.Tag = "4";
            if (pictureBox2.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("4"))
            {
                pictureBox2.Image = null;
                int counta = 1;
                int scroe = Convert.ToInt32(lblScrore.Text);
                int resultSc = counta + scroe;

                if (pictureBox4.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("4"))
                {
                    lblScrore.Text = Convert.ToString(resultSc);
                }
            }
            if (pictureBoxA.Image != null && pictureBoxB.Image != null && pictureBoxC.Image != null && pictureBoxD.Image != null && pictureBoxE.Image != null && pictureBoxF.Image != null && pictureBoxG.Image != null && pictureBoxH.Image != null)
            {
                lblwinner.Visible = true;
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            var image = pictureBox3.Image;
            if (image == null) return;
            image.Tag = "5";
            if (pictureBox3.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("5"))
            {
                pictureBox3.Image = null;
                int counta = 1;
                int scroe = Convert.ToInt32(lblScrore.Text);
                int resultSc = counta + scroe;

                if (pictureBox4.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("5"))
                {
                    lblScrore.Text = Convert.ToString(resultSc);
                }
            }
            if (pictureBoxA.Image != null && pictureBoxB.Image != null && pictureBoxC.Image != null && pictureBoxD.Image != null && pictureBoxE.Image != null && pictureBoxF.Image != null && pictureBoxG.Image != null && pictureBoxH.Image != null)
            {
                lblwinner.Visible = true;
            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            var image = pictureBox4.Image;
            if (image == null) return;
            image.Tag = "7";
            if (pictureBox4.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("7"))
            {
                pictureBox4.Image = null;
                int counta = 1;
                int scroe = Convert.ToInt32(lblScrore.Text);
                int resultSc = counta + scroe;

                if(pictureBox4.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("7"))
                {
                    lblScrore.Text = Convert.ToString(resultSc);
                }
            }
            if (pictureBoxA.Image != null && pictureBoxB.Image != null && pictureBoxC.Image != null && pictureBoxD.Image != null && pictureBoxE.Image != null && pictureBoxF.Image != null && pictureBoxG.Image != null && pictureBoxH.Image != null)
            {
                lblwinner.Visible = true;
            }
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            var image = pictureBox8.Image;
            if (image == null) return;
            image.Tag = "8";
            if (pictureBox8.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("8"))
            {
                pictureBox8.Image = null;
                int counta = 1;
                int scroe = Convert.ToInt32(lblScrore.Text);
                int resultSc = counta + scroe;

                if (pictureBox4.DoDragDrop(image, DragDropEffects.Move) == DragDropEffects.Move && image.Tag.Equals("8"))
                {
                    lblScrore.Text = Convert.ToString(resultSc);
                }
            }
            if (pictureBoxA.Image != null && pictureBoxB.Image != null && pictureBoxC.Image != null && pictureBoxD.Image != null && pictureBoxE.Image != null && pictureBoxF.Image != null && pictureBoxG.Image != null && pictureBoxH.Image != null)
            {
                lblwinner.Visible = true;
            }

        }

        private void pictureBoxA_DragDrop(object sender, DragEventArgs e)
        {
            Image image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            if (image.Tag.Equals("1"))
            {
                pictureBoxA.Image = image;
            }
            else
            {
                image.Tag = "1";
            }
        }

        private void pictureBoxB_DragDrop(object sender, DragEventArgs e)
        {
            Image image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            if (image.Tag.Equals("2"))
            {
                pictureBoxB.Image = image;
            }
            else
            {
                image.Tag = "2";
            }
        }

        private void pictureBoxC_DragDrop(object sender, DragEventArgs e)
        {
            Image image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            if (image.Tag.Equals("3"))
            {
                pictureBoxC.Image = image;
            }
            else
            {
                image.Tag = "3";
            }
        }

        private void pictureBoxD_DragDrop(object sender, DragEventArgs e)
        {
            Image image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            if (image.Tag.Equals("4"))
            {
                pictureBoxD.Image = image;
            }
            else
            {
                image.Tag = "4";
            }
        }

        private void pictureBoxE_DragDrop(object sender, DragEventArgs e)
        {
            Image image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            if (image.Tag.Equals("5"))
            {
                pictureBoxE.Image = image;
            }
            else
            {
                image.Tag = "5";
            }
        }

        private void pictureBoxG_DragDrop(object sender, DragEventArgs e)
        {
            Image image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            if (image.Tag.Equals("7"))
            {
                pictureBoxG.Image = image;
            }
            else
            {
                image.Tag = "7";
            }
        }

        private void pictureBoxH_DragDrop(object sender, DragEventArgs e)
        {
            Image image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            if (image.Tag.Equals("8"))
            {
                pictureBoxH.Image = image;
            }
            else
            {
                image.Tag = "8";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
