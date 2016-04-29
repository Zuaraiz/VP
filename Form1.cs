using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.png , *.jpg) | *png ; *jpg";
            openDialog.InitialDirectory = @"C:\Users\Zuraizz\Desktop";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxFilePath.Text = openDialog.FileName.ToString();
                    pictureBox.ImageLocation = textBoxFilePath.Text;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: coud not read from disk \n" + ex.Message);
                }
            }


        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBoxFilePath.Text);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i,j);

                    if (i < 1 && j < textBoxMessage.TextLength)
                    {
                        //Console.WriteLine("R = [" + i + "][" + j + "]=" + pixel.R);
                        //Console.WriteLine("G = [" + i + "][" + j + "]=" + pixel.G);
                        //Console.WriteLine("B = [" + i + "][" + j + "]=" + pixel.B);
                        char letter = Convert.ToChar(textBoxMessage.Text.Substring(j,1));
                        int value = Convert.ToInt32(letter);
                        //Console.WriteLine("Letter = " + letter + " value =" + value);
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                       
                    }

                    if (i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, textBoxMessage.TextLength));
                    }
                }
             }
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Image Files (*.png , *.jpg) | *png ; *jpg";
                saveFile.InitialDirectory = @"C:\Users\Zuraizz\Desktop";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    textBoxFilePath.Text = saveFile.FileName.ToString();
                    pictureBox.ImageLocation = textBoxFilePath.Text;

                    img.Save(textBoxFilePath.Text);
                }
                
          
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            
        }
    };
}
