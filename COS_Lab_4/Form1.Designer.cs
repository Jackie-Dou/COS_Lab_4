
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
            this.txtSwing = new System.Windows.Forms.TextBox();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.txtPhase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbxN = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correlationChart)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbxType
            // 
            this.cbbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxType.FormattingEnabled = true;
            this.cbbxType.Location = new System.Drawing.Point(12, 75);
            this.cbbxType.Name = "cbbxType";
            this.cbbxType.Size = new System.Drawing.Size(173, 24);
            this.cbbxType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите вид корреляции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прямая корреляция";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Быстрая корреляция";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Процент";
            // 
            // txtStraightCorr
            // 
            this.txtStraightCorr.Location = new System.Drawing.Point(228, 77);
            this.txtStraightCorr.Name = "txtStraightCorr";
            this.txtStraightCorr.ReadOnly = true;
            this.txtStraightCorr.Size = new System.Drawing.Size(173, 22);
            this.txtStraightCorr.TabIndex = 5;
            // 
            // txtFastCorr
            // 
            this.txtFastCorr.Location = new System.Drawing.Point(425, 77);
            this.txtFastCorr.Name = "txtFastCorr";
            this.txtFastCorr.ReadOnly = true;
            this.txtFastCorr.Size = new System.Drawing.Size(173, 22);
            this.txtFastCorr.TabIndex = 6;
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(626, 75);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.ReadOnly = true;
            this.txtPercent.Size = new System.Drawing.Size(173, 22);
            this.txtPercent.TabIndex = 7;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1197, 77);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(139, 24);
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
            this.signalChart.Location = new System.Drawing.Point(12, 122);
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
            this.correlationChart.Location = new System.Drawing.Point(12, 440);
            this.correlationChart.Name = "correlationChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.correlationChart.Series.Add(series2);
            this.correlationChart.Size = new System.Drawing.Size(1324, 300);
            this.correlationChart.TabIndex = 10;
            this.correlationChart.Text = "chart2";
            // 
            // txtSwing
            // 
            this.txtSwing.Location = new System.Drawing.Point(12, 30);
            this.txtSwing.Name = "txtSwing";
            this.txtSwing.Size = new System.Drawing.Size(173, 22);
            this.txtSwing.TabIndex = 11;
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(228, 30);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(173, 22);
            this.txtFrequency.TabIndex = 12;
            // 
            // txtPhase
            // 
            this.txtPhase.Location = new System.Drawing.Point(425, 30);
            this.txtPhase.Name = "txtPhase";
            this.txtPhase.Size = new System.Drawing.Size(173, 22);
            this.txtPhase.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Введите амплитуду";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Введите частоту";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Введите фазу";
            // 
            // cbbxN
            // 
            this.cbbxN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxN.FormattingEnabled = true;
            this.cbbxN.Location = new System.Drawing.Point(626, 28);
            this.cbbxN.Name = "cbbxN";
            this.cbbxN.Size = new System.Drawing.Size(173, 24);
            this.cbbxN.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Выберите N";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 752);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbxN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhase);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.txtSwing);
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
        private System.Windows.Forms.TextBox txtSwing;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.TextBox txtPhase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbxN;
        private System.Windows.Forms.Label label8;
    }
}

