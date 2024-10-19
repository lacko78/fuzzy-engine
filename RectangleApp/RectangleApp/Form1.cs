using System;
using System.Drawing;
using System.Windows.Forms;

namespace RectangleApp
{
    public partial class Form1 : Form
    {
        // Globális változók deklarálása
        private float aspectRatio = 1.0f; // Alapértelmezett oldalarány
        private int rectWidth = 100; // Kezdeti szélesség
        private int rectHeight = 100; // Kezdeti magasság
        private bool isValid = true; // A textboxba írt érték helyességének ellenõrzése

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            {
                if (isValid)
                {
                    // Téglalap középre igazítása
                    int centerX = (this.ClientSize.Width - rectWidth) / 2;
                    int centerY = (this.ClientSize.Height - rectHeight) / 2;

                    // Téglalap kirajzolása
                    e.Graphics.FillRectangle(Brushes.Blue, centerX, centerY, rectWidth, rectHeight);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // A téglalap szélességét a TrackBar értéke alapján állítjuk be
            rectWidth = trackBar1.Value; 
            rectHeight = (int)(rectWidth / aspectRatio);

            // Újrarajzolás
            Invalidate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float ratio;

            // Konvertáljuk a TextBox tartalmát valós számmá
            if (float.TryParse(textBox1.Text, out ratio) && ratio > 0 && ratio <= 1)
            {
                aspectRatio = ratio;
                isValid = true;

                // A téglalap új méretének megadása
                rectHeight = (int)(rectWidth / aspectRatio);
            }
            else
            {
                isValid = false; // Hibás érték esetén ne jelenjen meg semmi
            }

            // Újrarajzolás
            Invalidate();
        }
    }
}
