using System.Windows.Forms;
using System;

namespace GraphingInterest
{
    public partial class InterestForm : Form
    {
        private const decimal MONTH = 30.436875M;
        private decimal total;
        private int days;
        private int leap;
        private decimal contribute;
        private decimal contributionAmt;
        private int monthsPassed;
        private bool begin;
        private decimal interest;
        private decimal inflation;

        public InterestForm()
        {
            InitializeComponent();

            total = 0;
            days = 0;
            leap = 0;
            contribute = 0;
            contributionAmt = 0;
            monthsPassed = 1;
            begin = false;
            interest = 0;
            inflation = 0;

            InflLbl.Enabled = false;
            InflTB.Enabled = false;
            ContrCB.SelectedItem = "Monthly";
            TimeCB.SelectedItem = "Years";

            Chart.ChartAreas[0].AxisX.Title = "Days";
            Chart.ChartAreas[0].AxisY.Title = "Total amount";
        }

        private void InflCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (InflCheckBox.Checked)
            {
                InflLbl.Enabled = true;
                InflTB.Enabled = true;
            }
            else
            {
                InflLbl.Enabled = false;
                InflTB.Enabled = false;
            }
        }

        private int ConvertToDays()
        {
            if (!Int32.TryParse(TimeTB.Text, out days))
            {
                return -1;
            }
            leap = 0;
            switch (TimeCB.Text)
            {
                case "Days":
                    Chart.ChartAreas[0].AxisX.Interval = 1;
                    break;
                case "Weeks":
                    Chart.ChartAreas[0].AxisX.Interval = 7;
                    days *= 7;
                    break;
                case "Months":
                    Chart.ChartAreas[0].AxisX.Interval = (double)MONTH;
                    Chart.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0}";
                    days = Convert.ToInt32(Math.Floor(days * MONTH));
                    break;
                case "Years":
                    Chart.ChartAreas[0].AxisX.Interval = 365;
                    if (days % 4 == 0)
                    {
                        leap = days / 4;
                        if (days % 100 == 0)
                        {
                            leap -= days / 100;
                            if (days % 400 == 0)
                            {
                                leap += days / 400;
                            }
                        }
                    }
                    days *= 365;
                    days += leap;
                    break;
            }
            return days;
        }

        private void GraphBtn_Click(object sender, EventArgs e)
        {
            Chart.Series["Total"].Points.Clear();
            days = ConvertToDays();
            if (days < 0)
            {
                MessageBox.Show("Time span value entered not correct.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Decimal.TryParse(AmtTB.Text, out total))
            {
                MessageBox.Show("Initial amount value entered not correct.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Decimal.TryParse(ContrTB.Text, out contributionAmt))
            {
                MessageBox.Show("Contribution amount value entered not correct.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Decimal.TryParse(IntrTB.Text, out interest))
            {
                MessageBox.Show("Interest rate value entered not correct.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Decimal.TryParse(InflTB.Text, out inflation) && InflCheckBox.Checked)
            {
                MessageBox.Show("Inflation rate value entered not correct.", "Error", MessageBoxButtons.OK);
                return;
            }
            interest /= 100;
            inflation /= 100;
            monthsPassed = 1;

            switch (ContrCB.Text)
            {
                case "Daily":
                    contribute = 1;
                    break;
                case "Weekly":
                    contribute = 7;
                    break;
                case "Monthly":
                    contribute = MONTH;
                    break;
                case "Yearly":
                    contribute = 365;
                    break;
            }

            begin = false;
            if (BeginningRB.Checked)
            {
                begin = true;
            }

            for (int i = 1; i <= days; i++)
            {
                if (begin)
                {
                    if (i % contribute == 0)
                    {
                        total += contributionAmt;
                    } else if (i > MONTH * monthsPassed)
                    {
                        total += contributionAmt;
                        monthsPassed++;
                    }
                }
                else
                {
                    if ((i - 1) % contribute == 0 && i != 0)
                    {
                        total += contributionAmt;
                    } else if ((i - 1) > MONTH * monthsPassed)
                    {
                        total += contributionAmt;
                        monthsPassed++;
                    }
                }
                if (i % 365 == 0)
                {
                    total += (total * interest);
                    if (InflCheckBox.Checked)
                    {
                        total -= (total * inflation);
                    }
                }

                total = Decimal.Round(total, 2);
                Chart.Series["Total"].Points.Add(Double.Parse(total.ToString()));
                FinalAmtLbl.Text = "Final amount: $" + String.Format("{0:0,0.00}", total);
                FinalTmLbl.Text = "Final time: " + String.Format("{0:0}", days) + " days";
            }
        }
    }
}