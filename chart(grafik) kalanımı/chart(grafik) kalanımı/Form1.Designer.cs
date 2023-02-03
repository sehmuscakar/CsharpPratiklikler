
namespace chart_grafik__kalanımı
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.kitap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.kitap)).BeginInit();
            this.SuspendLayout();
            // 
            // kitap
            // 
            chartArea1.Name = "ChartArea1";
            this.kitap.ChartAreas.Add(chartArea1);
            this.kitap.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.kitap.Legends.Add(legend1);
            this.kitap.Location = new System.Drawing.Point(0, 0);
            this.kitap.Name = "kitap";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "kitap";
            this.kitap.Series.Add(series1);
            this.kitap.Size = new System.Drawing.Size(800, 450);
            this.kitap.TabIndex = 0;
            this.kitap.Text = "chart1";
            this.kitap.Click += new System.EventHandler(this.kitap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kitap);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart kitap;
    }
}

