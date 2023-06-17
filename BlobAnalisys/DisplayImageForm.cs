using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlobAnalisys
{
    public partial class DisplayImageForm : Form
    {
        public DisplayImageForm()
        {
            InitializeComponent();
        }

        public void SetImage(Bitmap img)
        {
            pictureBox.Image = img;
        }

        public void SetName(string name)
        {
            this.Text = name;
        }

        ~DisplayImageForm()
        {
            pictureBox = null;
        }

        private void DisplayImageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            pictureBox.Image = null;
        }
    }
}
