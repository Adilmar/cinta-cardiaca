namespace interfaceArduinoVS2013
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
            this.btConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.textBoxEnviar = new System.Windows.Forms.TextBox();
            this.textBoxReceber = new System.Windows.Forms.TextBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.testGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.balao4 = new System.Windows.Forms.PictureBox();
            this.balao1 = new System.Windows.Forms.PictureBox();
            this.balao3 = new System.Windows.Forms.PictureBox();
            this.balao2 = new System.Windows.Forms.PictureBox();
            this.balao5 = new System.Windows.Forms.PictureBox();
            this.balao6 = new System.Windows.Forms.PictureBox();
            this.balao7 = new System.Windows.Forms.PictureBox();
            this.balao8 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.testGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(15, 47);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(81, 23);
            this.btConectar.TabIndex = 0;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(15, 85);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(81, 23);
            this.btEnviar.TabIndex = 2;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // textBoxEnviar
            // 
            this.textBoxEnviar.Location = new System.Drawing.Point(108, 87);
            this.textBoxEnviar.Name = "textBoxEnviar";
            this.textBoxEnviar.Size = new System.Drawing.Size(132, 20);
            this.textBoxEnviar.TabIndex = 3;
            // 
            // textBoxReceber
            // 
            this.textBoxReceber.Location = new System.Drawing.Point(9, 13);
            this.textBoxReceber.Multiline = true;
            this.textBoxReceber.Name = "textBoxReceber";
            this.textBoxReceber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceber.Size = new System.Drawing.Size(217, 45);
            this.textBoxReceber.TabIndex = 4;
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.testGroup);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxEnviar);
            this.panel1.Controls.Add(this.btConectar);
            this.panel1.Controls.Add(this.btEnviar);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 204);
            this.panel1.TabIndex = 5;
            // 
            // testGroup
            // 
            this.testGroup.Controls.Add(this.textBoxReceber);
            this.testGroup.Enabled = false;
            this.testGroup.Location = new System.Drawing.Point(15, 125);
            this.testGroup.Name = "testGroup";
            this.testGroup.Size = new System.Drawing.Size(232, 64);
            this.testGroup.TabIndex = 1;
            this.testGroup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conexão com Arduino";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(292, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 204);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::interfaceArduinoVS2013.Properties.Resources.trofeu;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(752, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 34);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(559, 62);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fisioterapia Respiratória";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::interfaceArduinoVS2013.Properties.Resources.respiration;
            this.pictureBox5.Location = new System.Drawing.Point(19, 26);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(172, 163);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::interfaceArduinoVS2013.Properties.Resources.save;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(715, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 34);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.ForeColor = System.Drawing.Color.Maroon;
            this.progressBar1.Location = new System.Drawing.Point(12, 593);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1287, 47);
            this.progressBar1.TabIndex = 8;
            // 
            // balao4
            // 
            this.balao4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balao4.BackColor = System.Drawing.Color.Transparent;
            this.balao4.BackgroundImage = global::interfaceArduinoVS2013.Properties.Resources.balonn;
            this.balao4.Location = new System.Drawing.Point(529, 392);
            this.balao4.Name = "balao4";
            this.balao4.Size = new System.Drawing.Size(150, 195);
            this.balao4.TabIndex = 12;
            this.balao4.TabStop = false;
            // 
            // balao1
            // 
            this.balao1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balao1.BackColor = System.Drawing.Color.Transparent;
            this.balao1.BackgroundImage = global::interfaceArduinoVS2013.Properties.Resources.balonn;
            this.balao1.Location = new System.Drawing.Point(12, 392);
            this.balao1.Name = "balao1";
            this.balao1.Size = new System.Drawing.Size(150, 195);
            this.balao1.TabIndex = 11;
            this.balao1.TabStop = false;
            // 
            // balao3
            // 
            this.balao3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balao3.BackColor = System.Drawing.Color.Transparent;
            this.balao3.BackgroundImage = global::interfaceArduinoVS2013.Properties.Resources.balonn;
            this.balao3.Location = new System.Drawing.Point(357, 392);
            this.balao3.Name = "balao3";
            this.balao3.Size = new System.Drawing.Size(150, 195);
            this.balao3.TabIndex = 10;
            this.balao3.TabStop = false;
            // 
            // balao2
            // 
            this.balao2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balao2.BackColor = System.Drawing.Color.Transparent;
            this.balao2.BackgroundImage = global::interfaceArduinoVS2013.Properties.Resources.balonn;
            this.balao2.Location = new System.Drawing.Point(175, 392);
            this.balao2.Name = "balao2";
            this.balao2.Size = new System.Drawing.Size(150, 195);
            this.balao2.TabIndex = 9;
            this.balao2.TabStop = false;
            // 
            // balao5
            // 
            this.balao5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balao5.BackColor = System.Drawing.Color.Transparent;
            this.balao5.BackgroundImage = global::interfaceArduinoVS2013.Properties.Resources.balonn;
            this.balao5.Location = new System.Drawing.Point(695, 392);
            this.balao5.Name = "balao5";
            this.balao5.Size = new System.Drawing.Size(150, 195);
            this.balao5.TabIndex = 13;
            this.balao5.TabStop = false;
            // 
            // balao6
            // 
            this.balao6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balao6.BackColor = System.Drawing.Color.Transparent;
            this.balao6.BackgroundImage = global::interfaceArduinoVS2013.Properties.Resources.balonn;
            this.balao6.Location = new System.Drawing.Point(857, 392);
            this.balao6.Name = "balao6";
            this.balao6.Size = new System.Drawing.Size(150, 195);
            this.balao6.TabIndex = 14;
            this.balao6.TabStop = false;
            // 
            // balao7
            // 
            this.balao7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balao7.BackColor = System.Drawing.Color.Transparent;
            this.balao7.BackgroundImage = global::interfaceArduinoVS2013.Properties.Resources.balonn;
            this.balao7.Location = new System.Drawing.Point(1018, 392);
            this.balao7.Name = "balao7";
            this.balao7.Size = new System.Drawing.Size(150, 195);
            this.balao7.TabIndex = 15;
            this.balao7.TabStop = false;
            // 
            // balao8
            // 
            this.balao8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balao8.BackColor = System.Drawing.Color.Transparent;
            this.balao8.BackgroundImage = global::interfaceArduinoVS2013.Properties.Resources.balonn;
            this.balao8.Location = new System.Drawing.Point(1175, 392);
            this.balao8.Name = "balao8";
            this.balao8.Size = new System.Drawing.Size(150, 195);
            this.balao8.TabIndex = 16;
            this.balao8.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1115, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "....";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::interfaceArduinoVS2013.Properties.Resources.pulmao;
            this.pictureBox7.Location = new System.Drawing.Point(1118, 19);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(151, 153);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::interfaceArduinoVS2013.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 652);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.balao8);
            this.Controls.Add(this.balao7);
            this.Controls.Add(this.balao6);
            this.Controls.Add(this.balao5);
            this.Controls.Add(this.balao4);
            this.Controls.Add(this.balao1);
            this.Controls.Add(this.balao3);
            this.Controls.Add(this.balao2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.testGroup.ResumeLayout(false);
            this.testGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balao8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.TextBox textBoxEnviar;
        private System.Windows.Forms.TextBox textBoxReceber;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox testGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox balao4;
        private System.Windows.Forms.PictureBox balao1;
        private System.Windows.Forms.PictureBox balao3;
        private System.Windows.Forms.PictureBox balao2;
        private System.Windows.Forms.PictureBox balao5;
        private System.Windows.Forms.PictureBox balao6;
        private System.Windows.Forms.PictureBox balao7;
        private System.Windows.Forms.PictureBox balao8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button1;

    }
}

