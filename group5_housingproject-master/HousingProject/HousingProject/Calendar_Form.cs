using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingProject
{
    public partial class Calendar_Form : Form
    {

        private List<string> GARBAGE;
        private List<string> CLEANING;
        private List<string> PARTYS;
        private EventTracker EventTrack;
        private Events currentevent;
        private object random;
        Random Room = new Random();

        public Calendar_Form()
        {
            InitializeComponent();

            foreach (string s in Enum.GetNames(typeof(EventsType)))
            {
                cbEvent.Items.Add(s.ToLower());
            }

            EventTrack = new EventTracker();
            GARBAGE = new List<string>();
            CLEANING = new List<string>();
            PARTYS = new List<string>();

        }

        private void Calendar_Form_Load(object sender, EventArgs e)
        {

        }

        private void ShowGarbage()
        {
            this.lbGarbage.Items.Clear();
            foreach (String events in GARBAGE)
            {
                this.lbGarbage.Items.Add(events);

                lbGarbage.Sorted = true;
            }
        }

        private void ShowCleaning()
        {
            this.lbCleaning.Items.Clear();
            foreach (String events in CLEANING)
            {
                this.lbCleaning.Items.Add(events);

                lbCleaning.Sorted = true;
            }
        }

        private void ShowParty()
        {
            this.lbPartys.Items.Clear();
            foreach (String events in PARTYS)
            {
                this.lbPartys.Items.Add(events);

                lbPartys.Sorted = true;
            }
        }

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            tbDate.Text = monthCalendar1.SelectionStart.Day.ToString() + "/" +
            monthCalendar1.SelectionStart.Month.ToString() + "/" +
            monthCalendar1.SelectionStart.Year.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EventsType type = EventsType.Garbage;
            String newevent = this.textBox1.Text;
            String newdate = this.tbDate.Text;
            int num = Room.Next(1, 13);


            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(tbDate.Text))
            {
                MessageBox.Show("Please fill the box");
            }
            else
            {
                if (cbEvent.Text == "garbage")
                {
                    type = EventsType.Garbage;

                    if (GARBAGE.Contains(newevent) && GARBAGE.Contains(newdate))
                    {
                        MessageBox.Show("Event already exist");
                    }
                    else
                    {
                        GARBAGE.Add(newdate
                                        + " - "
                                        + newevent
                                        + " - "
                                        + "Room "
                                        + num);
                        ShowGarbage();
                    }
                }
                if (cbEvent.Text == "cleaning")
                {
                    type = EventsType.Cleaning;
                    if (CLEANING.Contains(newevent) && CLEANING.Contains(newdate))
                    {
                        MessageBox.Show("Event already exist");
                    }
                    else
                    {
                        CLEANING.Add(newdate
                                        + " - "
                                        + newevent
                                        + " - "
                                        + "Room "
                                        + num);
                        ShowCleaning();
                    }
                }
                if (cbEvent.Text == "party")
                {
                    type = EventsType.Party;
                    if (PARTYS.Contains(newevent) && PARTYS.Contains(newdate))
                    {
                        MessageBox.Show("Event already exist");
                    }
                    else
                    {
                        PARTYS.Add(newdate + " - " + newevent);
                        ShowParty();
                    }
                }
            }

            Events even = new Events(type, tbDate.Text, textBox1.Text);
            EventTrack.addEvent(even);
            this.textBox1.Clear();
            this.tbDate.Clear();
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            int g = lbGarbage.SelectedIndex;
            int c = lbCleaning.SelectedIndex;
            int p = lbPartys.SelectedIndex;
            string info1 = EventTrack.getEventInfo(g);
            string info2 = EventTrack.getEventInfo(c);
            string info3 = EventTrack.getEventInfo(p);

            if (string.IsNullOrEmpty(info1))
            {
                if (string.IsNullOrEmpty(info2))
                {
                    if (string.IsNullOrEmpty(info3))
                    {
                        MessageBox.Show("Please select an event");
                    }
                    else
                    {
                        MessageBox.Show(info3);
                    }
                }
                else
                {
                    MessageBox.Show(info2);
                }
            }
            else
            {
                MessageBox.Show(info1);
            }
            lbGarbage.ClearSelected();
            lbCleaning.ClearSelected();
            lbPartys.ClearSelected();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            String oldgarbage = Convert.ToString(lbGarbage.SelectedItem);
            String oldcleaning = Convert.ToString(lbCleaning.SelectedItem);
            String oldparty = Convert.ToString(lbPartys.SelectedItem);

            int g = lbGarbage.SelectedIndex;
            int c = lbCleaning.SelectedIndex;
            int p = lbPartys.SelectedIndex;
            EventTrack.deleteEvent(g);
            EventTrack.deleteEvent(c);
            EventTrack.deleteEvent(p);

            GARBAGE.Remove(oldgarbage);
            CLEANING.Remove(oldcleaning);
            PARTYS.Remove(oldparty);

            lbGarbage.Items.Remove(lbGarbage.SelectedItem);
            lbCleaning.Items.Remove(lbCleaning.SelectedItem);
            lbPartys.Items.Remove(lbPartys.SelectedItem);

            lbGarbage.ClearSelected();
            lbCleaning.ClearSelected();
            lbPartys.ClearSelected();
        }

        private void btnTestParty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Available events: " + PARTYS.Count().ToString());
        }

        private void btnTestCleaning_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Available events: " + CLEANING.Count().ToString());
        }

        private void btnTestGarbage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Available events: " + GARBAGE.Count().ToString());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }
    }
}
