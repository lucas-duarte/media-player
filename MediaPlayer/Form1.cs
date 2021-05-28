using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "(*.MP3;*.WAV;*.WMV)|*.MP3;*.WAV;*.WMV";
            if (Abrir.ShowDialog() == DialogResult.OK)
             {
                 axWindowsMediaPlayer1.URL = Abrir.FileName;
                 label1.Text = Abrir.FileName;
                 btnAbrirArquivo.Enabled = false;
                 BtnPause.Enabled = true;
                 BtnStop.Enabled = true;
             } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            btnAbrirArquivo.Enabled = false;
            BtnPlay.Enabled = false;
            BtnPause.Enabled = true;
            BtnStop.Enabled = true;

        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            btnAbrirArquivo.Enabled = false;
            BtnPlay.Enabled = true;
            BtnPause.Enabled = false;
            BtnStop.Enabled = true;

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            btnAbrirArquivo.Enabled = true;
            BtnPlay.Enabled = false;
            BtnPause.Enabled = false;
            BtnStop.Enabled = true;

        }

        private void btnVlmAumenta_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = axWindowsMediaPlayer1.settings.volume + 10;
        }

        private void btnVlmBaixa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = axWindowsMediaPlayer1.settings.volume - 10;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = hScrollBar1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
