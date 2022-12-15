﻿namespace HotelManagement.GUI
{
    partial class FormKetNoiCSDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKetNoiCSDL));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.checkBoxLuu = new System.Windows.Forms.CheckBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDB = new HotelManagement.CTControls.CTTextBox();
            this.ctMaximize = new HotelManagement.CTControls.CTMaximize();
            this.ctMinimize = new HotelManagement.CTControls.CTMinimize();
            this.ctClose = new HotelManagement.CTControls.CTClose();
            this.buttonKetNoi = new HotelManagement.CTControls.CTButton();
            this.textBoxServer = new HotelManagement.CTControls.CTTextBox();
            this.panelBackground.SuspendLayout();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.pictureBox1);
            this.panelBackground.Controls.Add(this.textBoxDB);
            this.panelBackground.Controls.Add(this.panelControlBox);
            this.panelBackground.Controls.Add(this.checkBoxLuu);
            this.panelBackground.Controls.Add(this.labelTitle);
            this.panelBackground.Controls.Add(this.buttonKetNoi);
            this.panelBackground.Controls.Add(this.textBoxServer);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(599, 330);
            this.panelBackground.TabIndex = 0;
            this.panelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBackground_Paint);
            this.panelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBackground_MouseDown);
            // 
            // panelControlBox
            // 
            this.panelControlBox.BackColor = System.Drawing.Color.White;
            this.panelControlBox.Controls.Add(this.ctMaximize);
            this.panelControlBox.Controls.Add(this.ctMinimize);
            this.panelControlBox.Controls.Add(this.ctClose);
            this.panelControlBox.Location = new System.Drawing.Point(501, 2);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(95, 30);
            this.panelControlBox.TabIndex = 14;
            // 
            // checkBoxLuu
            // 
            this.checkBoxLuu.AutoSize = true;
            this.checkBoxLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLuu.Location = new System.Drawing.Point(450, 221);
            this.checkBoxLuu.Name = "checkBoxLuu";
            this.checkBoxLuu.Size = new System.Drawing.Size(106, 25);
            this.checkBoxLuu.TabIndex = 13;
            this.checkBoxLuu.Text = "Lưu kết nối";
            this.checkBoxLuu.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(290, 56);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(278, 37);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Kết nối cơ sở dữ liệu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(51, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxDB
            // 
            this.textBoxDB.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDB.BorderColor = System.Drawing.Color.Gray;
            this.textBoxDB.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxDB.BorderRadius = 10;
            this.textBoxDB.BorderSize = 1;
            this.textBoxDB.ForeColor = System.Drawing.Color.Black;
            this.textBoxDB.IsFocused = false;
            this.textBoxDB.Location = new System.Drawing.Point(309, 166);
            this.textBoxDB.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDB.Multiline = false;
            this.textBoxDB.Name = "textBoxDB";
            this.textBoxDB.Padding = new System.Windows.Forms.Padding(20, 7, 7, 7);
            this.textBoxDB.PasswordChar = false;
            this.textBoxDB.PlaceholderColor = System.Drawing.Color.Silver;
            this.textBoxDB.PlaceholderText = "Nhập tên database";
            this.textBoxDB.ReadOnly = false;
            this.textBoxDB.Size = new System.Drawing.Size(241, 28);
            this.textBoxDB.TabIndex = 11;
            this.textBoxDB.Texts = "";
            this.textBoxDB.UnderlineedStyle = false;
            // 
            // ctMaximize
            // 
            this.ctMaximize.BackColor = System.Drawing.Color.Transparent;
            this.ctMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMaximize.BackgroundImage")));
            this.ctMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctMaximize.Enabled = false;
            this.ctMaximize.Location = new System.Drawing.Point(10, 7);
            this.ctMaximize.Name = "ctMaximize";
            this.ctMaximize.Size = new System.Drawing.Size(15, 15);
            this.ctMaximize.TabIndex = 2;
            // 
            // ctMinimize
            // 
            this.ctMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ctMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMinimize.BackgroundImage")));
            this.ctMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctMinimize.Enabled = false;
            this.ctMinimize.Location = new System.Drawing.Point(40, 6);
            this.ctMinimize.Name = "ctMinimize";
            this.ctMinimize.Size = new System.Drawing.Size(15, 15);
            this.ctMinimize.TabIndex = 1;
            // 
            // ctClose
            // 
            this.ctClose.BackColor = System.Drawing.Color.Transparent;
            this.ctClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctClose.BackgroundImage")));
            this.ctClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctClose.Location = new System.Drawing.Point(71, 6);
            this.ctClose.Name = "ctClose";
            this.ctClose.Size = new System.Drawing.Size(15, 15);
            this.ctClose.TabIndex = 0;
            this.ctClose.Click += new System.EventHandler(this.ctClose_Click);
            // 
            // buttonKetNoi
            // 
            this.buttonKetNoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(172)))), ((int)(((byte)(242)))));
            this.buttonKetNoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(172)))), ((int)(((byte)(242)))));
            this.buttonKetNoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(172)))), ((int)(((byte)(242)))));
            this.buttonKetNoi.BorderRadius = 15;
            this.buttonKetNoi.BorderSize = 0;
            this.buttonKetNoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKetNoi.FlatAppearance.BorderSize = 0;
            this.buttonKetNoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKetNoi.ForeColor = System.Drawing.Color.White;
            this.buttonKetNoi.Location = new System.Drawing.Point(348, 257);
            this.buttonKetNoi.Name = "buttonKetNoi";
            this.buttonKetNoi.Size = new System.Drawing.Size(150, 40);
            this.buttonKetNoi.TabIndex = 12;
            this.buttonKetNoi.Text = "Kết nối";
            this.buttonKetNoi.TextColor = System.Drawing.Color.White;
            this.buttonKetNoi.UseVisualStyleBackColor = false;
            this.buttonKetNoi.Click += new System.EventHandler(this.buttonKetNoi_Click);
            // 
            // textBoxServer
            // 
            this.textBoxServer.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxServer.BorderColor = System.Drawing.Color.Gray;
            this.textBoxServer.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxServer.BorderRadius = 10;
            this.textBoxServer.BorderSize = 1;
            this.textBoxServer.ForeColor = System.Drawing.Color.Black;
            this.textBoxServer.IsFocused = false;
            this.textBoxServer.Location = new System.Drawing.Point(309, 110);
            this.textBoxServer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxServer.Multiline = false;
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Padding = new System.Windows.Forms.Padding(20, 7, 7, 7);
            this.textBoxServer.PasswordChar = false;
            this.textBoxServer.PlaceholderColor = System.Drawing.Color.Silver;
            this.textBoxServer.PlaceholderText = "Nhập tên server";
            this.textBoxServer.ReadOnly = false;
            this.textBoxServer.Size = new System.Drawing.Size(241, 28);
            this.textBoxServer.TabIndex = 10;
            this.textBoxServer.Texts = "";
            this.textBoxServer.UnderlineedStyle = false;
            // 
            // FormKetNoiCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 330);
            this.Controls.Add(this.panelBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKetNoiCSDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKetNoiCSDL";
            this.Activated += new System.EventHandler(this.FormKetNoiCSDL_Activated);
            this.Load += new System.EventHandler(this.FormKetNoiCSDL_Load);
            this.SizeChanged += new System.EventHandler(this.FormKetNoiCSDL_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormKetNoiCSDL_Paint);
            this.Resize += new System.EventHandler(this.FormKetNoiCSDL_Resize);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private CTControls.CTTextBox textBoxDB;
        private System.Windows.Forms.Panel panelControlBox;
        private CTControls.CTMaximize ctMaximize;
        private CTControls.CTMinimize ctMinimize;
        private CTControls.CTClose ctClose;
        private System.Windows.Forms.CheckBox checkBoxLuu;
        private System.Windows.Forms.Label labelTitle;
        private CTControls.CTButton buttonKetNoi;
        private CTControls.CTTextBox textBoxServer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}