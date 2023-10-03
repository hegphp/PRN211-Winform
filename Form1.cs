namespace WindowsForm {
    public partial class Form1 : Form {
        string[] unit = { "Weeks", "Days", "Hours", "Minutes", "Seconds" };
        Dictionary<string, double> convertValues;

        //private double secondValues;

        public Form1() {
            InitializeComponent();

            //Add values for label box

            convertValues = new Dictionary<string, double> {
                { "Weeks", 7*24*60*60 },
                { "Days", 24 * 60 * 60 },
                { "Hours", 60 * 60 },
                { "Minutes", 60 },
                { "Seconds", 1 }
            };

        }

        private void ConvertWhenCbChanged() {
            try {
                //check if input value is null or not
                if (inputValue.Equals("")) {
                    return;
                }
                else if (outputComboBox.SelectedItem != null) {
                    double.TryParse(inputValue.Text, out double value);
                    double secondValues = convertValues[inputComboBox.SelectedItem.ToString()] * value;
                    outputValue.Text = (secondValues / convertValues[outputComboBox.SelectedItem.ToString()]).ToString();
                }
            }
            catch (Exception ex) {
                double.TryParse(inputValue.Text, out double value);
                double secondValues = convertValues[inputComboBox.SelectedItem.ToString()] * value;
                outputValue.Text = (secondValues / (24 * 60 * 60)).ToString();
            }
        }


        private void DeleteEndChar_Click(object sender, EventArgs e) {
            try {
                inputValue.Text = inputValue.Text.Remove(inputValue.Text.Length - 1, 1);
            }
            catch (ArgumentOutOfRangeException outOfRangeEx) {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void AddNumber1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            List<string> unitClone1 = new List<string>(unit);
            inputComboBox.DataSource = unitClone1;
            List<string> unitClone2 = new List<string>(unit);
            outputComboBox.DataSource = unitClone2;
            outputComboBox.SelectedItem = "Days";
        }

        private void DeleteAll_Click(object sender, EventArgs e) {
            outputValue.Text = "0";
            inputValue.Text = "0";
        }

        private void MinuteInOut_TextChanged(object sender, EventArgs e) {
            double.TryParse(inputValue.Text, out double minuteInput);
            outputValue.Text = (minuteInput / 60 / 24).ToString();
        }

        private void AddNumber1_Click_1(object sender, EventArgs e) {
            if (inputValue.Text == "0") {
                inputValue.Text = "1";
            }
            else
                inputValue.Text = inputValue.Text + "1";
        }

        private void dayValue_TextChanged(object sender, EventArgs e) {
            double.TryParse((string)outputValue.Text, out double dayInput);
            inputValue.Text = (dayInput * 60 * 24).ToString();
        }

        private void AddNumber2_Click(object sender, EventArgs e) {
            if (inputValue.Text == "0")
                inputValue.Text = "2";
            else
                inputValue.Text = inputValue.Text + "2";
        }

        private void AddNumber3_Click(object sender, EventArgs e) {
            if (inputValue.Text == "0")
                inputValue.Text = "3";
            else
                inputValue.Text = inputValue.Text + "3";
        }

        private void AddNumber4_Click(object sender, EventArgs e) {
            if (inputValue.Text == "0")
                inputValue.Text = "4";
            else
                inputValue.Text = inputValue.Text + "4";
        }

        private void AddNumber5_Click(object sender, EventArgs e) {
            if (inputValue.Text == "0")
                inputValue.Text = "5";
            else
                inputValue.Text = inputValue.Text + "5";
        }

        private void AddNumber6_Click(object sender, EventArgs e) {
            if (inputValue.Text == "0")
                inputValue.Text = "6";
            else
                inputValue.Text = inputValue.Text + "6";
        }

        private void AddNumber7_Click(object sender, EventArgs e) {
            if (inputValue.Text == "0")
                inputValue.Text = "7";
            else
                inputValue.Text = inputValue.Text + "7";
        }

        private void AddNumber8_Click(object sender, EventArgs e) {
            if (inputValue.Text == "0")
                inputValue.Text = "8";
            else
                inputValue.Text = inputValue.Text + "8";
        }

        private void AddNumber9_Click(object sender, EventArgs e) {
            if (inputValue.Text == "0")
                inputValue.Text = "9";
            else
                inputValue.Text = inputValue.Text + "9";
        }

        private void AddNumber0_Click(object sender, EventArgs e) {
            //check if the input Value is 0 or not
            if (inputValue.Text == "0" || inputValue.Text == "")
                return;
            inputValue.Text = inputValue.Text + "0";
        }

        private void AddDot_Click(object sender, EventArgs e) {
            //check if the input text contain "." or not
            if (inputValue.Text.Contains("."))
                return;
            if (inputValue.Text == "") {
                inputValue.Text = inputValue.Text + "0.";
                return;
            }
            inputValue.Text = inputValue.Text + ".";
        }

        private void inputComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ConvertWhenCbChanged();
        }

        private void outputComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ConvertWhenCbChanged();
        }

        private void Convert() {
            double.TryParse(inputValue.Text, out double input);
            double seconds = input * convertValues[inputComboBox.SelectedItem.ToString()];
            double output = seconds / convertValues[outputComboBox.SelectedItem.ToString()];
            outputValue.Text = output.ToString();
        }

        private void inputValue_TextChanged(object sender, EventArgs e) {
            Convert();
        }
    }
}