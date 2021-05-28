namespace MediaPlayer
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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVlmBaixa = new System.Windows.Forms.Button();
            this.btnVlmAumenta = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(355, 57);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(239, 121);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Location = new System.Drawing.Point(44, 57);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(97, 61);
            this.btnAbrirArquivo.TabIndex = 1;
            this.btnAbrirArquivo.Text = "Abrir Arquivo";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnVlmBaixa
            // 
            this.btnVlmBaixa.Image = global::MediaPlayer.Properties.Resources.volume_down;
            this.btnVlmBaixa.Location = new System.Drawing.Point(254, 379);
            this.btnVlmBaixa.Name = "btnVlmBaixa";
            this.btnVlmBaixa.Size = new System.Drawing.Size(75, 39);
            this.btnVlmBaixa.TabIndex = 7;
            this.btnVlmBaixa.UseVisualStyleBackColor = true;
            this.btnVlmBaixa.Click += new System.EventHandler(this.btnVlmBaixa_Click);
            // 
            // btnVlmAumenta
            // 
            this.btnVlmAumenta.Image = global::MediaPlayer.Properties.Resources.volume_up;
            this.btnVlmAumenta.Location = new System.Drawing.Point(394, 379);
            this.btnVlmAumenta.Name = "btnVlmAumenta";
            this.btnVlmAumenta.Size = new System.Drawing.Size(75, 39);
            this.btnVlmAumenta.TabIndex = 6;
            this.btnVlmAumenta.UseVisualStyleBackColor = true;
            this.btnVlmAumenta.Click += new System.EventHandler(this.btnVlmAumenta_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Image = global::MediaPlayer.Properties.Resources.stop__1_;
            this.BtnStop.Location = new System.Drawing.Point(435, 272);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 60);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.Image = global::MediaPlayer.Properties.Resources.pause_button;
            this.BtnPause.Location = new System.Drawing.Point(317, 272);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(75, 60);
            this.BtnPause.TabIndex = 4;
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Image = global::MediaPlayer.Properties.Resources.play_button;
            this.BtnPlay.Location = new System.Drawing.Point(195, 272);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(75, 60);
            this.BtnPlay.TabIndex = 3;
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(195, 447);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(315, 31);
            this.hScrollBar1.TabIndex = 8;
            this.hScrollBar1.Value = 50;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 528);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.btnVlmBaixa);
            this.Controls.Add(this.btnVlmAumenta);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrirArquivo);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button btnVlmAumenta;
        private System.Windows.Forms.Button btnVlmBaixa;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

