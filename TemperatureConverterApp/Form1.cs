using AppCore.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperatureConverter.Domain.Entities;
using TemperatureConverter.Domain.Enums;
using TemperatureConverter.Domain.Interfaces;

namespace TemperatureConverterApp
{
    public partial class Form1 : Form
    {        
        public Form1()
        {            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temperature t = new Temperature() {
                Value = double.Parse(txtFrom.Text),
                TemperatureScale = (TemperatureScale) cmbFromScale.SelectedIndex
            };

            txtTo.Text = TemperatureConverterFactory.CreateInstance(t, (TemperatureScale)cmbToScale.SelectedIndex).convert(t).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            object[] temperatureScales = Enum.GetValues(typeof(TemperatureScale)).Cast<object>().ToArray();
            cmbFromScale.Items.AddRange(temperatureScales);
            cmbFromScale.SelectedIndex = 0;
            cmbToScale.Items.AddRange(temperatureScales);
            cmbToScale.SelectedIndex = 1;
        }
    }
}
