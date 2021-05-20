﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        Double ResultValues = 0;
        String OperationPerformed = "";
        bool isOperationPerformed = false;
        bool isNumberClicked = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            LabelCurrentOperation.Text = "";

            // Cleaning the default 0 text 1st time only.
            if ((ResultTextBox.Text == "0") || (isOperationPerformed))
                ResultTextBox.Text = "";

            isOperationPerformed = false;

            // Dynamic "ButtonClick"
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!ResultTextBox.Text.Contains("."))
                    ResultTextBox.Text = ResultTextBox.Text + button.Text;
            }
            else
            ResultTextBox.Text = ResultTextBox.Text + button.Text;
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (ResultValues != 0)
            {
                EqualButton.PerformClick();
                OperationPerformed = button.Text;
                LabelCurrentOperation.Text = ResultValues + " " + OperationPerformed;
                isOperationPerformed = true;
            }

            else
            {
                OperationPerformed = button.Text;
                ResultValues = Double.Parse(ResultTextBox.Text);
                LabelCurrentOperation.Text = ResultValues + " " + OperationPerformed;
                isOperationPerformed = true;
            }
        }

        private void ClearAndResetButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "0";
            LabelCurrentOperation.Text = "Resset";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "0";
            ResultValues = 0;
        }

        private void EqualButtonClick(object sender, EventArgs e)
        {
            switch (OperationPerformed)
            {
                case "+":
                    ResultTextBox.Text = (ResultValues + Double.Parse(ResultTextBox.Text)).ToString();
                    break;

                case "-":
                    ResultTextBox.Text = (ResultValues + Double.Parse(ResultTextBox.Text)).ToString();
                    break;

                case "×":
                    ResultTextBox.Text = (ResultValues + Double.Parse(ResultTextBox.Text)).ToString();
                    break;
                
                case "/":
                    ResultTextBox.Text = (ResultValues + Double.Parse(ResultTextBox.Text)).ToString();
                    break;

                default:
                    break;
            }

            ResultValues = Double.Parse(ResultTextBox.Text);
            LabelCurrentOperation.Text = "";
        }
    }
}