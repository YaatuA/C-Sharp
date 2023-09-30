namespace Assignment4
{
    partial class BMICalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalc));
            this.BMITabs = new System.Windows.Forms.TabControl();
            this.calculationTab = new System.Windows.Forms.TabPage();
            this.calculateTableSeparator = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metricRadioButton = new System.Windows.Forms.RadioButton();
            this.imperialRadioButton = new System.Windows.Forms.RadioButton();
            this.imperialMetricTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.imperialHeightLabel = new System.Windows.Forms.Label();
            this.imperialWeightLabel = new System.Windows.Forms.Label();
            this.imperialHeightComboBox1 = new System.Windows.Forms.ComboBox();
            this.imperialHeightComboBox2 = new System.Windows.Forms.ComboBox();
            this.imperialWeightComboBox = new System.Windows.Forms.ComboBox();
            this.imperialHeightLabel2 = new System.Windows.Forms.Label();
            this.imperialHeightLabel3 = new System.Windows.Forms.Label();
            this.imperialWeightLabel2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metricHeightLabel = new System.Windows.Forms.Label();
            this.metricWeightLabel = new System.Windows.Forms.Label();
            this.metricHeightComboBox = new System.Windows.Forms.ComboBox();
            this.metricWeightComboBox = new System.Windows.Forms.ComboBox();
            this.metricHeightLabel2 = new System.Windows.Forms.Label();
            this.metricWeightLabel2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.infoTab = new System.Windows.Forms.TabPage();
            this.informationTable = new System.Windows.Forms.TableLayoutPanel();
            this.infoTitle = new System.Windows.Forms.Label();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.infoFooter = new System.Windows.Forms.Label();
            this.BMITabs.SuspendLayout();
            this.calculationTab.SuspendLayout();
            this.calculateTableSeparator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.imperialMetricTable.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.infoTab.SuspendLayout();
            this.informationTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMITabs
            // 
            this.BMITabs.Controls.Add(this.calculationTab);
            this.BMITabs.Controls.Add(this.infoTab);
            this.BMITabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BMITabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMITabs.Location = new System.Drawing.Point(0, 0);
            this.BMITabs.Name = "BMITabs";
            this.BMITabs.SelectedIndex = 0;
            this.BMITabs.Size = new System.Drawing.Size(795, 447);
            this.BMITabs.TabIndex = 5;
            this.BMITabs.TabStop = false;
            this.BMITabs.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // calculationTab
            // 
            this.calculationTab.Controls.Add(this.calculateTableSeparator);
            this.calculationTab.Location = new System.Drawing.Point(4, 29);
            this.calculationTab.Name = "calculationTab";
            this.calculationTab.Padding = new System.Windows.Forms.Padding(3);
            this.calculationTab.Size = new System.Drawing.Size(787, 414);
            this.calculationTab.TabIndex = 0;
            this.calculationTab.Text = "Calculate";
            this.calculationTab.UseVisualStyleBackColor = true;
            this.calculationTab.Click += new System.EventHandler(this.metricTab_Click);
            // 
            // calculateTableSeparator
            // 
            this.calculateTableSeparator.ColumnCount = 1;
            this.calculateTableSeparator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.calculateTableSeparator.Controls.Add(this.panel1, 0, 0);
            this.calculateTableSeparator.Controls.Add(this.imperialMetricTable, 0, 1);
            this.calculateTableSeparator.Controls.Add(this.calculateButton, 0, 2);
            this.calculateTableSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculateTableSeparator.Location = new System.Drawing.Point(3, 3);
            this.calculateTableSeparator.Name = "calculateTableSeparator";
            this.calculateTableSeparator.RowCount = 3;
            this.calculateTableSeparator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.calculateTableSeparator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.01961F));
            this.calculateTableSeparator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.17647F));
            this.calculateTableSeparator.Size = new System.Drawing.Size(781, 408);
            this.calculateTableSeparator.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metricRadioButton);
            this.panel1.Controls.Add(this.imperialRadioButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 34);
            this.panel1.TabIndex = 3;
            // 
            // metricRadioButton
            // 
            this.metricRadioButton.AutoSize = true;
            this.metricRadioButton.Checked = true;
            this.metricRadioButton.Location = new System.Drawing.Point(9, 3);
            this.metricRadioButton.Name = "metricRadioButton";
            this.metricRadioButton.Size = new System.Drawing.Size(193, 24);
            this.metricRadioButton.TabIndex = 0;
            this.metricRadioButton.TabStop = true;
            this.metricRadioButton.Text = "Metric Measurements";
            this.metricRadioButton.UseVisualStyleBackColor = true;
            this.metricRadioButton.CheckedChanged += new System.EventHandler(this.metricRadioButton_CheckedChanged);
            // 
            // imperialRadioButton
            // 
            this.imperialRadioButton.AutoSize = true;
            this.imperialRadioButton.Location = new System.Drawing.Point(363, 3);
            this.imperialRadioButton.Name = "imperialRadioButton";
            this.imperialRadioButton.Size = new System.Drawing.Size(205, 24);
            this.imperialRadioButton.TabIndex = 4;
            this.imperialRadioButton.TabStop = true;
            this.imperialRadioButton.Text = "Imperial Measurements";
            this.imperialRadioButton.UseVisualStyleBackColor = true;
            this.imperialRadioButton.CheckedChanged += new System.EventHandler(this.imperialRadioButton_CheckedChanged);
            // 
            // imperialMetricTable
            // 
            this.imperialMetricTable.ColumnCount = 2;
            this.imperialMetricTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.54839F));
            this.imperialMetricTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.45161F));
            this.imperialMetricTable.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.imperialMetricTable.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.imperialMetricTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imperialMetricTable.Location = new System.Drawing.Point(3, 43);
            this.imperialMetricTable.Name = "imperialMetricTable";
            this.imperialMetricTable.RowCount = 1;
            this.imperialMetricTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.imperialMetricTable.Size = new System.Drawing.Size(775, 295);
            this.imperialMetricTable.TabIndex = 1;
            this.imperialMetricTable.Paint += new System.Windows.Forms.PaintEventHandler(this.imperialMetricTable_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.Controls.Add(this.imperialHeightLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.imperialWeightLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.imperialHeightComboBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.imperialHeightComboBox2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.imperialWeightComboBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.imperialHeightLabel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.imperialHeightLabel3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.imperialWeightLabel2, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(356, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.36025F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.63976F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(416, 289);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // imperialHeightLabel
            // 
            this.imperialHeightLabel.AutoSize = true;
            this.imperialHeightLabel.Location = new System.Drawing.Point(3, 0);
            this.imperialHeightLabel.Name = "imperialHeightLabel";
            this.imperialHeightLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.imperialHeightLabel.Size = new System.Drawing.Size(63, 25);
            this.imperialHeightLabel.TabIndex = 0;
            this.imperialHeightLabel.Text = "Height:";
            // 
            // imperialWeightLabel
            // 
            this.imperialWeightLabel.AutoSize = true;
            this.imperialWeightLabel.Location = new System.Drawing.Point(3, 64);
            this.imperialWeightLabel.Name = "imperialWeightLabel";
            this.imperialWeightLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.imperialWeightLabel.Size = new System.Drawing.Size(66, 25);
            this.imperialWeightLabel.TabIndex = 1;
            this.imperialWeightLabel.Text = "Weight:";
            // 
            // imperialHeightComboBox1
            // 
            this.imperialHeightComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imperialHeightComboBox1.FormattingEnabled = true;
            this.imperialHeightComboBox1.Location = new System.Drawing.Point(85, 3);
            this.imperialHeightComboBox1.Name = "imperialHeightComboBox1";
            this.imperialHeightComboBox1.Size = new System.Drawing.Size(121, 28);
            this.imperialHeightComboBox1.TabIndex = 2;
            this.imperialHeightComboBox1.TabStop = false;
            this.imperialHeightComboBox1.SelectedIndexChanged += new System.EventHandler(this.imperialHeightComboBox1_SelectedIndexChanged);
            // 
            // imperialHeightComboBox2
            // 
            this.imperialHeightComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imperialHeightComboBox2.FormattingEnabled = true;
            this.imperialHeightComboBox2.Location = new System.Drawing.Point(275, 3);
            this.imperialHeightComboBox2.Name = "imperialHeightComboBox2";
            this.imperialHeightComboBox2.Size = new System.Drawing.Size(96, 28);
            this.imperialHeightComboBox2.TabIndex = 3;
            this.imperialHeightComboBox2.TabStop = false;
            this.imperialHeightComboBox2.SelectedIndexChanged += new System.EventHandler(this.imperialHeightComboBox2_SelectedIndexChanged);
            // 
            // imperialWeightComboBox
            // 
            this.imperialWeightComboBox.FormattingEnabled = true;
            this.imperialWeightComboBox.Location = new System.Drawing.Point(85, 67);
            this.imperialWeightComboBox.Name = "imperialWeightComboBox";
            this.imperialWeightComboBox.Size = new System.Drawing.Size(121, 28);
            this.imperialWeightComboBox.TabIndex = 4;
            this.imperialWeightComboBox.TabStop = false;
            this.imperialWeightComboBox.SelectedIndexChanged += new System.EventHandler(this.imperialWeightComboBox_SelectedIndexChanged);
            // 
            // imperialHeightLabel2
            // 
            this.imperialHeightLabel2.AutoSize = true;
            this.imperialHeightLabel2.Location = new System.Drawing.Point(220, 0);
            this.imperialHeightLabel2.Name = "imperialHeightLabel2";
            this.imperialHeightLabel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.imperialHeightLabel2.Size = new System.Drawing.Size(19, 25);
            this.imperialHeightLabel2.TabIndex = 5;
            this.imperialHeightLabel2.Text = "ft";
            // 
            // imperialHeightLabel3
            // 
            this.imperialHeightLabel3.AutoSize = true;
            this.imperialHeightLabel3.Location = new System.Drawing.Point(377, 0);
            this.imperialHeightLabel3.Name = "imperialHeightLabel3";
            this.imperialHeightLabel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.imperialHeightLabel3.Size = new System.Drawing.Size(22, 25);
            this.imperialHeightLabel3.TabIndex = 6;
            this.imperialHeightLabel3.Text = "in";
            // 
            // imperialWeightLabel2
            // 
            this.imperialWeightLabel2.AutoSize = true;
            this.imperialWeightLabel2.Location = new System.Drawing.Point(220, 64);
            this.imperialWeightLabel2.Name = "imperialWeightLabel2";
            this.imperialWeightLabel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.imperialWeightLabel2.Size = new System.Drawing.Size(31, 25);
            this.imperialWeightLabel2.TabIndex = 7;
            this.imperialWeightLabel2.Text = "lbs";
            this.imperialWeightLabel2.Click += new System.EventHandler(this.imperialWeightLabel2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.23858F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.76142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.metricHeightLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metricWeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metricHeightComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metricWeightComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metricHeightLabel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.metricWeightLabel2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.04969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.95031F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 289);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metricHeightLabel
            // 
            this.metricHeightLabel.AutoSize = true;
            this.metricHeightLabel.Location = new System.Drawing.Point(3, 0);
            this.metricHeightLabel.Name = "metricHeightLabel";
            this.metricHeightLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.metricHeightLabel.Size = new System.Drawing.Size(63, 25);
            this.metricHeightLabel.TabIndex = 0;
            this.metricHeightLabel.Text = "Height:";
            this.metricHeightLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // metricWeightLabel
            // 
            this.metricWeightLabel.AutoSize = true;
            this.metricWeightLabel.Location = new System.Drawing.Point(3, 63);
            this.metricWeightLabel.Name = "metricWeightLabel";
            this.metricWeightLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.metricWeightLabel.Size = new System.Drawing.Size(66, 25);
            this.metricWeightLabel.TabIndex = 1;
            this.metricWeightLabel.Text = "Weight:";
            // 
            // metricHeightComboBox
            // 
            this.metricHeightComboBox.FormattingEnabled = true;
            this.metricHeightComboBox.Location = new System.Drawing.Point(100, 3);
            this.metricHeightComboBox.Name = "metricHeightComboBox";
            this.metricHeightComboBox.Size = new System.Drawing.Size(94, 28);
            this.metricHeightComboBox.TabIndex = 1;
            // 
            // metricWeightComboBox
            // 
            this.metricWeightComboBox.FormattingEnabled = true;
            this.metricWeightComboBox.Location = new System.Drawing.Point(100, 66);
            this.metricWeightComboBox.Name = "metricWeightComboBox";
            this.metricWeightComboBox.Size = new System.Drawing.Size(94, 28);
            this.metricWeightComboBox.TabIndex = 2;
            // 
            // metricHeightLabel2
            // 
            this.metricHeightLabel2.AutoSize = true;
            this.metricHeightLabel2.Location = new System.Drawing.Point(200, 0);
            this.metricHeightLabel2.Name = "metricHeightLabel2";
            this.metricHeightLabel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.metricHeightLabel2.Size = new System.Drawing.Size(32, 25);
            this.metricHeightLabel2.TabIndex = 4;
            this.metricHeightLabel2.Text = "cm";
            // 
            // metricWeightLabel2
            // 
            this.metricWeightLabel2.AutoSize = true;
            this.metricWeightLabel2.Location = new System.Drawing.Point(200, 63);
            this.metricWeightLabel2.Name = "metricWeightLabel2";
            this.metricWeightLabel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.metricWeightLabel2.Size = new System.Drawing.Size(26, 25);
            this.metricWeightLabel2.TabIndex = 5;
            this.metricWeightLabel2.Text = "kg";
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculateButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.calculateButton.Location = new System.Drawing.Point(285, 354);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(210, 40);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate BMI!";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // infoTab
            // 
            this.infoTab.Controls.Add(this.informationTable);
            this.infoTab.Location = new System.Drawing.Point(4, 29);
            this.infoTab.Name = "infoTab";
            this.infoTab.Padding = new System.Windows.Forms.Padding(3);
            this.infoTab.Size = new System.Drawing.Size(787, 414);
            this.infoTab.TabIndex = 1;
            this.infoTab.Text = "BMI Information";
            this.infoTab.UseVisualStyleBackColor = true;
            this.infoTab.Click += new System.EventHandler(this.imperialTab_Click);
            // 
            // informationTable
            // 
            this.informationTable.ColumnCount = 1;
            this.informationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.informationTable.Controls.Add(this.infoTitle, 0, 0);
            this.informationTable.Controls.Add(this.infoLabel1, 0, 1);
            this.informationTable.Controls.Add(this.infoLabel2, 0, 2);
            this.informationTable.Controls.Add(this.infoFooter, 0, 3);
            this.informationTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationTable.Location = new System.Drawing.Point(3, 3);
            this.informationTable.Name = "informationTable";
            this.informationTable.RowCount = 4;
            this.informationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.informationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.informationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.informationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.informationTable.Size = new System.Drawing.Size(781, 408);
            this.informationTable.TabIndex = 0;
            // 
            // infoTitle
            // 
            this.infoTitle.AutoSize = true;
            this.infoTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTitle.Location = new System.Drawing.Point(3, 0);
            this.infoTitle.Name = "infoTitle";
            this.infoTitle.Size = new System.Drawing.Size(775, 40);
            this.infoTitle.TabIndex = 0;
            this.infoTitle.Text = "Body Mass Index (BMI) Calculator";
            this.infoTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel1.Location = new System.Drawing.Point(3, 40);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(775, 122);
            this.infoLabel1.TabIndex = 1;
            this.infoLabel1.Text = resources.GetString("infoLabel1.Text");
            this.infoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel2.Location = new System.Drawing.Point(3, 162);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(775, 163);
            this.infoLabel2.TabIndex = 2;
            this.infoLabel2.Text = "Categories:";
            this.infoLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.infoLabel2.Click += new System.EventHandler(this.label3_Click);
            // 
            // infoFooter
            // 
            this.infoFooter.AutoSize = true;
            this.infoFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFooter.Location = new System.Drawing.Point(3, 325);
            this.infoFooter.Name = "infoFooter";
            this.infoFooter.Size = new System.Drawing.Size(775, 83);
            this.infoFooter.TabIndex = 3;
            this.infoFooter.Text = "0";
            this.infoFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMICalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 447);
            this.Controls.Add(this.BMITabs);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(813, 494);
            this.MinimumSize = new System.Drawing.Size(813, 494);
            this.Name = "BMICalc";
            this.Text = "BMI Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BMICalc_FormClosed);
            this.Load += new System.EventHandler(this.BMICalc_Load);
            this.Enter += new System.EventHandler(this.BMICalc_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BMICalc_KeyDown);
            this.BMITabs.ResumeLayout(false);
            this.calculationTab.ResumeLayout(false);
            this.calculateTableSeparator.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.imperialMetricTable.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.infoTab.ResumeLayout(false);
            this.informationTable.ResumeLayout(false);
            this.informationTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl BMITabs;
        private System.Windows.Forms.TabPage infoTab;
        private System.Windows.Forms.TabPage calculationTab;
        private System.Windows.Forms.TableLayoutPanel calculateTableSeparator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton metricRadioButton;
        private System.Windows.Forms.RadioButton imperialRadioButton;
        private System.Windows.Forms.TableLayoutPanel imperialMetricTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label imperialHeightLabel;
        private System.Windows.Forms.Label imperialWeightLabel;
        private System.Windows.Forms.ComboBox imperialHeightComboBox2;
        private System.Windows.Forms.ComboBox imperialWeightComboBox;
        private System.Windows.Forms.Label imperialHeightLabel2;
        private System.Windows.Forms.Label imperialHeightLabel3;
        private System.Windows.Forms.Label imperialWeightLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label metricHeightLabel;
        private System.Windows.Forms.Label metricWeightLabel;
        private System.Windows.Forms.ComboBox metricHeightComboBox;
        private System.Windows.Forms.ComboBox metricWeightComboBox;
        private System.Windows.Forms.Label metricHeightLabel2;
        private System.Windows.Forms.Label metricWeightLabel2;
        private System.Windows.Forms.ComboBox imperialHeightComboBox1;
        private System.Windows.Forms.TableLayoutPanel informationTable;
        private System.Windows.Forms.Label infoTitle;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label infoFooter;
        internal System.Windows.Forms.Button calculateButton;
    }
}

