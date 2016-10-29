namespace SimpleSortColors
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
            this.lbSorts = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSorts
            // 
            this.lbSorts.FormattingEnabled = true;
            this.lbSorts.ItemHeight = 16;
            this.lbSorts.Location = new System.Drawing.Point(12, 12);
            this.lbSorts.Name = "lbSorts";
            this.lbSorts.Size = new System.Drawing.Size(120, 212);
            this.lbSorts.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.pbImage);
            this.panelContainer.Location = new System.Drawing.Point(138, 12);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(200, 100);
            this.panelContainer.TabIndex = 3;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Black;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(100, 50);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pbImage_Paint);
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.ItemHeight = 16;
            this.lbNumbers.Location = new System.Drawing.Point(12, 259);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(120, 132);
            this.lbNumbers.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 399);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSorts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ListBox lbNumbers;
    }
}

