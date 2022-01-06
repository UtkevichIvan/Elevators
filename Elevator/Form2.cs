using System;
using System.Windows.Forms;

namespace Elevator
{
    public partial class Form2 : Form
    {
        ToolStripLabel timeLabel;
        ToolStripLabel transportationLabel;
        ToolStripLabel textLabel;
        DateTime dateTime;
        Form1 parentForm;
        bool fireAlarm = false;
        protected Building building;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1, Building building, int spawnRate)
        {
            InitializeComponent();
            this.building = building;
            parentForm = form1;
            transportationLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            textLabel = new ToolStripLabel();
            textLabel.Text = "number of people transported";
            transportationLabel.Text = "0";
            dateTime = new DateTime(0, 0);
            timerTime.Enabled = true;
            timeLabel.Text = dateTime.ToString("HH:mm:ss");
            statusBar.Items.Add(timeLabel);
            statusBar.Items.Add(textLabel);
            statusBar.Items.Add(transportationLabel);
            timerRefresh.Enabled = true;
            timerTime.Enabled = true;
            timerSpawn.Interval = 60000 / spawnRate;
            timerSpawn.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int xButton = 282;
            int temp = xButton;
            int yButton = 662;
            int xLabel = 191;
            int yLabel = 662;
            timerSpeed.Interval = 750;
            timerSpeed.Enabled = true;
            timerDelete.Enabled = true;
            for (int i = 0; i < building.getAmountFloors(); i++)
            {
                Label label = new Label();
                label.Location = new System.Drawing.Point(xLabel, yLabel);
                label.Name = "labelFloor" + i.ToString() + "People";  
                label.AutoSize = true;
                yLabel -= 570 / building.getAmountFloors();
                this.Controls.Add(label);
                for (int j = 0; j < building.getAmountElevators(); j++)
                {
                    CheckBox check = new CheckBox();
                    check.Appearance = System.Windows.Forms.Appearance.Button;
                    check.Text = "     ";
                    check.AutoSize = true;
                    check.Location = new System.Drawing.Point(temp, yButton);
                    check.Name = "radioFloor" + i.ToString() + "Elevator" + j.ToString() + "Status";
                    temp += 1100 / building.getAmountElevators();
                    this.Controls.Add(check);
                }
                temp = xButton;
                yButton -= 570 / building.getAmountFloors();

            }
            for (int i = 0; i < building.getAmountElevators(); i++)
            {
                Label label = new Label();
                label.Location = new System.Drawing.Point(xButton, yButton);
                label.Name = "labelElevator" + i.ToString() + "People";
                label.AutoSize = true;
                xButton += 1100 / building.getAmountElevators();
                this.Controls.Add(label);
            }
        }

        private void listBoxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person person = (Person)listBoxPerson.SelectedItem;
            if (person != null)
            {
                MessageBox.Show("Spawn Floor : " + person.getSpawnFloor().ToString() + "\n"
                + "Target Floor : " + person.getTargetFloor().ToString() + "\n"
                + "Status : " + person.getStatus().ToString());
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < building.getAmountFloors(); i++)
            {
                this.Controls["labelFloor" + i.ToString() + "People"].Text = building.GetFloor(i).getWaitingPeople().ToString() + " / " + building.GetFloor(i).getArrivedPeople().ToString();
                for (int j = 0; j < building.getAmountElevators(); j++)
                {
                    if (building.GetElevator(j).getCurrentFloor() == i)
                    {
                        ((CheckBox)this.Controls["radioFloor" + i.ToString() + "Elevator" + j.ToString() + "Status"]).Checked = true;
                    }
                    else
                    {
                        ((CheckBox)this.Controls["radioFloor" + i.ToString() + "Elevator" + j.ToString() + "Status"]).Checked = false;
                    }
                }

            }
            for (int i = 0; i < building.getAmountElevators(); i++)
            {
                this.Controls["labelElevator" + i.ToString() + "People"].Text = building.GetElevator(i).getPeople().Count.ToString();
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            dateTime = dateTime.AddSeconds(1);
            timeLabel.Text = dateTime.ToString("HH:mm:ss");
        }

        private void timerSpeed_Tick(object sender, EventArgs e)
        {
            building.act();
        }

        private void timerDelete_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < building.getAmountFloors(); i++)
            {
                for (int j = 0; j < building.GetFloor(i).getPeople().Count; j++)
                {
                    if (building.GetFloor(i).getPeople()[j].getStatus() == PersonStatus.ARRIVED || building.GetFloor(i).getPeople()[j].getStatus() == PersonStatus.PANIC)
                    {
                        listBoxPerson.Items.Remove(building.GetFloor(i).getPeople()[j]);
                        building.GetFloor(i).getPeople().RemoveAt(j);
                        j--;
                    }
                }
            }
        }

        private void timerSpawn_Tick(object sender, EventArgs e)
        {
            Random x = new Random(); // объявление переменной для генерации чисел
            int spawnFloor = x.Next(0, building.getAmountFloors());
            int targetFloor = x.Next(0, building.getAmountFloors());
            while (spawnFloor == targetFloor)
            {
                spawnFloor = x.Next(0, building.getAmountFloors());
                targetFloor = x.Next(0, building.getAmountFloors());
            }
            string[] names = new string[] { "Vanya" , "Sanya", "Der Denis", "Timofey", "GayOrgiy"};
            Person person = new Person(names[x.Next(0, 5)], spawnFloor, targetFloor);
            building.spawnPerson(person);
            listBoxPerson.Items.Add(person);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            parentForm.Visible = true;
            this.Close();
            int[] deliveredPeople = new int[building.getAmountElevators()];
            for (int i = 0; i < building.getAmountElevators(); i++)
            {
                deliveredPeople[i] = building.GetElevator(i).getDelivered();
            }
            Form3 newForm = new Form3(deliveredPeople, dateTime);
            newForm.Show();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int targetFloor = Convert.ToInt32(textBoxTarget.Text);
            int currentFloor = Convert.ToInt32(textBoxСurrent.Text);
            Person person = new Person(name, currentFloor, targetFloor);
            building.spawnPerson(person);
            listBoxPerson.Items.Add(person);
        }

        private void buttonSlower_Click(object sender, EventArgs e)
        {
            timerSpeed.Interval = (int)(timerSpeed.Interval * 1.2);
            timerTime.Interval = (int)(timerTime.Interval * 1.2);
        }

        private void buttonFaster_Click(object sender, EventArgs e)
        {
            timerSpeed.Interval = (int)(timerSpeed.Interval / 1.2);
            timerTime.Interval = (int)(timerTime.Interval / 1.2);
        }

        private void buttonFire_Click(object sender, EventArgs e)
        {
            if (fireAlarm == false)
            {
                building.activateFireAlarm();
                fireAlarm = true;
                timerSpawn.Enabled = false;
            }
            else
            {
                fireAlarm = false;
                timerSpawn.Enabled = true;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (timerDelete.Enabled == false)
            {
                timerDelete.Enabled = true;
                timerRefresh.Enabled = true;
                timerSpawn.Enabled = true;
                timerSpeed.Enabled = true;
                timerTime.Enabled = true;
            }
            else
            {
                timerDelete.Enabled = false;
                timerRefresh.Enabled = false;
                timerSpawn.Enabled = false;
                timerSpeed.Enabled = false;
                timerTime.Enabled = false;
            }
        }
    }
}
