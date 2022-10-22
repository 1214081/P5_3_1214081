using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_1214081
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbMouse_Click(object sender, EventArgs e)
        {
            if (rbMouse.Checked == true)
            {
                tlsKetGambar.Text = "Cocok! Ini adalah gambar Mouse";
            }
            else
            {
                tlsKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar mouse";
            }
        }

        private void tsbMonitor_Click(object sender, EventArgs e)
        {
            if (rbMonitor.Checked == true)
            {
                tlsKetGambar.Text = "Cocok! Ini adalah gambar Monitor";
            }
            else
            {
                tlsKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar monitor";
            }
        }

        private void tsbPrinter_Click(object sender, EventArgs e)
        {
            if (rbPrinter.Checked == true)
            {
                tlsKetGambar.Text = "Cocok! Ini adalah gambar Printer";
            }
            else
            {
                tlsKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar printer";
            }
        }

        private void tsbKeyboard_Click(object sender, EventArgs e)
        {
            if (rbKeyboard.Checked == true)
            {
                tlsKetGambar.Text = "Cocok! Ini adalah gambar Keyboard";
            }
            else
            {
                tlsKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar keyboard";
            }
        }

        private void tsbScanner_Click(object sender, EventArgs e)
        {
            if (rbScanner.Checked == true)
            {
                tlsKetGambar.Text = "Cocok! Ini adalah gambar Scanner";
            }
            else
            {
                tlsKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar scanner";
            }
        }
    }
}
