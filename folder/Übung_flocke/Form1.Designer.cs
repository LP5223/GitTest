namespace Übung_flocke
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rEin = new System.Windows.Forms.RadioButton();
            this.rAus = new System.Windows.Forms.RadioButton();
            this.picSchuss = new System.Windows.Forms.PictureBox();
            this.picFlocke = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.txtZahl = new System.Windows.Forms.TextBox();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.btnSchuss = new System.Windows.Forms.Button();
            this.picBoden = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSchuss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlocke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoden)).BeginInit();
            this.SuspendLayout();
            // 
            // rEin
            // 
            this.rEin.AutoSize = true;
            this.rEin.Location = new System.Drawing.Point(12, 12);
            this.rEin.Name = "rEin";
            this.rEin.Size = new System.Drawing.Size(47, 17);
            this.rEin.TabIndex = 0;
            this.rEin.TabStop = true;
            this.rEin.Text = "Start";
            this.rEin.UseVisualStyleBackColor = true;
            // 
            // rAus
            // 
            this.rAus.AutoSize = true;
            this.rAus.Location = new System.Drawing.Point(12, 35);
            this.rAus.Name = "rAus";
            this.rAus.Size = new System.Drawing.Size(55, 17);
            this.rAus.TabIndex = 1;
            this.rAus.TabStop = true;
            this.rAus.Text = "Pause";
            this.rAus.UseVisualStyleBackColor = true;
            // 
            // picSchuss
            // 
            this.picSchuss.BackColor = System.Drawing.Color.Goldenrod;
            this.picSchuss.Location = new System.Drawing.Point(12, 214);
            this.picSchuss.Name = "picSchuss";
            this.picSchuss.Size = new System.Drawing.Size(36, 36);
            this.picSchuss.TabIndex = 2;
            this.picSchuss.TabStop = false;
            // 
            // picFlocke
            // 
            this.picFlocke.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picFlocke.Location = new System.Drawing.Point(180, 12);
            this.picFlocke.Name = "picFlocke";
            this.picFlocke.Size = new System.Drawing.Size(78, 50);
            this.picFlocke.TabIndex = 3;
            this.picFlocke.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 68);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Location = new System.Drawing.Point(13, 188);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
            this.lblAusgabe.TabIndex = 5;
            this.lblAusgabe.Text = "label1";
            // 
            // txtZahl
            // 
            this.txtZahl.Location = new System.Drawing.Point(12, 154);
            this.txtZahl.Name = "txtZahl";
            this.txtZahl.Size = new System.Drawing.Size(100, 20);
            this.txtZahl.TabIndex = 6;
            this.txtZahl.Text = "Zahl eingeben";
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // btnSchuss
            // 
            this.btnSchuss.Location = new System.Drawing.Point(12, 113);
            this.btnSchuss.Name = "btnSchuss";
            this.btnSchuss.Size = new System.Drawing.Size(75, 23);
            this.btnSchuss.TabIndex = 7;
            this.btnSchuss.Text = "Schuss";
            this.btnSchuss.UseVisualStyleBackColor = true;
            this.btnSchuss.Click += new System.EventHandler(this.btnSchuss_Click);
            // 
            // picBoden
            // 
            this.picBoden.Location = new System.Drawing.Point(172, 254);
            this.picBoden.Name = "picBoden";
            this.picBoden.Size = new System.Drawing.Size(100, 10);
            this.picBoden.TabIndex = 8;
            this.picBoden.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.picBoden);
            this.Controls.Add(this.btnSchuss);
            this.Controls.Add(this.txtZahl);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picFlocke);
            this.Controls.Add(this.picSchuss);
            this.Controls.Add(this.rAus);
            this.Controls.Add(this.rEin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picSchuss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlocke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rEin;
        private System.Windows.Forms.RadioButton rAus;
        private System.Windows.Forms.PictureBox picSchuss;
        private System.Windows.Forms.PictureBox picFlocke;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.TextBox txtZahl;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Button btnSchuss;
        private System.Windows.Forms.PictureBox picBoden;
    }
}

