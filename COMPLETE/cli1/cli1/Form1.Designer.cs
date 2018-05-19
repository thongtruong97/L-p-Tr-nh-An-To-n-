namespace cli1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtRemote = new System.Windows.Forms.TextBox();
            this.txtNhan = new System.Windows.Forms.TextBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.rncry = new System.Windows.Forms.Button();
            this.txtencry = new System.Windows.Forms.TextBox();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.txtdecry = new System.Windows.Forms.TextBox();
            this.genKey = new System.Windows.Forms.Button();
            this.decry = new System.Windows.Forms.Button();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            this.txtPubA = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPubB = new System.Windows.Forms.TextBox();
            this.txtEPAD = new System.Windows.Forms.TextBox();
            this.txtDPAD = new System.Windows.Forms.TextBox();
            this.EncrytPad = new System.Windows.Forms.Button();
            this.DecryptPad = new System.Windows.Forms.Button();
            this.keyPad = new System.Windows.Forms.TextBox();
            this.txtPad = new System.Windows.Forms.TextBox();
            this.final = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEncryptNoise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kết nối";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gửi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(5, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(115, 20);
            this.txtIP.TabIndex = 2;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(150, 4);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(53, 20);
            this.txtLocal.TabIndex = 3;
            // 
            // txtRemote
            // 
            this.txtRemote.Location = new System.Drawing.Point(235, 4);
            this.txtRemote.Name = "txtRemote";
            this.txtRemote.Size = new System.Drawing.Size(48, 20);
            this.txtRemote.TabIndex = 4;
            // 
            // txtNhan
            // 
            this.txtNhan.Location = new System.Drawing.Point(14, 62);
            this.txtNhan.Multiline = true;
            this.txtNhan.Name = "txtNhan";
            this.txtNhan.Size = new System.Drawing.Size(648, 154);
            this.txtNhan.TabIndex = 5;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(14, 222);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(352, 20);
            this.txtNhap.TabIndex = 6;
            // 
            // rncry
            // 
            this.rncry.Location = new System.Drawing.Point(8, 412);
            this.rncry.Name = "rncry";
            this.rncry.Size = new System.Drawing.Size(75, 23);
            this.rncry.TabIndex = 7;
            this.rncry.Text = "encry";
            this.rncry.UseVisualStyleBackColor = true;
            this.rncry.Visible = false;
            this.rncry.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtencry
            // 
            this.txtencry.Location = new System.Drawing.Point(8, 441);
            this.txtencry.Name = "txtencry";
            this.txtencry.Size = new System.Drawing.Size(215, 20);
            this.txtencry.TabIndex = 8;
            this.txtencry.Visible = false;
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(8, 360);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(224, 20);
            this.txtkey.TabIndex = 9;
            this.txtkey.Visible = false;
            // 
            // txtdecry
            // 
            this.txtdecry.Location = new System.Drawing.Point(8, 496);
            this.txtdecry.Name = "txtdecry";
            this.txtdecry.Size = new System.Drawing.Size(215, 20);
            this.txtdecry.TabIndex = 10;
            this.txtdecry.Visible = false;
            // 
            // genKey
            // 
            this.genKey.Location = new System.Drawing.Point(14, 248);
            this.genKey.Name = "genKey";
            this.genKey.Size = new System.Drawing.Size(75, 23);
            this.genKey.TabIndex = 11;
            this.genKey.Text = "genKey";
            this.genKey.UseVisualStyleBackColor = true;
            this.genKey.Click += new System.EventHandler(this.genKey_Click);
            // 
            // decry
            // 
            this.decry.Location = new System.Drawing.Point(8, 467);
            this.decry.Name = "decry";
            this.decry.Size = new System.Drawing.Size(75, 23);
            this.decry.TabIndex = 12;
            this.decry.Text = "decry";
            this.decry.UseVisualStyleBackColor = true;
            this.decry.Visible = false;
            this.decry.Click += new System.EventHandler(this.decry_Click);
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(614, 7);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(46, 20);
            this.txtSession.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Location = new System.Drawing.Point(429, 7);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(41, 13);
            this.lbTimer.TabIndex = 15;
            this.lbTimer.Text = "lbTimer";
            // 
            // txtPubA
            // 
            this.txtPubA.Location = new System.Drawing.Point(14, 277);
            this.txtPubA.Name = "txtPubA";
            this.txtPubA.Size = new System.Drawing.Size(224, 20);
            this.txtPubA.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtPubB
            // 
            this.txtPubB.Location = new System.Drawing.Point(8, 386);
            this.txtPubB.Name = "txtPubB";
            this.txtPubB.Size = new System.Drawing.Size(224, 20);
            this.txtPubB.TabIndex = 19;
            this.txtPubB.Visible = false;
            // 
            // txtEPAD
            // 
            this.txtEPAD.Location = new System.Drawing.Point(289, 277);
            this.txtEPAD.Name = "txtEPAD";
            this.txtEPAD.Size = new System.Drawing.Size(224, 20);
            this.txtEPAD.TabIndex = 20;
            // 
            // txtDPAD
            // 
            this.txtDPAD.Location = new System.Drawing.Point(533, 277);
            this.txtDPAD.Name = "txtDPAD";
            this.txtDPAD.Size = new System.Drawing.Size(224, 20);
            this.txtDPAD.TabIndex = 23;
            // 
            // EncrytPad
            // 
            this.EncrytPad.Location = new System.Drawing.Point(291, 248);
            this.EncrytPad.Name = "EncrytPad";
            this.EncrytPad.Size = new System.Drawing.Size(75, 23);
            this.EncrytPad.TabIndex = 27;
            this.EncrytPad.Text = "Encryt";
            this.EncrytPad.UseVisualStyleBackColor = true;
            this.EncrytPad.Click += new System.EventHandler(this.EncrytPad_Click);
            // 
            // DecryptPad
            // 
            this.DecryptPad.Location = new System.Drawing.Point(533, 251);
            this.DecryptPad.Name = "DecryptPad";
            this.DecryptPad.Size = new System.Drawing.Size(75, 23);
            this.DecryptPad.TabIndex = 28;
            this.DecryptPad.Text = "Decrypt";
            this.DecryptPad.UseVisualStyleBackColor = true;
            this.DecryptPad.Click += new System.EventHandler(this.DecryptPad_Click);
            // 
            // keyPad
            // 
            this.keyPad.Location = new System.Drawing.Point(272, 432);
            this.keyPad.Name = "keyPad";
            this.keyPad.Size = new System.Drawing.Size(224, 20);
            this.keyPad.TabIndex = 30;
            this.keyPad.Visible = false;
            // 
            // txtPad
            // 
            this.txtPad.Location = new System.Drawing.Point(272, 467);
            this.txtPad.Name = "txtPad";
            this.txtPad.Size = new System.Drawing.Size(224, 20);
            this.txtPad.TabIndex = 32;
            this.txtPad.Visible = false;
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(272, 496);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(224, 20);
            this.final.TabIndex = 33;
            this.final.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 21);
            this.button4.TabIndex = 34;
            this.button4.Text = "Get IP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEncryptNoise
            // 
            this.btnEncryptNoise.Location = new System.Drawing.Point(395, 248);
            this.btnEncryptNoise.Name = "btnEncryptNoise";
            this.btnEncryptNoise.Size = new System.Drawing.Size(89, 23);
            this.btnEncryptNoise.TabIndex = 35;
            this.btnEncryptNoise.Text = "Encrypt+Ký Tự";
            this.btnEncryptNoise.UseVisualStyleBackColor = true;
            this.btnEncryptNoise.Click += new System.EventHandler(this.btnEncryptNoise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 327);
            this.Controls.Add(this.btnEncryptNoise);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.final);
            this.Controls.Add(this.txtPad);
            this.Controls.Add(this.keyPad);
            this.Controls.Add(this.DecryptPad);
            this.Controls.Add(this.EncrytPad);
            this.Controls.Add(this.txtDPAD);
            this.Controls.Add(this.txtEPAD);
            this.Controls.Add(this.txtPubB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtPubA);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.decry);
            this.Controls.Add(this.genKey);
            this.Controls.Add(this.txtdecry);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.txtencry);
            this.Controls.Add(this.rncry);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.txtNhan);
            this.Controls.Add(this.txtRemote);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Client 01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtRemote;
        private System.Windows.Forms.TextBox txtNhan;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button rncry;
        private System.Windows.Forms.TextBox txtencry;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.TextBox txtdecry;
        private System.Windows.Forms.Button genKey;
        private System.Windows.Forms.Button decry;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.TextBox txtPubA;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPubB;
        private System.Windows.Forms.TextBox txtEPAD;
        private System.Windows.Forms.TextBox txtDPAD;
        private System.Windows.Forms.Button EncrytPad;
        private System.Windows.Forms.Button DecryptPad;
        private System.Windows.Forms.TextBox keyPad;
        private System.Windows.Forms.TextBox txtPad;
        private System.Windows.Forms.TextBox final;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEncryptNoise;
    }
}

