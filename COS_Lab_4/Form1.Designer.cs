
namespace COS_Lab_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbbxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStraightCorr = new System.Windows.Forms.TextBox();
            this.txtFastCorr = new System.Windows.Forms.TextBox();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.signalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.correlationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correlationChart)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbxType
            // 
            this.cbbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxType.FormattingEnabled = true;
            this.cbbxType.Location = new System.Drawing.Point(12, 25);
            this.cbbxType.Name = "cbbxType";
            this.cbbxType.Size = new System.Drawing.Size(173, 24);
            this.cbbxType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите вид корреляции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прямая корреляция";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Быстрая корреляция";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Процент";
            // 
            // txtStraightCorr
            // 
            this.txtStraightCorr.Location = new System.Drawing.Point(237, 25);
            this.txtStraightCorr.Name = "txtStraightCorr";
            this.txtStraightCorr.ReadOnly = true;
            this.txtStraightCorr.Size = new System.Drawing.Size(139, 22);
            this.txtStraightCorr.TabIndex = 5;
            // 
            // txtFastCorr
            // 
            this.txtFastCorr.Location = new System.Drawing.Point(425, 25);
            this.txtFastCorr.Name = "txtFastCorr";
            this.txtFastCorr.ReadOnly = true;
            this.txtFastCorr.Size = new System.Drawing.Size(139, 22);
            this.txtFastCorr.TabIndex = 6;
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(617, 24);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.ReadOnly = true;
            this.txtPercent.Size = new System.Drawing.Size(139, 22);
            this.txtPercent.TabIndex = 7;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1194, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(139, 34);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Сделать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // signalChart
            // 
            chartArea1.Name = "ChartArea1";
            this.signalChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.signalChart.Legends.Add(legend1);
            this.signalChart.Location = new System.Drawing.Point(12, 55);
            this.signalChart.Name = "signalChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.signalChart.Series.Add(series1);
            this.signalChart.Size = new System.Drawing.Size(1324, 300);
            this.signalChart.TabIndex = 9;
            this.signalChart.Text = "chart1";
            // 
            // correlationChart
            // 
            chartArea2.Name = "ChartArea1";
            this.correlationChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.correlationChart.Legends.Add(legend2);
            this.correlationChart.Location = new System.Drawing.Point(12, 373);
            this.correlationChart.Name = "correlationChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.correlationChart.Series.Add(series2);
            this.correlationChart.Size = new System.Drawing.Size(1324, 300);
            this.correlationChart.TabIndex = 10;
            this.correlationChart.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 700);
            this.Controls.Add(this.correlationChart);
            this.Controls.Add(this.signalChart);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.txtFastCorr);
            this.Controls.Add(this.txtStraightCorr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbxType);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.signalChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correlationChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStraightCorr;
        private System.Windows.Forms.TextBox txtFastCorr;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart signalChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart correlationChart;
    }
}

