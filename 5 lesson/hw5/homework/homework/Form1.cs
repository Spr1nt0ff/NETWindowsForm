using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace homework
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> _fuelPrices;
        (CheckBox CheckBox, TextBox Quantity, TextBox Price, double PricePerUnit)[] _menuItems;
        private double _refuelingTotal;
        private double _coffeeTotal;

        public Form1()
        {
            InitializeComponent();

            _fuelPrices = new Dictionary<string, double>
            {
                {"92", 3.25},
                {"95", 2.25},
                {"95 Premium", 5.55},
                {"Diesel", 4.65},
                {"E85", 2.46}
            };

            _menuItems = new (CheckBox, TextBox, TextBox, double)[]
            {
                (checkBox1, textBox8, textBox7, 12.00),
                (checkBox2, textBox9, textBox6, 15.00),
                (checkBox3, textBox10, textBox5, 25.00),
                (checkBox4, textBox11, textBox4, 30.00)
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
            for (int i = 0; i < allTextBoxes.Length; i++)
            {
                allTextBoxes[i].Enabled = false;
                allTextBoxes[i].Text = "0";
            }

            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox2.TextChanged += GasStationTextBoxChanged;
            textBox3.TextChanged += GasStationTextBoxChanged;

            for (int i = 0; i < _menuItems.Length; i++)
            {
                _menuItems[i].Quantity.TextChanged += (s, e) => CalculateCafeTotal();
                _menuItems[i].Price.TextChanged += (s, e) => CalculateCafeTotal();
                _menuItems[i].Price.Text = _menuItems[i].PricePerUnit.ToString("F2");
            }
        }

        private void SetupCheckBoxes()
        {
            for (int i = 0; i < _menuItems.Length; i++)
            {
                CheckBox checkBox = _menuItems[i].CheckBox;
                TextBox quantity = _menuItems[i].Quantity;

                checkBox.CheckedChanged += (s, e) =>
                {
                    quantity.Enabled = checkBox.Checked;
                    CalculateCafeTotal();
                };
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
            if (double.TryParse(textBox2.Text, out double quantity) && double.TryParse(textBox1.Text, out double price))
            {
                _refuelingTotal = price * quantity;
                label6.Text = $"{_refuelingTotal:F2} грн";
            }
            else
            {
                label6.Text = "0 грн";
                _refuelingTotal = 0;
            }
            UpdateTotalSum();
        }

        private void CalculateCafeTotal()
        {
            _coffeeTotal = 0;
            foreach (var (checkBox, quantity, price, pricePerUnit) in _menuItems)
            {
                if (checkBox.Checked && double.TryParse(quantity.Text, out double quantityValue))
                {
                    _coffeeTotal += pricePerUnit * quantityValue;
                }
            }
            label9.Text = $"{_coffeeTotal:F2} грн";
            UpdateTotalSum();
        }

        private void GasStationTextBoxChanged(object sender, EventArgs e)
        {
            CalculateRefuelingTotal();
        }

        private void RadioButtonChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = radioButton1.Checked;
            textBox3.Enabled = radioButton2.Checked;

            CalculateRefuelingTotal();
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
