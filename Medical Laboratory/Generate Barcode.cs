﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Medical_Laboratory
{
    public partial class Generate_Barcode : Form
    {
        public Generate_Barcode()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            BarcodeFormat barcode = new BarcodeFormat();
            Color foreColor = Color.Black;
            Color backColor = Color.Transparent;
            BarcodeWriter writer = new BarcodeWriter() { Format=BarcodeFormat.CODE_128};
            pic.Image = writer.Write(txtEncode.Text);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            var result=reader.Decode((Bitmap)pic.Image);   
            if(result != null) 
                txtDecode.Text = result.Text;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pic.Image != null)
                return;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() {Filter="Png|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK) 
                    pic.Image.Save(saveFileDialog.FileName);   
            }    
        }
    }
}
