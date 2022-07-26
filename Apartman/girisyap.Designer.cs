namespace Apartman
{
    partial class girisyap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisyap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namemasked = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.siftextBox = new System.Windows.Forms.TextBox();
            this.circularbut1 = new Apartman.circularbut();
            this.circularbut2 = new Apartman.circularbut();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "KİMLİK NO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE :";
            // 
            // namemasked
            // 
            this.namemasked.Location = new System.Drawing.Point(51, 125);
            this.namemasked.Mask = "00000000000";
            this.namemasked.Name = "namemasked";
            this.namemasked.Size = new System.Drawing.Size(125, 27);
            this.namemasked.TabIndex = 4;
            this.namemasked.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.namemasked_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(548, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "GİRİŞ YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(583, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "GERİ DÖN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // siftextBox
            // 
            this.siftextBox.Location = new System.Drawing.Point(51, 249);
            this.siftextBox.Name = "siftextBox";
            this.siftextBox.PasswordChar = '*';
            this.siftextBox.Size = new System.Drawing.Size(125, 27);
            this.siftextBox.TabIndex = 7;
            // 
            // circularbut1
            // 
            this.circularbut1.FlatAppearance.BorderSize = 0;
            this.circularbut1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularbut1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circularbut1.Location = new System.Drawing.Point(658, 125);
            this.circularbut1.Name = "circularbut1";
            this.circularbut1.Size = new System.Drawing.Size(108, 94);
            this.circularbut1.TabIndex = 8;
            this.circularbut1.Text = "YARDIM";
            this.circularbut1.UseVisualStyleBackColor = true;
            this.circularbut1.Click += new System.EventHandler(this.circularbut1_Click);
            // 
            // circularbut2
            // 
            this.circularbut2.BackColor = System.Drawing.Color.White;
            this.circularbut2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circularbut2.ForeColor = System.Drawing.Color.Red;
            this.circularbut2.Location = new System.Drawing.Point(752, 1);
            this.circularbut2.Name = "circularbut2";
            this.circularbut2.Size = new System.Drawing.Size(45, 35);
            this.circularbut2.TabIndex = 17;
            this.circularbut2.Text = "X";
            this.circularbut2.UseVisualStyleBackColor = false;
            this.circularbut2.Click += new System.EventHandler(this.circularbut2_Click);
            // 
            // girisyap
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.circularbut2);
            this.Controls.Add(this.circularbut1);
            this.Controls.Add(this.siftextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.namemasked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "girisyap";
            this.Text = "girisyap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox namemasked;
        private Button button1;
        private Button button2;
        private TextBox siftextBox;
        private circularbut circularbut1;
        private circularbut circularbut2;
    }
}