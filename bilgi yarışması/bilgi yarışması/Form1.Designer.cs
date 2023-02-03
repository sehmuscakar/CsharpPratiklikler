
namespace bilgi_yarışması
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BTNA = new System.Windows.Forms.Button();
            this.BTNB = new System.Windows.Forms.Button();
            this.BTNC = new System.Windows.Forms.Button();
            this.BTND = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBLSORUNO = new System.Windows.Forms.Label();
            this.LBLDOĞRU = new System.Windows.Forms.Label();
            this.LBLYANLIŞ = new System.Windows.Forms.Label();
            this.BTNSONRAKİ = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 24);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(417, 203);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BTNA
            // 
            this.BTNA.Location = new System.Drawing.Point(13, 235);
            this.BTNA.Name = "BTNA";
            this.BTNA.Size = new System.Drawing.Size(88, 43);
            this.BTNA.TabIndex = 1;
            this.BTNA.Text = "A";
            this.BTNA.UseVisualStyleBackColor = true;
            this.BTNA.Click += new System.EventHandler(this.BTNA_Click);
            // 
            // BTNB
            // 
            this.BTNB.Location = new System.Drawing.Point(147, 235);
            this.BTNB.Name = "BTNB";
            this.BTNB.Size = new System.Drawing.Size(88, 43);
            this.BTNB.TabIndex = 2;
            this.BTNB.Text = "B";
            this.BTNB.UseVisualStyleBackColor = true;
            this.BTNB.Click += new System.EventHandler(this.BTNB_Click);
            // 
            // BTNC
            // 
            this.BTNC.Location = new System.Drawing.Point(13, 298);
            this.BTNC.Name = "BTNC";
            this.BTNC.Size = new System.Drawing.Size(88, 43);
            this.BTNC.TabIndex = 3;
            this.BTNC.Text = "C";
            this.BTNC.UseVisualStyleBackColor = true;
            this.BTNC.Click += new System.EventHandler(this.BTNC_Click);
            // 
            // BTND
            // 
            this.BTND.Location = new System.Drawing.Point(147, 298);
            this.BTND.Name = "BTND";
            this.BTND.Size = new System.Drawing.Size(88, 43);
            this.BTND.TabIndex = 4;
            this.BTND.Text = "D";
            this.BTND.UseVisualStyleBackColor = true;
            this.BTND.Click += new System.EventHandler(this.BTND_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "soru no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "doğru";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "yanlış";
            // 
            // LBLSORUNO
            // 
            this.LBLSORUNO.AutoSize = true;
            this.LBLSORUNO.Location = new System.Drawing.Point(568, 51);
            this.LBLSORUNO.Name = "LBLSORUNO";
            this.LBLSORUNO.Size = new System.Drawing.Size(23, 25);
            this.LBLSORUNO.TabIndex = 8;
            this.LBLSORUNO.Text = "0";
            // 
            // LBLDOĞRU
            // 
            this.LBLDOĞRU.AutoSize = true;
            this.LBLDOĞRU.Location = new System.Drawing.Point(568, 92);
            this.LBLDOĞRU.Name = "LBLDOĞRU";
            this.LBLDOĞRU.Size = new System.Drawing.Size(23, 25);
            this.LBLDOĞRU.TabIndex = 10;
            this.LBLDOĞRU.Text = "0";
            // 
            // LBLYANLIŞ
            // 
            this.LBLYANLIŞ.AutoSize = true;
            this.LBLYANLIŞ.Location = new System.Drawing.Point(568, 132);
            this.LBLYANLIŞ.Name = "LBLYANLIŞ";
            this.LBLYANLIŞ.Size = new System.Drawing.Size(23, 25);
            this.LBLYANLIŞ.TabIndex = 11;
            this.LBLYANLIŞ.Text = "0";
            // 
            // BTNSONRAKİ
            // 
            this.BTNSONRAKİ.Location = new System.Drawing.Point(460, 166);
            this.BTNSONRAKİ.Name = "BTNSONRAKİ";
            this.BTNSONRAKİ.Size = new System.Drawing.Size(175, 61);
            this.BTNSONRAKİ.TabIndex = 12;
            this.BTNSONRAKİ.Text = "SONRAKİ SORU";
            this.BTNSONRAKİ.UseVisualStyleBackColor = true;
            this.BTNSONRAKİ.Click += new System.EventHandler(this.BTNSONRAKİ_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTNSONRAKİ);
            this.Controls.Add(this.LBLYANLIŞ);
            this.Controls.Add(this.LBLDOĞRU);
            this.Controls.Add(this.LBLSORUNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTND);
            this.Controls.Add(this.BTNC);
            this.Controls.Add(this.BTNB);
            this.Controls.Add(this.BTNA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BTNA;
        private System.Windows.Forms.Button BTNB;
        private System.Windows.Forms.Button BTNC;
        private System.Windows.Forms.Button BTND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBLSORUNO;
        private System.Windows.Forms.Label LBLDOĞRU;
        private System.Windows.Forms.Label LBLYANLIŞ;
        private System.Windows.Forms.Button BTNSONRAKİ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

