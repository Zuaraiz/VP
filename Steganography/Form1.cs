using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class Form1 : Form
    {

        string loadedimagepath, loadedimagepathD;
        string message, password = "pass";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //OpenFIleDialog
                //This opens a file dialog through which user can select image and image path is showed

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    loadedimagepath = openFileDialog1.FileName;
                    txtloadimage.Text = loadedimagepath;
                }


                //PictureBox
                //This loads the user selected picture in the picturebox

                Image picture = new Bitmap(loadedimagepath);

                pictureBox1.Image = new Bitmap(picture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                //OpenFIleDialog
                //This opens a file dialog through which user can select image and image path is showed

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    loadedimagepathD = openFileDialog1.FileName;
                    txtbrowseD.Text = loadedimagepathD;
                }


                //PictureBox
                //This loads the user selected picture in the picturebox

                Image picture1 = new Bitmap(loadedimagepathD);

                pictureBox2.Image = new Bitmap(picture1);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void rtxtmessage_TextChanged(object sender, EventArgs e)
        {
            message = rtxtmessage.Text;
        }

        private void btnencrypt_Click(object sender, EventArgs e)
        {


            string stegofile = txt.Text;
            string message = rtxtmessage.Text;
            string newmessage = "";

            try
            {

                if (loadedimagepath == "")
                {
                    MessageBox.Show("Select the cover file to encode");
                    return;
                }

                else
                {
                    //Encryption Class Functionality
                    //This gets a bmp image path and password from user and checks if the image is already encrypted or not?

                    IStegoFile stegoEN = new BMPStegoFile(loadedimagepath, password);
                    string encodedmessage = stegoEN.HiddenMessage;

                    //If yes it concatenates the previous message and new message to be encrypted

                    newmessage = encodedmessage + " " + message;

                    //Encryption
                    //This gets the new concatenated message and encrypts it into a stego file.

                    ICoverFile cover1 = new BMPCoverFile(loadedimagepath);
                    cover1.CreateStegoFile(stegofile, newmessage, password);

                    MessageBox.Show("Message hidden successfully");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btndecrypt_Click(object sender, EventArgs e)
        {

            

            try
            {
                if (loadedimagepathD == "")
                {
                    MessageBox.Show("Select the stego file to decode");
                    return;
                }

                //Decryption Class Functionality
                //This gets a stego image file and password than decrypts the file to extract the hidden message

                IStegoFile stego = new BMPStegoFile(loadedimagepathD, password);

                //This displays the encrypted message in the selected field

                rtxtencryptmessage.Text = stego.HiddenMessage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = "Windows Bitmap (*.bmp)|*.bmp";
                ofd.CheckFileExists = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txt.Text = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
