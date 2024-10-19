using System;
using System.Drawing;
using System.Windows.Forms;

namespace RectangleApp
{
    public partial class Form1 : Form
    {
        // Glob�lis v�ltoz�k deklar�l�sa
        private float aspectRatio = 1.0f; // Alap�rtelmezett oldalar�ny
        private int rectWidth = 100; // Kezdeti sz�less�g
        private int rectHeight = 100; // Kezdeti magass�g
        private bool isValid = true; // A textboxba �rt �rt�k helyess�g�nek ellen�rz�se

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            {
                if (isValid)
                {
                    // T�glalap k�z�pre igaz�t�sa
                    int centerX = (this.ClientSize.Width - rectWidth) / 2;
                    int centerY = (this.ClientSize.Height - rectHeight) / 2;

                    // T�glalap kirajzol�sa
                    e.Graphics.FillRectangle(Brushes.Blue, centerX, centerY, rectWidth, rectHeight);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // A t�glalap sz�less�g�t a TrackBar �rt�ke alapj�n �ll�tjuk be
            rectWidth = trackBar1.Value; 
            rectHeight = (int)(rectWidth / aspectRatio);

            // �jrarajzol�s
            Invalidate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float ratio;

            // Konvert�ljuk a TextBox tartalm�t val�s sz�mm�
            if (float.TryParse(textBox1.Text, out ratio) && ratio > 0 && ratio <= 1)
            {
                aspectRatio = ratio;
                isValid = true;

                // A t�glalap �j m�ret�nek megad�sa
                rectHeight = (int)(rectWidth / aspectRatio);
            }
            else
            {
                isValid = false; // Hib�s �rt�k eset�n ne jelenjen meg semmi
            }

            // �jrarajzol�s
            Invalidate();
        }
    }
}
