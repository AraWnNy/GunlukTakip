using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        EventManager eventManager;
        ScheduleManager scheduleManager;
        public Form1()
        {
            InitializeComponent();
            eventManager = new EventManager(new EfEventDal());
            scheduleManager = new ScheduleManager(new EfScheduleDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDGW();
            SetComboBox();
        }

        public void SetDGW()
        {
            dgw.Rows.Clear();
            var res = scheduleManager.GetDetails();
            foreach (var item in res.Data)
            {
                dgw.Rows.Add(item.Id, item.EventName, item.Date, item.Success);
            }
        }
        public void SetComboBox()
        {
            cmbx.Items.Clear();
            var res = eventManager.GetAll();
            if (res.Data.Count > 0)
            {
                foreach (var item in res.Data)
                {
                    cmbx.Items.Add(item.EventName);
                }
                cmbx.Text = (string)cmbx.Items[0];
            }

        }

        private void eventAdd_Click(object sender, EventArgs e)
        {
            if (eventTxt.Text != "")
            {
                eventManager.Add(new Event
                {
                    EventName = eventTxt.Text
                });

                SetComboBox();
                eventTxt.Text = "";
            }
            else
            {
                MessageBox.Show("İsim alanı boş bırakılamaz.");
            }
        }

        private void eventUpdate_Click(object sender, EventArgs e)
        {
            var updatedEvent = eventManager.GetSingleObjectByName(cmbx.SelectedItem.ToString()).Data;
            if (updatedEvent != null)
            {
                eventManager.Update(new Event
                {
                    Id = updatedEvent.Id,
                    EventName = eventTxt.Text
                });
            }
            else
            {
                MessageBox.Show("Veri bulunamadı");
            }
            cmbx.SelectedItem = eventTxt.Text;
            eventTxt.Text = "";
            SetComboBox();
        }
        private void eventDelete_Click(object sender, EventArgs e)
        {
            var updatedEvent = eventManager.GetSingleObjectByName(cmbx.SelectedItem.ToString()).Data;
            if (updatedEvent != null && cmbx.Text != "")
            {
                eventManager.Delete(updatedEvent);
            }
            else
            {
                MessageBox.Show("Veri bulunamadı");
            }
            eventTxt.Text = "";
            cmbx.Text = "";
            SetComboBox();
        }

        private void scheduleAdd_Click(object sender, EventArgs e)
        {
            var addedSchedule = scheduleManager.Add(new Schedule
            {
                Date = DateTime.Now,
                EventId = eventManager.GetSingleObjectByName(cmbx.SelectedItem.ToString()).Data.Id,
                EventStatus = isSuccess.Checked
            });

            isSuccess.Checked = false;
            SetDGW();
        }

        private void scheduleUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dgw.CurrentRow;
            if (selectedRow != null)
            {
                var updatedSchedule = new Schedule
                {
                    Id = (int)selectedRow.Cells[0].Value,
                    Date = (DateTime)selectedRow.Cells[2].Value,
                    EventStatus = isSuccess.Checked,
                    EventId = eventManager.GetSingleObjectByName(cmbx.SelectedItem.ToString()).Data.Id
                };

                scheduleManager.Update(updatedSchedule);

                isSuccess.Checked = false;
                SetDGW();
            }
            else
            {
                MessageBox.Show("Satır seçmeniz gerekir.");
            }

        }

        private void dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgw.CurrentRow;
            cmbx.SelectedItem = selectedRow.Cells[1].Value.ToString();
            isSuccess.Checked = (bool)selectedRow.Cells[3].Value;
        }

        private void scheduleDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dgw.CurrentRow;
            if (selectedRow != null)
            {
                var deletedSchedule = new Schedule
                {
                    Id = (int)selectedRow.Cells[0].Value
                };

                scheduleManager.Delete(deletedSchedule);
                SetDGW();
            }
            else
            {
                MessageBox.Show("Satır seçmeniz gerek");
            }
        }
    }
}
