namespace Apartman
{
    partial class yoneticigiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yoneticigiris));
            this.circularbut1 = new Apartman.circularbut();
            this.siftextBox = new System.Windows.Forms.TextBox();
            this.idmasked = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yonidlab = new System.Windows.Forms.Label();
            this.yardyon = new Apartman.circularbut();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // circularbut1
            // 
            this.circularbut1.BackColor = System.Drawing.Color.White;
            this.circularbut1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circularbut1.ForeColor = System.Drawing.Color.Red;
            this.circularbut1.Location = new System.Drawing.Point(776, 12);
            this.circularbut1.Name = "circularbut1";
            this.circularbut1.Size = new System.Drawing.Size(45, 35);
            this.circularbut1.TabIndex = 17;
            this.circularbut1.Text = "X";
            this.circularbut1.UseVisualStyleBackColor = false;
            this.circularbut1.Click += new System.EventHandler(this.circularbut1_Click);
            // 
            // siftextBox
            // 
            this.siftextBox.Location = new System.Drawing.Point(312, 65);
            this.siftextBox.Name = "siftextBox";
            this.siftextBox.PasswordChar = '*';
            this.siftextBox.Size = new System.Drawing.Size(125, 27);
            this.siftextBox.TabIndex = 21;
            // 
            // idmasked
            // 
            this.idmasked.Location = new System.Drawing.Point(39, 66);
            this.idmasked.Mask = "00";
            this.idmasked.Name = "idmasked";
            this.idmasked.Size = new System.Drawing.Size(125, 27);
            this.idmasked.TabIndex = 20;
            this.idmasked.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idmasked_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(312, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "ŞİFRE :";
            // 
            // yonidlab
            // 
            this.yonidlab.AutoSize = true;
            this.yonidlab.BackColor = System.Drawing.Color.Transparent;
            this.yonidlab.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yonidlab.Location = new System.Drawing.Point(39, 19);
            this.yonidlab.Name = "yonidlab";
            this.yonidlab.Size = new System.Drawing.Size(171, 56);
            this.yonidlab.TabIndex = 18;
            this.yonidlab.Text = "YÖNETİCİ ID:\r\n\r\n";
            // 
            // yardyon
            // 
            this.yardyon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.yardyon.FlatAppearance.BorderSize = 0;
            this.yardyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yardyon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yardyon.Location = new System.Drawing.Point(578, 71);
            this.yardyon.Name = "yardyon";
            this.yardyon.Size = new System.Drawing.Size(82, 79);
            this.yardyon.TabIndex = 22;
            this.yardyon.Text = "YARDIM";
            this.yardyon.UseVisualStyleBackColor = false;
            this.yardyon.Click += new System.EventHandler(this.yardyon_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(565, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "GİRİŞ YAP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(696, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 39);
            this.button2.TabIndex = 24;
            this.button2.Text = "GERİ DÖN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // yoneticigiris
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 511);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yardyon);
            this.Controls.Add(this.siftextBox);
            this.Controls.Add(this.idmasked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yonidlab);
            this.Controls.Add(this.circularbut1);
            this.Name = "yoneticigiris";
            this.Text = "yoneticigiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private circularbut circularbut1;
        private TextBox siftextBox;
        private MaskedTextBox idmasked;
        private Label label2;
        private Label yonidlab;
        private circularbut yardyon;
        private Button button1;
        private Button button2;
    }
}