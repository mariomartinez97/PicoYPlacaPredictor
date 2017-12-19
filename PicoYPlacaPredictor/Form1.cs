using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicoYPlacaPredictor
{
    public partial class Form1 : Form
    {
        CheckClass check = new CheckClass();
        public Form1()
        {
            InitializeComponent();
            comboBoxMinute.SelectedIndex = 0;
            comboBoxHour.SelectedIndex = 0;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (checkData(textBoxPlate.Text))
            {
                bool temp = check.performCheck(textBoxPlate.Text, Int32.Parse(comboBoxHour.Text), Int32.Parse(comboBoxMinute.Text), dateTimePicker1.Text);
                if (temp == true)
                {
                    labelResult.Text = "The car CANNOT be on the road";
                }
                else { labelResult.Text = "The car CAN be on the road"; }
            }
            
        }
        public bool checkData(string _plate)
        {
            if (_plate == "")
            {
                labelPlateWarning.Text = "Please enter a valid plate number";
                return false;
            }
           return true;
        }
    }
}
