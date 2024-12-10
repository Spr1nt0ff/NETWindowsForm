using System.Collections.Generic;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;

namespace homework {
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, double> _fuelPrices;
        private readonly List<(TextBox Price, TextBox Quantity, double Total)> _menuItems;
        private double _refuelingTotal;
        private double _coffeeTotal;

        public Form1()
        {
            InitializeComponent();

            // Initialize dictionaries and collections
            _fuelPrices = new Dictionary<string, double> {
                {"92", 3.25},
                {"95", 2.25},
                {"95 Premium", 5.55},
                {"Diesel", 4.65},
                {"E85", 2.46}
            };

            _menuItems = new List<(TextBox, TextBox, double)> {
                (textBox7, textBox8, 0),
                (textBox6, textBox9, 0),
                (textBox4, textBox11, 0),
                (textBox5, textBox10, 0)
            };

            SetupTextBoxes();
            SetupCheckBoxes();
            SetupRadioButtons();

            comboBox1.Items.AddRange(_fuelPrices.Keys.ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void SetupTextBoxes()
        {
            TextBox[] allTextBoxes = { textBox1, textBox2, textBox3, textBox8, textBox9, textBox10, textBox11 };
            foreach (var textBox in allTextBoxes)
            {
                textBox.Enabled = false;
                textBox.Text = "0";
            }

            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox2.TextChanged += GasStationTextBoxChanged;
            textBox3.TextChanged += GasStationTextBoxChanged;

            TextBox[] coffeeTextBoxes = { textBox8, textBox9, textBox10, textBox11 };
            foreach (var coffeeBox in coffeeTextBoxes)
            {
                coffeeBox.EnabledChanged += CoffeeTextBoxChanged;
                coffeeBox.TextChanged += CoffeeTextBoxChanged;
            }
        }

        private void SetupCheckBoxes()
        {
            CheckBox[] coffeeCheckBoxes = { checkBox1, checkBox2, checkBox3, checkBox4 };
            foreach (var checkBox in coffeeCheckBoxes)
            {
                checkBox.CheckedChanged += CoffeeCheckBoxChanged;
            }
        }

        private void SetupRadioButtons()
        {
            radioButton1.CheckedChanged += RadioButtonChanged;
            radioButton2.CheckedChanged += RadioButtonChanged;
        }

        private void UpdateTotalSum()
        {
            double totalSum = _refuelingTotal + _coffeeTotal;
            label10.Text = $"{totalSum:F2} грн";
        }

        private void CalculateRefuelingTotal()
        {
            if (double.TryParse(textBox1.Text, out double price) && double.TryParse(textBox2.Text, out double quantity))
            {
                _refuelingTotal = price * quantity;
                label6.Text = $"{_refuelingTotal:F2} грн";
                UpdateTotalSum();
            }
        }

        private void CalculateCafeTotal()
        {
            _coffeeTotal = 0;
            foreach (var (priceBox, quantityBox, _) in _menuItems)
            {
                if (priceBox.Enabled && double.TryParse(priceBox.Text, out double price) && double.TryParse(quantityBox.Text, out double quantity))
                {
                    _coffeeTotal += price * quantity;
                }
            }
            label9.Text = $"{_coffeeTotal:F2} грн";
            UpdateTotalSum();
        }

        private void GasStationTextBoxChanged(object sender, EventArgs e)
        {
            CalculateRefuelingTotal();
        }

        private void CoffeeTextBoxChanged(object sender, EventArgs e)
        {
            CalculateCafeTotal();
        }

        private void CoffeeCheckBoxChanged(object sender, EventArgs e)
        {
            CheckBox[] coffeeCheckBoxes = { checkBox1, checkBox2, checkBox3, checkBox4 };
            TextBox[] coffeeTextBoxes = { textBox8, textBox9, textBox10, textBox11 };

            for (int i = 0; i < coffeeCheckBoxes.Length; i++)
            {
                coffeeTextBoxes[i].Enabled = coffeeCheckBoxes[i].Checked;
            }
        }

        private void RadioButtonChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = radioButton1.Checked;
            textBox3.Enabled = radioButton2.Checked;

            if (radioButton1.Checked)
            {
                CalculateRefuelingTotal();
            }
            else
            {
                CalculateRefuelingTotal();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is string fuelType && _fuelPrices.TryGetValue(fuelType, out double price))
            {
                textBox1.Text = price.ToString("F2");
                CalculateRefuelingTotal();
            }
        }
    }
}