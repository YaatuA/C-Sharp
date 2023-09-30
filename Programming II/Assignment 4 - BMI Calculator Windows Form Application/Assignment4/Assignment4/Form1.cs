using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Assignment4
{
    public partial class BMICalc : Form
    {
        private Dictionary<string, Tuple<double, double>> bmiRanges;

        public BMICalc()
        {
            InitializeComponent();
            this.Load += new EventHandler(BMICalc_Load);

            // Add heights/weights to the ComboBoxes
            for (int i = 90; i <= 225; i++)
            {
                metricHeightComboBox.Items.Add(i);
            }

            for (int i = 22; i <= 150; i++)
            {
                metricWeightComboBox.Items.Add(i);
            }

            for (int i = 2; i <= 8; i++)
            {
                imperialHeightComboBox1.Items.Add(i);
            }

            for (int i = 0; i <= 11; i++)
            {
                imperialHeightComboBox2.Items.Add(i);
            }

            for (int i = 50; i <= 350; i++)
            {
                imperialWeightComboBox.Items.Add(i);
            }

            // Sets imperial values as disabled by default (as default selected radio button is metric)
            imperialHeightComboBox1.Enabled = false;
            imperialHeightComboBox2.Enabled = false;
            imperialWeightComboBox.Enabled = false;

            //Writes label text for info tab
            infoLabel2.Text = "Categories: \nUnderweight = <18.5 \nNormal weight = 18.5-24.9 \nOverweight = 25-29.9 \nObesity = >30";
            infoFooter.Text = "Assignment 4 \nYaatu Adem, 301294492 \nCOMP 123, Winter 2023";

            // Read the XML file and store BMI ranges in a dictionary
            bmiRanges = new Dictionary<string, Tuple<double, double>>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("BMIRanges.xml");
            XmlNodeList rangeNodes = xmlDoc.SelectNodes("/BMI/Range");
            foreach (XmlNode rangeNode in rangeNodes)
            {
                string category = rangeNode.SelectSingleNode("Category").InnerText;
                double minimum = Convert.ToDouble(rangeNode.SelectSingleNode("Minimum").InnerText);
                double maximum = Convert.ToDouble(rangeNode.SelectSingleNode("Maximum").InnerText);
                bmiRanges[category] = Tuple.Create(minimum, maximum);
            }

        }

        public string findBMICategory(double bmi, Dictionary<string, Tuple<double, double>> bmiRanges)
        {
            var category = bmiRanges.FirstOrDefault(kvp => bmi >= kvp.Value.Item1 && bmi <= kvp.Value.Item2);
            return category.Key ?? "Category Not Found";
        }


        public List<string> GetWeightRanges(double height, bool metric)
        {
            double heightInMeters = height / 100.0;

            List<string> weightRanges = bmiRanges
                .Select(kvp =>
                {
                    string category = kvp.Key;
                    Tuple<double, double> range = kvp.Value;

                    double minWeight = range.Item1 * heightInMeters * heightInMeters;
                    double maxWeight = range.Item2 * heightInMeters * heightInMeters;

                    if (!metric)
                    {
                        minWeight = (range.Item1 / 703.0) * height * height;
                        maxWeight = (range.Item2 / 703.0) * height * height;
                    }

                    minWeight = Math.Round(minWeight, 1);
                    maxWeight = Math.Round(maxWeight, 1);

                    string weightRange;
                    if (category == "Underweight")
                    {
                        weightRange = $"{category} = <{maxWeight} {(metric ? "kg" : "lbs")}";
                    }
                    else if (category == "Obese")
                    {
                        weightRange = $"{category} = >{minWeight} {(metric ? "kg" : "lbs")}";
                    }
                    else
                    {
                        weightRange = $"{category} = {minWeight}-{maxWeight} {(metric ? "kg" : "lbs")}";
                    }

                    return weightRange;
                })
                .ToList();

            return weightRanges;
        }





        private void metricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = metricRadioButton.Checked;

            (new List<ComboBox> { metricHeightComboBox, metricWeightComboBox })
                .ForEach(cb => cb.Enabled = isChecked);

            (new List<Control> { metricHeightComboBox, metricWeightComboBox })
                .ForEach(cb => cb.TabStop = isChecked);

            (new List<Control> { imperialHeightComboBox1, imperialHeightComboBox2, imperialWeightComboBox })
                .ForEach(cb => cb.TabStop = !isChecked);
        }


        private void imperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (imperialRadioButton.Checked)
            {
                imperialHeightComboBox1.Enabled = true;
                imperialHeightComboBox2.Enabled = true;
                imperialWeightComboBox.Enabled = true;
                metricRadioButton.TabStop = true;
                imperialHeightComboBox1.TabStop = true;
                imperialHeightComboBox2.TabStop = true;
                imperialWeightComboBox.TabStop = true;
                metricHeightComboBox.TabStop = false;
                metricWeightComboBox.TabStop = false;
            }
            else
            {
                imperialHeightComboBox1.Enabled = false;
                imperialHeightComboBox2.Enabled = false;
                imperialWeightComboBox.Enabled = false;
            }
        }

        public void calculateButton_Click(object sender, EventArgs e)
        {
            var checkedRadioButton = new[] { metricRadioButton, imperialRadioButton } .FirstOrDefault(rb => rb.Checked);

            switch (checkedRadioButton?.Name)
            {
                case nameof(metricRadioButton):
                    // metric calculations
                    if (string.IsNullOrEmpty(metricHeightComboBox.Text) || string.IsNullOrEmpty(metricWeightComboBox.Text)) //verifies that all values are not null/empty
                    {
                        MessageBox.Show("Please enter a value in both the height and weight fields.");
                        return;
                    }

                    bool metric = true;

                    // Gets height and weight to calculate BMI
                    if (!double.TryParse(metricHeightComboBox.Text, out double height) || height <= 0)
                    {
                        MessageBox.Show("Please enter a valid height greater than 0.", "Invalid Height", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!double.TryParse(metricWeightComboBox.Text, out double weight) || weight <= 0)
                    {
                        MessageBox.Show("Please enter a valid weight greater than 0.", "Invalid Weight", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    double bmi = weight / Math.Pow(height / 100, 2);

                    // Gets BMI Category
                    string bmiCategory = findBMICategory(bmi, (Dictionary<string, Tuple<double, double>>)bmiRanges);

                    // Gets BMI weights for each category
                    List<string> weightRanges = GetWeightRanges(height, metric);

                    // Update the labels in solutionForm
                    solutionForm solutionForm = new solutionForm();
                    solutionForm.bmiLabel2.Text = "Your BMI is: " + bmi.ToString("F2");
                    solutionForm.bmiLabel1.Text = "Your BMI Category is: " + bmiCategory;
                    string label3Text = $"For your height: \n{String.Join("\n", weightRanges)}";
                    solutionForm.bmiLabel3.Text = label3Text;
                    solutionForm.Show();
                    break;
                case nameof(imperialRadioButton):
                    // imperial calculations
                    if (string.IsNullOrEmpty(imperialWeightComboBox.Text)) //verifies that all values are not null/empty
                    {
                        MessageBox.Show("Please enter a value in both the height and weight fields.");
                        return;
                    }

                    if (!double.TryParse(imperialWeightComboBox.Text, out weight) || weight <= 0)
                    {
                        MessageBox.Show("Please enter a valid weight greater than 0.", "Invalid Weight", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    metric = false;

                    double feet = double.Parse(imperialHeightComboBox1.Text);
                    double inches = double.Parse(imperialHeightComboBox2.Text);
                    height = (feet * 12) + inches;

                    bmi = (weight / (height * height)) * 703.0;

                    // Gets BMI Category
                    bmiCategory = findBMICategory(bmi, (Dictionary<string, Tuple<double, double>>)bmiRanges);

                    // Gets BMI weights for each category
                    weightRanges = GetWeightRanges(height, metric);

                    // Update the labels in solutionForm
                     solutionForm = new solutionForm();
                    solutionForm.bmiLabel2.Text = "Your BMI is: " + bmi.ToString("F2");
                    solutionForm.bmiLabel1.Text = "Your BMI Category is: " + bmiCategory;
                    label3Text = $"For your height: \n{String.Join("\n", weightRanges)}";
                    solutionForm.bmiLabel3.Text = label3Text;
                    solutionForm.Show();
                    break;
                default:
                    MessageBox.Show("Please select a measurement system.", "Measurement System Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metricTab_Click(object sender, EventArgs e)
        {

        }

        private void imperialTab_Click(object sender, EventArgs e)
        {

        }

        private void imperialMetricTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void imperialWeightLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void imperialHeightComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void imperialHeightComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BMICalc_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void imperialWeightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BMICalc_Load(object sender, EventArgs e)
        {
            // Set default selection
            metricHeightComboBox.SelectedIndex = 0;
            metricWeightComboBox.SelectedIndex = 0;
            imperialHeightComboBox1.SelectedIndex = 0;
            imperialHeightComboBox2.SelectedIndex = 0;
            imperialWeightComboBox.SelectedIndex = 0;
        }

        private void BMICalc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BMICalc_Enter(object sender, EventArgs e)
        {
        }
    }
}
