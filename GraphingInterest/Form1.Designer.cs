using System.Windows.Forms;

namespace GraphingInterest
{
    partial class InterestForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TimeCB = new System.Windows.Forms.ComboBox();
            this.TimeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContrTB = new System.Windows.Forms.TextBox();
            this.ContrCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IntrTB = new System.Windows.Forms.TextBox();
            this.AmtTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InflCheckBox = new System.Windows.Forms.CheckBox();
            this.InflLbl = new System.Windows.Forms.Label();
            this.InflTB = new System.Windows.Forms.TextBox();
            this.BeginningRB = new System.Windows.Forms.RadioButton();
            this.EndRB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.FinalAmtLbl = new System.Windows.Forms.Label();
            this.GraphBtn = new System.Windows.Forms.Button();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FinalTmLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeCB
            // 
            this.TimeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeCB.FormattingEnabled = true;
            this.TimeCB.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.TimeCB.Location = new System.Drawing.Point(363, 23);
            this.TimeCB.Name = "TimeCB";
            this.TimeCB.Size = new System.Drawing.Size(65, 21);
            this.TimeCB.TabIndex = 7;
            // 
            // TimeTB
            // 
            this.TimeTB.Location = new System.Drawing.Point(306, 23);
            this.TimeTB.Name = "TimeTB";
            this.TimeTB.Size = new System.Drawing.Size(53, 20);
            this.TimeTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time span";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contribution";
            // 
            // ContrTB
            // 
            this.ContrTB.Location = new System.Drawing.Point(85, 23);
            this.ContrTB.Name = "ContrTB";
            this.ContrTB.Size = new System.Drawing.Size(65, 20);
            this.ContrTB.TabIndex = 1;
            // 
            // ContrCB
            // 
            this.ContrCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContrCB.FormattingEnabled = true;
            this.ContrCB.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.ContrCB.Location = new System.Drawing.Point(154, 23);
            this.ContrCB.Name = "ContrCB";
            this.ContrCB.Size = new System.Drawing.Size(65, 21);
            this.ContrCB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interest rate (%)";
            // 
            // IntrTB
            // 
            this.IntrTB.Location = new System.Drawing.Point(224, 23);
            this.IntrTB.Name = "IntrTB";
            this.IntrTB.Size = new System.Drawing.Size(78, 20);
            this.IntrTB.TabIndex = 5;
            // 
            // AmtTB
            // 
            this.AmtTB.Location = new System.Drawing.Point(10, 23);
            this.AmtTB.Name = "AmtTB";
            this.AmtTB.Size = new System.Drawing.Size(70, 20);
            this.AmtTB.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Initial amount";
            // 
            // InflCheckBox
            // 
            this.InflCheckBox.AutoSize = true;
            this.InflCheckBox.Location = new System.Drawing.Point(320, 51);
            this.InflCheckBox.Name = "InflCheckBox";
            this.InflCheckBox.Size = new System.Drawing.Size(109, 17);
            this.InflCheckBox.TabIndex = 8;
            this.InflCheckBox.Text = "Adjust for inflation";
            this.InflCheckBox.UseVisualStyleBackColor = true;
            this.InflCheckBox.CheckedChanged += new System.EventHandler(this.InflCheckBox_CheckedChanged);
            // 
            // InflLbl
            // 
            this.InflLbl.AutoSize = true;
            this.InflLbl.Location = new System.Drawing.Point(224, 52);
            this.InflLbl.Name = "InflLbl";
            this.InflLbl.Size = new System.Drawing.Size(82, 13);
            this.InflLbl.TabIndex = 11;
            this.InflLbl.Text = "Inflation rate (%)";
            // 
            // InflTB
            // 
            this.InflTB.Location = new System.Drawing.Point(224, 68);
            this.InflTB.Name = "InflTB";
            this.InflTB.Size = new System.Drawing.Size(82, 20);
            this.InflTB.TabIndex = 9;
            // 
            // BeginningRB
            // 
            this.BeginningRB.AutoSize = true;
            this.BeginningRB.Checked = true;
            this.BeginningRB.Location = new System.Drawing.Point(85, 68);
            this.BeginningRB.Name = "BeginningRB";
            this.BeginningRB.Size = new System.Drawing.Size(72, 17);
            this.BeginningRB.TabIndex = 4;
            this.BeginningRB.TabStop = true;
            this.BeginningRB.Text = "Beginning";
            this.BeginningRB.UseVisualStyleBackColor = true;
            // 
            // EndRB
            // 
            this.EndRB.AutoSize = true;
            this.EndRB.Location = new System.Drawing.Point(154, 68);
            this.EndRB.Name = "EndRB";
            this.EndRB.Size = new System.Drawing.Size(44, 17);
            this.EndRB.TabIndex = 3;
            this.EndRB.Text = "End";
            this.EndRB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Contribution for each period";
            // 
            // FinalAmtLbl
            // 
            this.FinalAmtLbl.AutoSize = true;
            this.FinalAmtLbl.Location = new System.Drawing.Point(7, 390);
            this.FinalAmtLbl.Name = "FinalAmtLbl";
            this.FinalAmtLbl.Size = new System.Drawing.Size(70, 13);
            this.FinalAmtLbl.TabIndex = 0;
            this.FinalAmtLbl.Text = "Final amount:";
            // 
            // GraphBtn
            // 
            this.GraphBtn.Location = new System.Drawing.Point(10, 65);
            this.GraphBtn.Name = "GraphBtn";
            this.GraphBtn.Size = new System.Drawing.Size(64, 20);
            this.GraphBtn.TabIndex = 10;
            this.GraphBtn.Text = "Graph";
            this.GraphBtn.UseVisualStyleBackColor = true;
            this.GraphBtn.Click += new System.EventHandler(this.GraphBtn_Click);
            // 
            // Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart.Legends.Add(legend2);
            this.Chart.Location = new System.Drawing.Point(10, 94);
            this.Chart.Name = "Chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Total";
            this.Chart.Series.Add(series2);
            this.Chart.Size = new System.Drawing.Size(419, 284);
            this.Chart.TabIndex = 18;
            this.Chart.Text = "Interest Graph";
            // 
            // FinalTmLbl
            // 
            this.FinalTmLbl.AutoSize = true;
            this.FinalTmLbl.Location = new System.Drawing.Point(303, 390);
            this.FinalTmLbl.Name = "FinalTmLbl";
            this.FinalTmLbl.Size = new System.Drawing.Size(54, 13);
            this.FinalTmLbl.TabIndex = 19;
            this.FinalTmLbl.Text = "Final time:";
            this.FinalTmLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // InterestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 412);
            this.Controls.Add(this.FinalTmLbl);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.FinalAmtLbl);
            this.Controls.Add(this.GraphBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EndRB);
            this.Controls.Add(this.BeginningRB);
            this.Controls.Add(this.InflTB);
            this.Controls.Add(this.InflLbl);
            this.Controls.Add(this.InflCheckBox);
            this.Controls.Add(this.AmtTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IntrTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContrTB);
            this.Controls.Add(this.ContrCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeTB);
            this.Controls.Add(this.TimeCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InterestForm";
            this.Text = "Interest Graphing Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox TimeCB;
        private TextBox TimeTB;
        private Label label1;
        private Label label2;
        private TextBox ContrTB;
        private ComboBox ContrCB;
        private Label label3;
        private TextBox IntrTB;
        private TextBox AmtTB;
        private Label label4;
        private CheckBox InflCheckBox;
        private Label InflLbl;
        private TextBox InflTB;
        private RadioButton BeginningRB;
        private RadioButton EndRB;
        private Label label6;
        private Button GraphBtn;
        private Label FinalAmtLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private Label FinalTmLbl;
    }
}