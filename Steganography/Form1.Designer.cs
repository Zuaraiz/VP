namespace Steganography
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.lblstegofile = new System.Windows.Forms.Label();
            this.lblloadimage = new System.Windows.Forms.Label();
            this.lblwritemessage = new System.Windows.Forms.Label();
            this.txtloadimage = new System.Windows.Forms.TextBox();
            this.btnbrowseimage = new System.Windows.Forms.Button();
            this.rtxtmessage = new System.Windows.Forms.RichTextBox();
            this.btnencrypt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblencryptmessage = new System.Windows.Forms.Label();
            this.rtxtencryptmessage = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbrowseD = new System.Windows.Forms.TextBox();
            this.btndecrypt = new System.Windows.Forms.Button();
            this.lblloadimgD = new System.Windows.Forms.Label();
            this.btnbrowseD = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Image Preview :";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.saveBtn);
            this.groupBox2.Controls.Add(this.txt);
            this.groupBox2.Controls.Add(this.lblstegofile);
            this.groupBox2.Controls.Add(this.lblloadimage);
            this.groupBox2.Controls.Add(this.lblwritemessage);
            this.groupBox2.Controls.Add(this.txtloadimage);
            this.groupBox2.Controls.Add(this.btnbrowseimage);
            this.groupBox2.Controls.Add(this.rtxtmessage);
            this.groupBox2.Controls.Add(this.btnencrypt);
            this.groupBox2.Location = new System.Drawing.Point(9, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 249);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(438, 186);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 30);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Browse";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.MintCream;
            this.txt.Location = new System.Drawing.Point(158, 188);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(232, 24);
            this.txt.TabIndex = 12;
            // 
            // lblstegofile
            // 
            this.lblstegofile.AutoSize = true;
            this.lblstegofile.BackColor = System.Drawing.Color.White;
            this.lblstegofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstegofile.Location = new System.Drawing.Point(21, 193);
            this.lblstegofile.Name = "lblstegofile";
            this.lblstegofile.Size = new System.Drawing.Size(65, 16);
            this.lblstegofile.TabIndex = 11;
            this.lblstegofile.Text = "Save As :";
            // 
            // lblloadimage
            // 
            this.lblloadimage.AutoSize = true;
            this.lblloadimage.BackColor = System.Drawing.Color.White;
            this.lblloadimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloadimage.Location = new System.Drawing.Point(21, 45);
            this.lblloadimage.Name = "lblloadimage";
            this.lblloadimage.Size = new System.Drawing.Size(86, 16);
            this.lblloadimage.TabIndex = 0;
            this.lblloadimage.Text = "Load Image :";
            // 
            // lblwritemessage
            // 
            this.lblwritemessage.AutoSize = true;
            this.lblwritemessage.BackColor = System.Drawing.Color.White;
            this.lblwritemessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwritemessage.Location = new System.Drawing.Point(6, 125);
            this.lblwritemessage.Name = "lblwritemessage";
            this.lblwritemessage.Size = new System.Drawing.Size(133, 16);
            this.lblwritemessage.TabIndex = 1;
            this.lblwritemessage.Text = "Message to Encrypt :";
            // 
            // txtloadimage
            // 
            this.txtloadimage.BackColor = System.Drawing.Color.MintCream;
            this.txtloadimage.Location = new System.Drawing.Point(158, 40);
            this.txtloadimage.Name = "txtloadimage";
            this.txtloadimage.Size = new System.Drawing.Size(232, 24);
            this.txtloadimage.TabIndex = 2;
            // 
            // btnbrowseimage
            // 
            this.btnbrowseimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowseimage.Location = new System.Drawing.Point(438, 38);
            this.btnbrowseimage.Name = "btnbrowseimage";
            this.btnbrowseimage.Size = new System.Drawing.Size(80, 30);
            this.btnbrowseimage.TabIndex = 4;
            this.btnbrowseimage.Text = "Browse";
            this.btnbrowseimage.UseVisualStyleBackColor = true;
            this.btnbrowseimage.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtxtmessage
            // 
            this.rtxtmessage.BackColor = System.Drawing.Color.MintCream;
            this.rtxtmessage.Location = new System.Drawing.Point(158, 99);
            this.rtxtmessage.Name = "rtxtmessage";
            this.rtxtmessage.Size = new System.Drawing.Size(335, 58);
            this.rtxtmessage.TabIndex = 7;
            this.rtxtmessage.Text = "";
            this.rtxtmessage.TextChanged += new System.EventHandler(this.rtxtmessage_TextChanged);
            // 
            // btnencrypt
            // 
            this.btnencrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnencrypt.Location = new System.Drawing.Point(580, 108);
            this.btnencrypt.Name = "btnencrypt";
            this.btnencrypt.Size = new System.Drawing.Size(132, 64);
            this.btnencrypt.TabIndex = 6;
            this.btnencrypt.Text = "Encrypt";
            this.btnencrypt.UseVisualStyleBackColor = true;
            this.btnencrypt.Click += new System.EventHandler(this.btnencrypt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(167, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.lblencryptmessage);
            this.tabPage2.Controls.Add(this.rtxtencryptmessage);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            // 
            // lblencryptmessage
            // 
            this.lblencryptmessage.AutoSize = true;
            this.lblencryptmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblencryptmessage.Location = new System.Drawing.Point(25, 390);
            this.lblencryptmessage.Name = "lblencryptmessage";
            this.lblencryptmessage.Size = new System.Drawing.Size(158, 20);
            this.lblencryptmessage.TabIndex = 18;
            this.lblencryptmessage.Text = "Encrypted Message :";
            // 
            // rtxtencryptmessage
            // 
            this.rtxtencryptmessage.Location = new System.Drawing.Point(191, 352);
            this.rtxtencryptmessage.Name = "rtxtencryptmessage";
            this.rtxtencryptmessage.Size = new System.Drawing.Size(497, 94);
            this.rtxtencryptmessage.TabIndex = 17;
            this.rtxtencryptmessage.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Image Preview :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(191, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtbrowseD);
            this.groupBox3.Controls.Add(this.btndecrypt);
            this.groupBox3.Controls.Add(this.lblloadimgD);
            this.groupBox3.Controls.Add(this.btnbrowseD);
            this.groupBox3.Location = new System.Drawing.Point(6, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(731, 134);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // txtbrowseD
            // 
            this.txtbrowseD.BackColor = System.Drawing.Color.MintCream;
            this.txtbrowseD.Location = new System.Drawing.Point(137, 35);
            this.txtbrowseD.Name = "txtbrowseD";
            this.txtbrowseD.Size = new System.Drawing.Size(272, 24);
            this.txtbrowseD.TabIndex = 8;
            // 
            // btndecrypt
            // 
            this.btndecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndecrypt.Location = new System.Drawing.Point(580, 40);
            this.btndecrypt.Name = "btndecrypt";
            this.btndecrypt.Size = new System.Drawing.Size(126, 75);
            this.btndecrypt.TabIndex = 12;
            this.btndecrypt.Text = "Decrypt";
            this.btndecrypt.UseVisualStyleBackColor = true;
            this.btndecrypt.Click += new System.EventHandler(this.btndecrypt_Click);
            // 
            // lblloadimgD
            // 
            this.lblloadimgD.AutoSize = true;
            this.lblloadimgD.BackColor = System.Drawing.Color.White;
            this.lblloadimgD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloadimgD.Location = new System.Drawing.Point(31, 40);
            this.lblloadimgD.Name = "lblloadimgD";
            this.lblloadimgD.Size = new System.Drawing.Size(83, 16);
            this.lblloadimgD.TabIndex = 6;
            this.lblloadimgD.Text = "Load Image:";
            // 
            // btnbrowseD
            // 
            this.btnbrowseD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowseD.Location = new System.Drawing.Point(441, 33);
            this.btnbrowseD.Name = "btnbrowseD";
            this.btnbrowseD.Size = new System.Drawing.Size(80, 30);
            this.btnbrowseD.TabIndex = 10;
            this.btnbrowseD.Text = "Browse";
            this.btnbrowseD.UseVisualStyleBackColor = true;
            this.btnbrowseD.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp|All files(*.*)|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnbrowseimage;
        private System.Windows.Forms.TextBox txtloadimage;
        private System.Windows.Forms.Label lblwritemessage;
        private System.Windows.Forms.Label lblloadimage;
        private System.Windows.Forms.Button btnbrowseD;
        private System.Windows.Forms.TextBox txtbrowseD;
        private System.Windows.Forms.Label lblloadimgD;
        private System.Windows.Forms.Button btnencrypt;
        private System.Windows.Forms.Button btndecrypt;
        private System.Windows.Forms.RichTextBox rtxtmessage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblencryptmessage;
        private System.Windows.Forms.RichTextBox rtxtencryptmessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lblstegofile;
        private System.Windows.Forms.Button saveBtn;
    }
}