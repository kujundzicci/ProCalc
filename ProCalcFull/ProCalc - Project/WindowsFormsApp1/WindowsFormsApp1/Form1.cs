﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double Result_Value = 0;
        String Operator_Performed = " ";
        bool PerformedOp = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || PerformedOp)
                textBox_Result.Clear();

            PerformedOp = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text += button.Text;
            }

            else
                textBox_Result.Text += button.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Operator_click_Event(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (Result_Value != 0)
            {
                button16.PerformClick();
                Operator_Performed = button.Text;
                label_Show_Op.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
            else
            {

                Operator_Performed = button.Text;
                Result_Value = Double.Parse(textBox_Result.Text);
                label_Show_Op.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonclicked = false;
            button22.Enabled = true;
            button21.Enabled = true;
            button11.Enabled = true;
            button19.Enabled = true;
            textBox_Result.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            buttonclicked = false;
            button22.Enabled = true;
            button21.Enabled = true;
            button11.Enabled = true;
            button19.Enabled = true;
            textBox_Result.Text = "0";
            Result_Value = 0;
            label_Show_Op.Text = " ";
        }

        public static double res;

        private void button16_Click(object sender, EventArgs e)
        {
            switch (Operator_Performed)
            {
                case "+":
                    textBox_Result.Text = (Result_Value + Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (Result_Value - Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (Result_Value * Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (Result_Value / Double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;

            }
            Result_Value = Double.Parse(textBox_Result.Text);
            label_Show_Op.Text = " ";
        }
        private bool buttonclicked = false;
        private void button22_Click(object sender, EventArgs e)
        {
            buttonclicked = false;
            button19.Enabled = true;
            button21.Enabled = true;
            button11.Enabled = true;
            if (!buttonclicked)
            {
                Result_Value = Double.Parse(textBox_Result.Text);
                label_Show_Op.Text = " ";
                textBox_Result.Text = (Result_Value / 117).ToString();
                buttonclicked = true;


                button22.Enabled = false;
            }
            
              
        }

        private void button21_Click(object sender, EventArgs e)
        {
            buttonclicked = false;
            button19.Enabled = true;
            button11.Enabled = true;
            button22.Enabled = true;
            if (!buttonclicked)
            {
                Result_Value = Double.Parse(textBox_Result.Text);
                label_Show_Op.Text = " ";
                textBox_Result.Text = (Result_Value * 117).ToString();
                buttonclicked = true;

                button21.Enabled = false;
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            buttonclicked = false;
            button11.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            if (!buttonclicked)
            {
                int decimalValue = 0;
                int binaryLength = textBox_Result.Text.Length;
                for (int i = 0; i < binaryLength; i++)
                {
                    decimalValue += int.Parse(textBox_Result.Text[i].ToString()) * (int)Math.Pow(2, binaryLength - i - 1);
                }
                textBox_Result.Text = decimalValue.ToString();

                buttonclicked = true;
                button19.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buttonclicked = false;
            button19.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            if (!buttonclicked)
            {

                double decimalValue = double.Parse(textBox_Result.Text);
                textBox_Result.Text = Convert.ToString((int)decimalValue, 2);
                buttonclicked = true;
                button11.Enabled = false;
            }
        }
    }
}
