namespace BlobAnalisys
{
    partial class MainForm
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.openImg_btn = new System.Windows.Forms.Button();
            this.bin_btn = new System.Windows.Forms.Button();
            this.gradED_btn = new System.Windows.Forms.Button();
            this.th_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.sobel3_radio = new System.Windows.Forms.RadioButton();
            this.sobel5_radio = new System.Windows.Forms.RadioButton();
            this.custom_radio = new System.Windows.Forms.RadioButton();
            this.scharr_radio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(215, 170);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(23, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "---";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(25, 190);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(150, 150);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(215, 190);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(150, 150);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 6;
            this.pb2.TabStop = false;
            // 
            // openImg_btn
            // 
            this.openImg_btn.Location = new System.Drawing.Point(25, 24);
            this.openImg_btn.Name = "openImg_btn";
            this.openImg_btn.Size = new System.Drawing.Size(85, 53);
            this.openImg_btn.TabIndex = 7;
            this.openImg_btn.Text = "Open Image";
            this.openImg_btn.UseVisualStyleBackColor = true;
            this.openImg_btn.Click += new System.EventHandler(this.openImg_btn_Click);
            // 
            // bin_btn
            // 
            this.bin_btn.Location = new System.Drawing.Point(116, 24);
            this.bin_btn.Name = "bin_btn";
            this.bin_btn.Size = new System.Drawing.Size(85, 53);
            this.bin_btn.TabIndex = 8;
            this.bin_btn.Text = "Binarize";
            this.bin_btn.UseVisualStyleBackColor = true;
            this.bin_btn.Click += new System.EventHandler(this.bin_btn_Click);
            // 
            // gradED_btn
            // 
            this.gradED_btn.Location = new System.Drawing.Point(207, 24);
            this.gradED_btn.Name = "gradED_btn";
            this.gradED_btn.Size = new System.Drawing.Size(85, 53);
            this.gradED_btn.TabIndex = 9;
            this.gradED_btn.Text = "Gradient EdgeDet";
            this.gradED_btn.UseVisualStyleBackColor = true;
            this.gradED_btn.Click += new System.EventHandler(this.gradED_btn_Click);
            // 
            // th_textBox
            // 
            this.th_textBox.Location = new System.Drawing.Point(244, 83);
            this.th_textBox.Name = "th_textBox";
            this.th_textBox.Size = new System.Drawing.Size(51, 22);
            this.th_textBox.TabIndex = 10;
            this.th_textBox.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Str";
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(405, 190);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(150, 150);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 12;
            this.pb3.TabStop = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(405, 170);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(23, 17);
            this.lbl3.TabIndex = 13;
            this.lbl3.Text = "---";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(25, 170);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(23, 17);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "---";
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(595, 190);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(150, 150);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 14;
            this.pb4.TabStop = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(595, 170);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(23, 17);
            this.lbl4.TabIndex = 16;
            this.lbl4.Text = "---";
            // 
            // sobel3_radio
            // 
            this.sobel3_radio.AutoSize = true;
            this.sobel3_radio.Location = new System.Drawing.Point(298, 24);
            this.sobel3_radio.Name = "sobel3_radio";
            this.sobel3_radio.Size = new System.Drawing.Size(91, 21);
            this.sobel3_radio.TabIndex = 17;
            this.sobel3_radio.TabStop = true;
            this.sobel3_radio.Text = "Sobel 3x3";
            this.sobel3_radio.UseVisualStyleBackColor = true;
            // 
            // sobel5_radio
            // 
            this.sobel5_radio.AutoSize = true;
            this.sobel5_radio.Location = new System.Drawing.Point(298, 43);
            this.sobel5_radio.Name = "sobel5_radio";
            this.sobel5_radio.Size = new System.Drawing.Size(91, 21);
            this.sobel5_radio.TabIndex = 18;
            this.sobel5_radio.TabStop = true;
            this.sobel5_radio.Text = "Sobel 5x5";
            this.sobel5_radio.UseVisualStyleBackColor = true;
            // 
            // custom_radio
            // 
            this.custom_radio.AutoSize = true;
            this.custom_radio.Location = new System.Drawing.Point(298, 81);
            this.custom_radio.Name = "custom_radio";
            this.custom_radio.Size = new System.Drawing.Size(76, 21);
            this.custom_radio.TabIndex = 19;
            this.custom_radio.TabStop = true;
            this.custom_radio.Text = "Custom";
            this.custom_radio.UseVisualStyleBackColor = true;
            // 
            // scharr_radio
            // 
            this.scharr_radio.AutoSize = true;
            this.scharr_radio.Location = new System.Drawing.Point(298, 62);
            this.scharr_radio.Name = "scharr_radio";
            this.scharr_radio.Size = new System.Drawing.Size(71, 21);
            this.scharr_radio.TabIndex = 20;
            this.scharr_radio.TabStop = true;
            this.scharr_radio.Text = "Scharr";
            this.scharr_radio.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 386);
            this.Controls.Add(this.scharr_radio);
            this.Controls.Add(this.custom_radio);
            this.Controls.Add(this.sobel5_radio);
            this.Controls.Add(this.sobel3_radio);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.th_textBox);
            this.Controls.Add(this.gradED_btn);
            this.Controls.Add(this.bin_btn);
            this.Controls.Add(this.openImg_btn);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.checkBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Button openImg_btn;
        private System.Windows.Forms.Button bin_btn;
        private System.Windows.Forms.Button gradED_btn;
        private System.Windows.Forms.TextBox th_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.RadioButton sobel3_radio;
        private System.Windows.Forms.RadioButton sobel5_radio;
        private System.Windows.Forms.RadioButton custom_radio;
        private System.Windows.Forms.RadioButton scharr_radio;
    }
}

