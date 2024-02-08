using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        float sum_all;
        Timer t;
        int i;
        public Form1()
        {
            InitializeComponent();
            sum_all = 0;
            t = new Timer();
            t.Interval = 1000;
            i = 0;
            t.Tick += t_Timer_Tick;
        }
        private void t_Timer_Tick(object sender, EventArgs e)
        {
            if(i==10)
            {
                t.Stop();
                i = 0;
                DialogResult result =MessageBox.Show("Очистити форму?", "Administration", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result==DialogResult.Yes)
                {
                    choseoil.Text = "A-95";
                    costforlitr.Text = "52,00";
                    number.Checked = true;
                    numberoflitr.Enabled = true;
                    numberoflitr.Text = "0,00";
                    suma.Checked = false;
                    numberofsum.Text = "0,00";
                    numberofsum.Enabled = false;
                    havetopayoil.Text = "0,00";
                    label2.Text = "грн";
                    res_cost.Text = "0,00";
                    hot_dog.Checked = false;
                    hamburger.Checked = false;
                    potato_free.Checked = false;
                    Coca_cola.Checked = false;
                    number_hotdog.Text = "0";
                    number_hamburg.Text = "0";
                    number_potatofree.Text = "0";
                    number_cola.Text = "0";
                    number_hotdog.Enabled = false;
                    number_hamburg.Enabled = false;
                    number_potatofree.Enabled = false;
                    number_cola.Enabled = false;
                
                }
                if (result == DialogResult.No)
                {
                    t.Start();
   
                }
            }
            //Text = i.ToString();
            i++;
        }

        private void number_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            try
            {
                if (radioButton.Name == "number")
                {
                    numberoflitr.Enabled = true;
                    numberofsum.Enabled = false;
                    groupBox2.Text = "До сплати:";
                    havetopayoil.Text = (Convert.ToSingle(numberoflitr.Text) * Convert.ToSingle(costforlitr.Text)).ToString();
                    label2.Text = "грн";

                }
                if (radioButton.Name == "suma")
                {
                    numberofsum.Enabled = true;
                    numberoflitr.Enabled = false;
                    groupBox2.Text = "До видачі:";
                    havetopayoil.Text = Math.Round((Convert.ToSingle(numberofsum.Text) / Convert.ToSingle(costforlitr.Text)), 3).ToString();
                    label2.Text = "л";
                }
            }
            catch (Exception exc1)
            {

            }
        }

        private void hot_dog_CheckedChanged(object sender, EventArgs e)
        {

            
            CheckBox checkBox = sender as CheckBox;
                if (checkBox.Name == "hot_dog")
                {
                    if (checkBox.Checked == true)
                    {
                        number_hotdog.Enabled = true;
                    CalculateEatSum();
                    }
                    else
                    {
                    number_hotdog.Enabled = false;
                    CalculateEatSum();
                    }
                        
                }
                if (checkBox.Name == "hamburger")
                {
                if (checkBox.Checked == true)
                {
                    number_hamburg.Enabled = true;
                    CalculateEatSum();
                }
                else
                {
                    number_hamburg.Enabled = false;
                    CalculateEatSum();
                }
                }
                if (checkBox.Name == "potato_free")
                {
                if (checkBox.Checked == true)
                {
                    number_potatofree.Enabled = true;
                    CalculateEatSum();
                }
                else
                {
                    number_potatofree.Enabled = false;
                    CalculateEatSum();
                }
                }
                if (checkBox.Name == "Coca_cola")
                {
                if (checkBox.Checked == true)
                {
                    number_cola.Enabled = true;
                    CalculateEatSum();
                }
                else
                {
                    number_cola.Enabled = false;
                    CalculateEatSum();
                }
                }
            
            
        }

        private void numberoflitr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(number.Checked==true)
                {
                    havetopayoil.Text = (Convert.ToSingle(numberoflitr.Text) * Convert.ToSingle(costforlitr.Text)).ToString();
                    
                }
                else
                {
                    havetopayoil.Text = Math.Round((Convert.ToSingle(numberofsum.Text) / Convert.ToSingle(costforlitr.Text)),3).ToString();

                }
                
            }
            catch (Exception exc)
            {

            }
        }

        private void choseoil_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox comboBox = sender as ComboBox;
                if (comboBox.Text == "А-95")
                {
                    costforlitr.Text = "52,00";
                    if (number.Checked == true)
                    {
                        havetopayoil.Text = (Convert.ToSingle(numberoflitr.Text) * Convert.ToSingle(costforlitr.Text)).ToString();

                    }
                    else
                    {
                        havetopayoil.Text = Math.Round((Convert.ToSingle(numberofsum.Text) / Convert.ToSingle(costforlitr.Text)), 3).ToString();

                    }
                }
                else if (comboBox.Text == "А-92")
                {
                    costforlitr.Text = "49,00";
                    if (number.Checked == true)
                    {
                        havetopayoil.Text = (Convert.ToSingle(numberoflitr.Text) * Convert.ToSingle(costforlitr.Text)).ToString();

                    }
                    else
                    {
                        havetopayoil.Text = Math.Round((Convert.ToSingle(numberofsum.Text) / Convert.ToSingle(costforlitr.Text)), 3).ToString();

                    }
                }
                else if (comboBox.Text == "ДП")
                {
                    costforlitr.Text = "56,00";
                    if (number.Checked == true)
                    {
                        havetopayoil.Text = (Convert.ToSingle(numberoflitr.Text) * Convert.ToSingle(costforlitr.Text)).ToString();

                    }
                    else
                    {
                        havetopayoil.Text = Math.Round((Convert.ToSingle(numberofsum.Text) / Convert.ToSingle(costforlitr.Text)), 3).ToString();

                    }
                }
                else if (comboBox.Text == "Газ")
                {
                    costforlitr.Text = "28,98";
                    if (number.Checked == true)
                    {
                        havetopayoil.Text = (Convert.ToSingle(numberoflitr.Text) * Convert.ToSingle(costforlitr.Text)).ToString();

                    }
                    else
                    {
                        havetopayoil.Text = Math.Round((Convert.ToSingle(numberofsum.Text) / Convert.ToSingle(costforlitr.Text)), 3).ToString();

                    }
                }
            }
            catch(Exception exc)
            {

            }
        }
        void CalculateEatSum()
        {
            try
            {
                float eatmoney = 0;
                if (hot_dog.Checked == true)
                {
                    eatmoney += Convert.ToSingle(cost_hotdog.Text) * Convert.ToInt32(number_hotdog.Text);
                }
                if (hamburger.Checked == true)
                {
                    eatmoney += Convert.ToSingle(cost_hamburg.Text) * Convert.ToInt32(number_hamburg.Text);
                }
                if (potato_free.Checked == true)
                {
                    eatmoney += Convert.ToSingle(cost_potatofree.Text) * Convert.ToInt32(number_potatofree.Text);
                }
                if (Coca_cola.Checked == true)
                {
                    eatmoney += Convert.ToSingle(cost_cola.Text) * Convert.ToInt32(number_cola.Text);
                }
                havetopayeat.Text = eatmoney.ToString();
            }
            catch (Exception exc)
            {

            }
        }
        private void number_hotdog_TextChanged(object sender, EventArgs e)
        {
            CalculateEatSum();
        }

        private void Res_Click(object sender, EventArgs e)
        {
            try
            {
                if (suma.Checked == true)
                {
                    res_cost.Text = (Convert.ToSingle(numberofsum.Text) + Convert.ToSingle(havetopayeat.Text)).ToString();
                }
                else
                    res_cost.Text = (Convert.ToSingle(havetopayoil.Text) + Convert.ToSingle(havetopayeat.Text)).ToString();
                sum_all += Convert.ToSingle(res_cost.Text);
                t.Start();
            }
            catch(Exception exc)
            {

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Виручка: "+ sum_all.ToString()+"грн");
        }
    }
}
