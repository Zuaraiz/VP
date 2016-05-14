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
using Steganography;

namespace VP_Project
{
    public partial class Form1 : Form
    {
        string loadedimagepath;
        string  password = "pass";
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
            //open file dialogue
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.bmp) | *bmp";
            openDialog.InitialDirectory = @"C:\Users\Zuraizz\Desktop";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxFilePath.Text = openDialog.FileName.ToString();
                    pictureBox.ImageLocation = textBoxFilePath.Text;
                    loadedimagepath = textBoxFilePath.Text;
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: coud not read from disk \n" + ex.Message);
                }
            }
            Image picture = new Bitmap(loadedimagepath);

            pictureBox.Image = new Bitmap(picture);
            


        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            
            string stegofile = textBoxFilePath.Text;
            string message = textBoxMessage.Text;
            string newmessage = "";

            try
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
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Filter = "Image Files (*.bmp) | *bmp";
                    saveFile.InitialDirectory = @"C:\Users\Zuraizz\Desktop";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        textBoxFilePath.Text = saveFile.FileName.ToString();
                        pictureBox.ImageLocation = textBoxFilePath.Text;

                        picture.Save(textBoxFilePath.Text);
                    }
                

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (loadedimagepath == "")
                {
                    MessageBox.Show("Select the stego file to decode");
                    return;
                }

                //Decryption Class Functionality
                //This gets a stego image file and password than decrypts the file to extract the hidden message

                IStegoFile stego = new BMPStegoFile(loadedimagepath, password);

                //This displays the encrypted message in the selected field

                textBoxMessage.Text = stego.HiddenMessage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    };
}
