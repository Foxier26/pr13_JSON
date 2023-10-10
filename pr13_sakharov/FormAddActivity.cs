using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Text.Json;
using pr13_sakharov.DBCon;

namespace pr13_sakharov
{
    public partial class FormAddActivity : Form
    {
        public FormAddActivity()
        {
            InitializeComponent();
        }
        private List<int> Id_Juri = new List<int>();
        private void addActivityBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(titleTxtBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            try
            {
                Convert.ToInt32(dayTxtBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("В поле день должно быть целое число!");
                return;
            }
            if (Id_Juri.Count <= 0)
            {
                MessageBox.Show("Добавьте хотя бы одного члена жюри!");
                return;
            }
            Activity activity = new Activity();
            activity.Title = titleTxtBox.Text;
            activity.EventPlanID = (int)eventPlanIDCombBox.SelectedValue;
            activity.Day = Convert.ToInt32(dayTxtBox.Text);
            activity.StartedAt = dateTimePicker1.Value.TimeOfDay;
            activity.ModeratorID = (int)moderatorCombBox.SelectedValue;
            activity.GroupsJury = JsonSerializer.Serialize(Id_Juri);

            DBConst.model.Activity.Add(activity);

            try
            {
                DBConst.model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Close();
        }

        private void BackiBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addJuriBtn_Click(object sender, EventArgs e)
        {
            int id = (int)juriCombBox.SelectedValue;
            if (!Id_Juri.Contains(id))
            {
                Id_Juri.Add(id);
                MessageBox.Show($"Пользователь с ID - {juriCombBox.SelectedValue} добавлен!");
                return;
            }
            MessageBox.Show("");
        }

        private void FormAddActivity_Load(object sender, EventArgs e)
        {
            eventBindingSource.DataSource = DBConst.model.Event.ToList();
            usersBindingSource.DataSource = DBConst.model.User.Where(x => x.RoleID == 1).ToList();
            usersBindingSource2.DataSource = DBConst.model.User.Where(x => x.RoleID == 2).ToList();
        }
    }
}
