using System;
using System.Windows.Forms;

namespace Elevator
{
    public partial class Form1 : Form
    {
        protected Building building;
        public Form1()
        {
            InitializeComponent();
            comboBoxStrategy.Items.AddRange(new string[] { "Минимум времени ожидания", "Минимум времени поездки" });
        }

        public Building getBuilding()
        {
            return building;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string averagePeople = textBoxAvrpeople.Text;
            int elevatorsAmount = Convert.ToInt32(textBoxElevators.Text);
            int floorsAmount = Convert.ToInt32(textBoxFloors.Text);
            string strategy = comboBoxStrategy.Text;
            if (strategy == "Минимум времени ожидания")
            {
                building = new Building(floorsAmount, elevatorsAmount, 10, new MinimumWaitingDelayStrategy());
            }
            else
            {
                building = new Building(floorsAmount, elevatorsAmount, 10, new MinMovingTimeStrategy());
            }
            Form2 newForm = new Form2(this, building, Convert.ToInt32(textBoxAvrpeople.Text));
            this.AddOwnedForm(newForm);
            this.Visible = false;
            newForm.Show();
        }

        private void textBoxElevators_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                if (Convert.ToInt32(textBoxElevators.Text) > 5)
                {
                    textBoxElevators.Text = 5.ToString();
                }
                if (Convert.ToInt32(textBoxElevators.Text) < 1)
                {
                    textBoxElevators.Text = 1.ToString();
                }
            }
            catch (FormatException)
            {
                textBoxElevators.Text = "";
            }*/
        }

        private void textBoxFloors_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                if (Convert.ToInt32(textBoxFloors.Text) > 20)
                {
                    textBoxFloors.Text = 20.ToString();
                }
                if (Convert.ToInt32(textBoxFloors.Text) < 2)
                {
                    textBoxFloors.Text = 2.ToString();
                }
            }
            catch (FormatException)
            {
                textBoxFloors.Text = "";
            }*/
        }
    }
}
