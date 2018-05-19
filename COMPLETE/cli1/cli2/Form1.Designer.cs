namespace cli2
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtNhan = new System.Windows.Forms.TextBox();
            this.txtRemote = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.decry = new System.Windows.Forms.Button();
            this.genKey = new System.Windows.Forms.Button();
            this.txtdecry = new System.Windows.Forms.TextBox();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.txtencry = new System.Windows.Forms.TextBox();
            this.rncry = new System.Windows.Forms.Button();
            this.txtPri = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EncrytPad = new System.Windows.Forms.Button();
            this.DecryptPad = new System.Windows.Forms.Button();
            this.keyPad = new System.Windows.Forms.TextBox();
            this.txtPad = new System.Windows.Forms.TextBox();
            this.final = new System.Windows.Forms.TextBox();
            this.txtEPAD = new System.Windows.Forms.TextBox();
            this.txtDPAD = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEncryptNoise = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtSession = new System.Windows.Forms.TextBox();
            this.lbltimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(12, 277);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(483, 20);
            this.txtNhap.TabIndex = 13;
            // 
            // txtNhan
            // 
            this.txtNhan.Location = new System.Drawing.Point(12, 117);
            this.txtNhan.Multiline = true;
            this.txtNhan.Name = "txtNhan";
            this.txtNhan.Size = new System.Drawing.Size(534, 154);
            this.txtNhan.TabIndex = 12;
            // 
            // txtRemote
            // 
            this.txtRemote.Location = new System.Drawing.Point(12, 79);
            this.txtRemote.Name = "txtRemote";
            this.txtRemote.Size = new System.Drawing.Size(34, 20);
            this.txtRemote.TabIndex = 11;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(12, 50);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(34, 20);
            this.txtLocal.TabIndex = 10;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(12, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(120, 20);
            this.txtIP.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Gửi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kết Nối";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // decry
            // 
            this.decry.Location = new System.Drawing.Point(26, 531);
            this.decry.Name = "decry";
            this.decry.Size = new System.Drawing.Size(75, 23);
            this.decry.TabIndex = 19;
            this.decry.Text = "decry";
            this.decry.UseVisualStyleBackColor = true;
            this.decry.Click += new System.EventHandler(this.decry_Click);
            // 
            // genKey
            // 
            this.genKey.Location = new System.Drawing.Point(259, 62);
            this.genKey.Name = "genKey";
            this.genKey.Size = new System.Drawing.Size(75, 23);
            this.genKey.TabIndex = 18;
            this.genKey.Text = "genKey";
            this.genKey.UseVisualStyleBackColor = true;
            this.genKey.Click += new System.EventHandler(this.genKey_Click);
            // 
            // txtdecry
            // 
            this.txtdecry.Location = new System.Drawing.Point(11, 571);
            this.txtdecry.Name = "txtdecry";
            this.txtdecry.Size = new System.Drawing.Size(263, 20);
            this.txtdecry.TabIndex = 17;
            this.txtdecry.TextChanged += new System.EventHandler(this.txtdecry_TextChanged);
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(10, 398);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(287, 20);
            this.txtkey.TabIndex = 16;
            this.txtkey.Visible = false;
            this.txtkey.TextChanged += new System.EventHandler(this.txtkey_TextChanged);
            // 
            // txtencry
            // 
            this.txtencry.Location = new System.Drawing.Point(10, 505);
            this.txtencry.Name = "txtencry";
            this.txtencry.Size = new System.Drawing.Size(264, 20);
            this.txtencry.TabIndex = 15;
            this.txtencry.TextChanged += new System.EventHandler(this.txtencry_TextChanged);
            // 
            // rncry
            // 
            this.rncry.Location = new System.Drawing.Point(12, 476);
            this.rncry.Name = "rncry";
            this.rncry.Size = new System.Drawing.Size(75, 23);
            this.rncry.TabIndex = 14;
            this.rncry.Text = "encry";
            this.rncry.UseVisualStyleBackColor = true;
            this.rncry.Click += new System.EventHandler(this.rncry_Click);
            // 
            // txtPri
            // 
            this.txtPri.Location = new System.Drawing.Point(259, 91);
            this.txtPri.Name = "txtPri";
            this.txtPri.Size = new System.Drawing.Size(263, 20);
            this.txtPri.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(696, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 450);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.Visible = false;
            // 
            // EncrytPad
            // 
            this.EncrytPad.Location = new System.Drawing.Point(570, 117);
            this.EncrytPad.Name = "EncrytPad";
            this.EncrytPad.Size = new System.Drawing.Size(75, 23);
            this.EncrytPad.TabIndex = 24;
            this.EncrytPad.Text = "Encryt";
            this.EncrytPad.UseVisualStyleBackColor = true;
            this.EncrytPad.Click += new System.EventHandler(this.EncrytPad_Click);
            // 
            // DecryptPad
            // 
            this.DecryptPad.Location = new System.Drawing.Point(570, 211);
            this.DecryptPad.Name = "DecryptPad";
            this.DecryptPad.Size = new System.Drawing.Size(75, 23);
            this.DecryptPad.TabIndex = 25;
            this.DecryptPad.Text = "Decrypt";
            this.DecryptPad.UseVisualStyleBackColor = true;
            this.DecryptPad.Click += new System.EventHandler(this.DecryptPad_Click);
            // 
            // keyPad
            // 
            this.keyPad.Location = new System.Drawing.Point(545, 492);
            this.keyPad.Name = "keyPad";
            this.keyPad.Size = new System.Drawing.Size(168, 20);
            this.keyPad.TabIndex = 26;
            this.keyPad.Visible = false;
            // 
            // txtPad
            // 
            this.txtPad.Location = new System.Drawing.Point(532, 518);
            this.txtPad.Name = "txtPad";
            this.txtPad.Size = new System.Drawing.Size(168, 20);
            this.txtPad.TabIndex = 27;
            this.txtPad.Visible = false;
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(532, 556);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(168, 20);
            this.final.TabIndex = 28;
            this.final.Visible = false;
            // 
            // txtEPAD
            // 
            this.txtEPAD.Location = new System.Drawing.Point(570, 168);
            this.txtEPAD.Name = "txtEPAD";
            this.txtEPAD.Size = new System.Drawing.Size(225, 20);
            this.txtEPAD.TabIndex = 29;
            this.txtEPAD.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtDPAD
            // 
            this.txtDPAD.Location = new System.Drawing.Point(570, 240);
            this.txtDPAD.Name = "txtDPAD";
            this.txtDPAD.Size = new System.Drawing.Size(225, 20);
            this.txtDPAD.TabIndex = 30;
            this.txtDPAD.TextChanged += new System.EventHandler(this.txtDPAD_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(57, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Get IP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnEncryptNoise
            // 
            this.btnEncryptNoise.Location = new System.Drawing.Point(696, 117);
            this.btnEncryptNoise.Name = "btnEncryptNoise";
            this.btnEncryptNoise.Size = new System.Drawing.Size(75, 23);
            this.btnEncryptNoise.TabIndex = 37;
            this.btnEncryptNoise.Text = "Encrypt+Ký Tự";
            this.btnEncryptNoise.UseVisualStyleBackColor = true;
            this.btnEncryptNoise.Click += new System.EventHandler(this.btnEncryptNoise_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(516, 12);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(46, 20);
            this.txtSession.TabIndex = 38;
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Location = new System.Drawing.Point(360, 12);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(39, 13);
            this.lbltimer.TabIndex = 41;
            this.lbltimer.Text = "lbltimer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 313);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.btnEncryptNoise);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtDPAD);
            this.Controls.Add(this.txtEPAD);
            this.Controls.Add(this.final);
            this.Controls.Add(this.txtPad);
            this.Controls.Add(this.keyPad);
            this.Controls.Add(this.DecryptPad);
            this.Controls.Add(this.EncrytPad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtPri);
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
            this.Text = "Client 02";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtNhan;
        private System.Windows.Forms.TextBox txtRemote;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button decry;
        private System.Windows.Forms.Button genKey;
        private System.Windows.Forms.TextBox txtdecry;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.TextBox txtencry;
        private System.Windows.Forms.Button rncry;
        private System.Windows.Forms.TextBox txtPri;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button EncrytPad;
        private System.Windows.Forms.Button DecryptPad;
        private System.Windows.Forms.TextBox keyPad;
        private System.Windows.Forms.TextBox txtPad;
        private System.Windows.Forms.TextBox final;
        private System.Windows.Forms.TextBox txtEPAD;
        private System.Windows.Forms.TextBox txtDPAD;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEncryptNoise;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label lbltimer;
    }
}

