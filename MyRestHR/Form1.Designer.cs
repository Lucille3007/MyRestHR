﻿
namespace MyRestHR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BackGround = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.BarBoredrs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarBoredrs)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackGround.Image = ((System.Drawing.Image)(resources.GetObject("BackGround.Image")));
            this.BackGround.Location = new System.Drawing.Point(367, 0);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(1035, 751);
            this.BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackGround.TabIndex = 0;
            this.BackGround.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 675);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(1, 5);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(336, 165);
            this.titleLbl.TabIndex = 5;
            this.titleLbl.Text = "My\r\n   Little\r\n      Restaurant";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(122)))), ((int)(((byte)(121)))));
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddBtn.Location = new System.Drawing.Point(104, 237);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(149, 55);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add Employee";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(122)))), ((int)(((byte)(121)))));
            this.ViewBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ViewBtn.Location = new System.Drawing.Point(104, 336);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(149, 55);
            this.ViewBtn.TabIndex = 7;
            this.ViewBtn.Text = "View\r\nMode";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(367, 753);
            this.LeftPanel.TabIndex = 8;
            // 
            // BarBoredrs
            // 
            this.BarBoredrs.BackColor = System.Drawing.Color.Transparent;
            this.BarBoredrs.Location = new System.Drawing.Point(774, 5);
            this.BarBoredrs.Name = "BarBoredrs";
            this.BarBoredrs.Size = new System.Drawing.Size(517, 264);
            this.BarBoredrs.TabIndex = 9;
            this.BarBoredrs.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(174)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1402, 753);
            this.ControlBox = false;
            this.Controls.Add(this.BarBoredrs);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BackGround);
            this.Controls.Add(this.LeftPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ManagmentHR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarBoredrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox BackGround;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label titleLbl;
        public System.Windows.Forms.Button AddBtn;
        public System.Windows.Forms.Button ViewBtn;
        public System.Windows.Forms.Panel LeftPanel;
        public System.Windows.Forms.PictureBox BarBoredrs;
    }
}

