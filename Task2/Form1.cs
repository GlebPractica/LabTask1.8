using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        private VehiclePlane vehiclePlane;
        private VehicleTrain vehicleTrain;
        private VehicleCar vehicleCar;

        private float distance;

        public Form1()
        {
            InitializeComponent();
            vehicleCar = new VehicleCar();
            vehicleTrain = new VehicleTrain();
            vehiclePlane = new VehiclePlane();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(vehicleCar.AddSpeedKMH(float.Parse(textBox1.Text)));
                MessageBox.Show(vehicleCar.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BttnEnterValues_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (float.TryParse(textBox1.Text, out float speed) && speed > 0)
            {
                if (float.TryParse(textBox2.Text, out float price) && price >= 0)
                {
                    if (float.TryParse(textBox3.Text, out distance) && distance > 0)
                    {
                        if (radioButton1.Checked)
                        {
                            listBox1.Items.Add(vehiclePlane.AddSpeedKMH(speed));
                            listBox1.Items.Add(vehiclePlane.AddPriceFor1KM(price));
                        }
                        else if (radioButton2.Checked)
                        {
                            listBox1.Items.Add(vehicleTrain.AddSpeedKMH(speed));
                            listBox1.Items.Add(vehicleTrain.AddPriceFor1KM(price));
                        }
                        else if (radioButton3.Checked)
                        {
                            listBox1.Items.Add(vehicleCar.AddSpeedKMH(speed));
                            listBox1.Items.Add(vehicleCar.AddPriceFor1KM(price));
                        }

                        listBox1.Items.Add($"Расстояние было задано: {distance}");
                    }
                    else
                    {
                        listBox1.Items.Add("Похоже вы неверно ввели дистанцию. Повторите попытку.");
                        listBox1.Items.Add($"Текущий результат: {price}.");
                    }
                }
                else
                {
                    listBox1.Items.Add("Похоже вы неверно ввели цену за 1 км пути. Повторите попытку.");
                    listBox1.Items.Add($"Текущий результат: {price}.");
                }
            }
            else
            {
                listBox1.Items.Add("Похоже вы неверно ввели скорость. Повторите попытку.");
                listBox1.Items.Add($"Текущий результат: {speed}.");
            }

        }

        private void BttnAboutPlane_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(vehiclePlane.ToString());
        }

        private void BttnAboutTrain_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(vehicleTrain.ToString());
        }

        private void BttnAboutCar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(vehicleCar.ToString());
        }

        private void BttnCalcTime_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    listBox1.Items.Add("Время прибытия: " + GetTime(vehiclePlane.GetTimeDelivery(distance)));
                }
                else if (radioButton2.Checked)
                {
                    listBox1.Items.Add("Время прибытия: " + GetTime(vehicleTrain.GetTimeDelivery(distance)));
                }
                else if (radioButton3.Checked)
                {
                    listBox1.Items.Add("Время прибытия: " + GetTime(vehicleCar.GetTimeDelivery(distance)));
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void BttnCalcPrice_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    listBox1.Items.Add("Цена за доставку: " + vehiclePlane.GetFullPrice(distance).ToString("0.00") + " у.е");
                }
                else if (radioButton2.Checked)
                {
                    listBox1.Items.Add("Цена за доставку: " + vehicleTrain.GetFullPrice(distance).ToString("0.00") + " у.е");
                }
                else if (radioButton3.Checked)
                {
                    listBox1.Items.Add("Цена за доставку: " + vehicleCar.GetFullPrice(distance).ToString("0.00") + " у.е");
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private string GetTime(float time)
        {
            if (time > 0)
            {
                int hours = (int)time;
                int minutes = (int)((time - hours) * 60);

                return $"{hours} ч. {minutes} мин.";
            }

            return $"Unkown";
        }
    }
}
