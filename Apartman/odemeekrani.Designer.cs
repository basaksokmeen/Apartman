namespace Apartman
{
    partial class odemeekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odemeekrani));
            this.odemeyap = new System.Windows.Forms.Button();
            this.cvc = new System.Windows.Forms.MaskedTextBox();
            this.sonkul = new System.Windows.Forms.MaskedTextBox();
            this.kartnum = new System.Windows.Forms.MaskedTextBox();
            this.kartis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.circularbut1 = new Apartman.circularbut();
            this.SuspendLayout();
            // 
            // odemeyap
            // 
            this.odemeyap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.odemeyap.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.odemeyap.ForeColor = System.Drawing.SystemColors.Desktop;
            this.odemeyap.Location = new System.Drawing.Point(250, 439);
            this.odemeyap.Name = "odemeyap";
            this.odemeyap.Size = new System.Drawing.Size(197, 50);
            this.odemeyap.TabIndex = 19;
            this.odemeyap.Text = "ÖDEME YAP";
            this.odemeyap.UseVisualStyleBackColor = false;
            this.odemeyap.Click += new System.EventHandler(this.odemeyap_Click);
            // 
            // cvc
            // 
            this.cvc.Location = new System.Drawing.Point(432, 349);
            this.cvc.Mask = "000";
            this.cvc.Name = "cvc";
            this.cvc.Size = new System.Drawing.Size(125, 27);
            this.cvc.TabIndex = 18;
            // 
            // sonkul
            // 
            this.sonkul.Location = new System.Drawing.Point(432, 289);
            this.sonkul.Mask = "00/00";
            this.sonkul.Name = "sonkul";
            this.sonkul.Size = new System.Drawing.Size(125, 27);
            this.sonkul.TabIndex = 17;
            this.sonkul.ValidatingType = typeof(System.DateTime);
            // 
            // kartnum
            // 
            this.kartnum.Location = new System.Drawing.Point(432, 227);
            this.kartnum.Mask = "0000 0000 0000 0000";
            this.kartnum.Name = "kartnum";
            this.kartnum.Size = new System.Drawing.Size(125, 27);
            this.kartnum.TabIndex = 16;
            // 
            // kartis
            // 
            this.kartis.Location = new System.Drawing.Point(432, 162);
            this.kartis.Name = "kartis";
            this.kartis.Size = new System.Drawing.Size(125, 27);
            this.kartis.TabIndex = 15;
            this.kartis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kartis_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(106, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "CVC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(106, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "SON KULLANIM TARİHİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(106, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "KART NUMARASI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(106, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "KARTIN ÜZERİNDEKİ İSİM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(106, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "ÖDEME EKRANI";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(273, 502);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 46);
            this.button4.TabIndex = 23;
            this.button4.Text = "GERİ DÖN";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // circularbut1
            // 
            this.circularbut1.BackColor = System.Drawing.Color.White;
            this.circularbut1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circularbut1.ForeColor = System.Drawing.Color.Red;
            this.circularbut1.Location = new System.Drawing.Point(641, 12);
            this.circularbut1.Name = "circularbut1";
            this.circularbut1.Size = new System.Drawing.Size(45, 35);
            this.circularbut1.TabIndex = 24;
            this.circularbut1.Text = "X";
            this.circularbut1.UseVisualStyleBackColor = false;
            this.circularbut1.Click += new System.EventHandler(this.circularbut1_Click);
            // 
            // odemeekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(698, 560);
            this.Controls.Add(this.circularbut1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.odemeyap);
            this.Controls.Add(this.cvc);
            this.Controls.Add(this.sonkul);
            this.Controls.Add(this.kartnum);
            this.Controls.Add(this.kartis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "odemeekrani";
            this.Text = "odemeekrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button odemeyap;
        private MaskedTextBox cvc;
        private MaskedTextBox sonkul;
        private MaskedTextBox kartnum;
        private TextBox kartis;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button4;
        private circularbut circularbut1;
    }
}