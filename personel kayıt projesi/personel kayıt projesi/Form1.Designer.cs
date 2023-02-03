
namespace personel_kayıt_projesi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskmaaş = new System.Windows.Forms.MaskedTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbşehir = new System.Windows.Forms.ComboBox();
            this.mskmeslek = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btngrafikler = new System.Windows.Forms.Button();
            this.btngüncele = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.personelVeriTabaniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new personel_kayıt_projesi.PersonelVeriTabaniDataSet();
            this.personelkayıtprojesiDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_kayıt_projesiDataSet2 = new personel_kayıt_projesi.personel_kayıt_projesiDataSet2();
            this.personel_kayıt_projesiDataSet1 = new personel_kayıt_projesi.personel_kayıt_projesiDataSet1();
            this.personelkayıtprojesiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelkayıtprojesiDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_kayıt_projesiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_kayıt_projesiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelkayıtprojesiDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mskmaaş);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbşehir);
            this.groupBox1.Controls.Add(this.mskmeslek);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 268);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "personel kayıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "maaş";
            // 
            // mskmaaş
            // 
            this.mskmaaş.Location = new System.Drawing.Point(107, 147);
            this.mskmaaş.Mask = "0000";
            this.mskmaaş.Name = "mskmaaş";
            this.mskmaaş.Size = new System.Drawing.Size(100, 22);
            this.mskmaaş.TabIndex = 5;
            this.mskmaaş.ValidatingType = typeof(int);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(149, 175);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "durum";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(93, 173);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "meslek";
            // 
            // cmbşehir
            // 
            this.cmbşehir.FormattingEnabled = true;
            this.cmbşehir.Location = new System.Drawing.Point(93, 117);
            this.cmbşehir.Name = "cmbşehir";
            this.cmbşehir.Size = new System.Drawing.Size(121, 24);
            this.cmbşehir.TabIndex = 4;
            // 
            // mskmeslek
            // 
            this.mskmeslek.Location = new System.Drawing.Point(107, 202);
            this.mskmeslek.Name = "mskmeslek";
            this.mskmeslek.Size = new System.Drawing.Size(100, 22);
            this.mskmeslek.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "şehir";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(107, 89);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(107, 22);
            this.txtsoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "soyad";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(107, 63);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(107, 22);
            this.txtad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "personel ad";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(107, 45);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(107, 22);
            this.txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "personel id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnistatistik);
            this.groupBox2.Controls.Add(this.btntemizle);
            this.groupBox2.Controls.Add(this.btngrafikler);
            this.groupBox2.Controls.Add(this.btngüncele);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(498, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "işlemler";
            // 
            // btnistatistik
            // 
            this.btnistatistik.Location = new System.Drawing.Point(31, 235);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(145, 33);
            this.btnistatistik.TabIndex = 8;
            this.btnistatistik.Text = "İstatistik ";
            this.btnistatistik.UseVisualStyleBackColor = true;
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(31, 196);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(145, 33);
            this.btntemizle.TabIndex = 7;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            // 
            // btngrafikler
            // 
            this.btngrafikler.Location = new System.Drawing.Point(31, 267);
            this.btngrafikler.Name = "btngrafikler";
            this.btngrafikler.Size = new System.Drawing.Size(145, 42);
            this.btngrafikler.TabIndex = 6;
            this.btngrafikler.Text = "grafikler";
            this.btngrafikler.UseVisualStyleBackColor = true;
            // 
            // btngüncele
            // 
            this.btngüncele.Location = new System.Drawing.Point(31, 157);
            this.btngüncele.Name = "btngüncele";
            this.btngüncele.Size = new System.Drawing.Size(145, 33);
            this.btngüncele.TabIndex = 5;
            this.btngüncele.Text = "güncele";
            this.btngüncele.UseVisualStyleBackColor = true;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(31, 117);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(145, 36);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = true;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(31, 73);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(145, 38);
            this.btnkaydet.TabIndex = 3;
            this.btnkaydet.Text = "kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(31, 21);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(145, 46);
            this.btnlistele.TabIndex = 2;
            this.btnlistele.Text = "listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            // 
            // personelVeriTabaniDataSetBindingSource
            // 
            this.personelVeriTabaniDataSetBindingSource.DataSource = this.personelVeriTabaniDataSet;
            this.personelVeriTabaniDataSetBindingSource.Position = 0;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelkayıtprojesiDataSet2BindingSource
            // 
            this.personelkayıtprojesiDataSet2BindingSource.DataSource = this.personel_kayıt_projesiDataSet2;
            this.personelkayıtprojesiDataSet2BindingSource.Position = 0;
            // 
            // personel_kayıt_projesiDataSet2
            // 
            this.personel_kayıt_projesiDataSet2.DataSetName = "personel_kayıt_projesiDataSet2";
            this.personel_kayıt_projesiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personel_kayıt_projesiDataSet1
            // 
            this.personel_kayıt_projesiDataSet1.DataSetName = "personel_kayıt_projesiDataSet1";
            this.personel_kayıt_projesiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelkayıtprojesiDataSet1BindingSource
            // 
            this.personelkayıtprojesiDataSet1BindingSource.DataSource = this.personel_kayıt_projesiDataSet1;
            this.personelkayıtprojesiDataSet1BindingSource.Position = 0;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 396);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1183, 140);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1345, 548);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelkayıtprojesiDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_kayıt_projesiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_kayıt_projesiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelkayıtprojesiDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbşehir;
        private System.Windows.Forms.MaskedTextBox mskmeslek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngrafikler;
        private System.Windows.Forms.Button btngüncele;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskmaaş;
        private System.Windows.Forms.BindingSource personelkayıtprojesiDataSet1BindingSource;
        private personel_kayıt_projesiDataSet1 personel_kayıt_projesiDataSet1;
        private System.Windows.Forms.BindingSource personelkayıtprojesiDataSet2BindingSource;
        private personel_kayıt_projesiDataSet2 personel_kayıt_projesiDataSet2;
        private System.Windows.Forms.Button btnistatistik;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.BindingSource personelVeriTabaniDataSetBindingSource;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.ListView listView1;
    }
}

