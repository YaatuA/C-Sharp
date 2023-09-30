BMI CALCULATOR 
Completed by Yaatu Adem (301294492)

Task: Buttons, Labels, Textboxes, Radio Buttons, Checkboxes, TabControls, PictureBox, 
TableLayout, FlowLayout (at least six)
- Main form includes: labels, radio buttons, tabcontrols, tablelayout, and a button.
- Splash screen has a picturebox

Task: Listbox, Combobox, TreeView (at least one)
- Main form includes combobox as main method of input

Task: Dictionary, Queue, Stack, Linklist, List (at least two)
- private Dictionary<string, Tuple<double, double>> bmiRanges;
- List<string> weightRanges = new List<string>();

Task: The data must be read from either a json, xml or text file
- The data for BMI ranges is read from BMIRanges.xml

Task: Second form communicating with the main form. You state what data is sent or received to the main form.
- BMI category data is displayed on the second form, both to categorize based on input and to list all categories based on height

Task: Technical difficulty (at least 2-4 items)
- Splash screen is sleek with picture taking up entire frame and no FormBorderStyle
- Error checking inputted data (ie. if (!double.TryParse(metricWeightComboBox.Text, out double weight) || weight <= 0) { ... } ) with the use of MessageBoxes to clearly communicate changes so user can redo
- The use of keyvaluepairs (ie. foreach (KeyValuePair<string, Tuple<double, double>> kvp in bmiRanges) { ... })

Task: Linq queries (at least four)
- Select:
List<string> weightRanges = bmiRanges
                .Select(kvp =>
                { ... })
                .ToList(); is used in method GetWeightRanges(double height, bool metric)
- FirstOrDefault:
var category = bmiRanges.FirstOrDefault(kvp => bmi >= kvp.Value.Item1 && bmi <= kvp.Value.Item2); is used in method findBMICategory(double bmi, Dictionary<string, Tuple<double, double>> bmiRanges)
- ForEach: 
(new List<ComboBox> { metricHeightComboBox, metricWeightComboBox })
                .ForEach(cb => cb.Enabled = isChecked); is used in method metricRadioButton_CheckedChanged(object sender, EventArgs e) (also used several times throughout method)
- FirstOrDefault:
var checkedRadioButton = new[] { metricRadioButton, imperialRadioButton } .FirstOrDefault(rb => rb.Checked); is used in method calculateButton_Click(object sender, EventArgs e)

Task: Create your own generic method or class. Using any .NET generic collection does not count
-  public List<string> GetWeightRanges(double height, bool metric)
-  public string findBMICategory(double bmi, Dictionary<string, Tuple<double, double>> bmiRanges)


