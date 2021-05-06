
namespace SykemittariV2
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
            this.labelSessionAVG = new System.Windows.Forms.Label();
            this.labelSessionMAX = new System.Windows.Forms.Label();
            this.labelBPM = new System.Windows.Forms.Label();
            this.buttonSession = new System.Windows.Forms.Button();
            this.checkBoxON_OFF = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSessionAVG
            // 
            this.labelSessionAVG.AutoSize = true;
            this.labelSessionAVG.BackColor = System.Drawing.Color.Transparent;
            this.labelSessionAVG.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionAVG.Location = new System.Drawing.Point(64, 56);
            this.labelSessionAVG.Name = "labelSessionAVG";
            this.labelSessionAVG.Size = new System.Drawing.Size(53, 48);
            this.labelSessionAVG.TabIndex = 0;
            this.labelSessionAVG.Text = "---";
            this.labelSessionAVG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSessionMAX
            // 
            this.labelSessionMAX.AutoSize = true;
            this.labelSessionMAX.BackColor = System.Drawing.Color.Transparent;
            this.labelSessionMAX.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionMAX.Location = new System.Drawing.Point(67, 56);
            this.labelSessionMAX.Name = "labelSessionMAX";
            this.labelSessionMAX.Size = new System.Drawing.Size(53, 48);
            this.labelSessionMAX.TabIndex = 1;
            this.labelSessionMAX.Text = "---";
            this.labelSessionMAX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBPM
            // 
            this.labelBPM.AutoSize = true;
            this.labelBPM.BackColor = System.Drawing.Color.Transparent;
            this.labelBPM.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBPM.Location = new System.Drawing.Point(68, 46);
            this.labelBPM.Name = "labelBPM";
            this.labelBPM.Size = new System.Drawing.Size(53, 48);
            this.labelBPM.TabIndex = 2;
            this.labelBPM.Text = "---";
            this.labelBPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSession
            // 
            this.buttonSession.BackColor = System.Drawing.Color.LightGray;
            this.buttonSession.Enabled = false;
            this.buttonSession.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSession.Location = new System.Drawing.Point(173, 409);
            this.buttonSession.Name = "buttonSession";
            this.buttonSession.Size = new System.Drawing.Size(85, 54);
            this.buttonSession.TabIndex = 3;
            this.buttonSession.Text = "Session Start!";
            this.buttonSession.UseVisualStyleBackColor = false;
            this.buttonSession.Click += new System.EventHandler(this.buttonSession_Click);
            // 
            // checkBoxON_OFF
            // 
            this.checkBoxON_OFF.AutoSize = true;
            this.checkBoxON_OFF.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxON_OFF.Location = new System.Drawing.Point(207, 389);
            this.checkBoxON_OFF.Name = "checkBoxON_OFF";
            this.checkBoxON_OFF.Size = new System.Drawing.Size(15, 14);
            this.checkBoxON_OFF.TabIndex = 4;
            this.checkBoxON_OFF.UseVisualStyleBackColor = false;
            this.checkBoxON_OFF.CheckedChanged += new System.EventHandler(this.checkBoxON_OFF_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(199, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "ON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "BPM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 44);
            this.label3.TabIndex = 7;
            this.label3.Text = "Session \r\nAVG BPM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 44);
            this.label4.TabIndex = 8;
            this.label4.Text = "Session \r\nMAX BPM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::SykemittariV2.Properties.Resources.heart;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.labelSessionAVG);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(37, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 131);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::SykemittariV2.Properties.Resources.heart;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelSessionMAX);
            this.panel2.Location = new System.Drawing.Point(219, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 131);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::SykemittariV2.Properties.Resources.heart;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.labelBPM);
            this.panel3.Location = new System.Drawing.Point(133, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 131);
            this.panel3.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelTime.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(152, 55);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(143, 38);
            this.labelTime.TabIndex = 15;
            this.labelTime.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::SykemittariV2.Properties.Resources.watch6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 495);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.checkBoxON_OFF);
            this.Controls.Add(this.buttonSession);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Sykemittari";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSessionAVG;
        private System.Windows.Forms.Label labelSessionMAX;
        private System.Windows.Forms.Label labelBPM;
        private System.Windows.Forms.Button buttonSession;
        private System.Windows.Forms.CheckBox checkBoxON_OFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
    }
}

