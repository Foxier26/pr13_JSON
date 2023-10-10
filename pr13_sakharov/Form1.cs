using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Text.Json;
using pr13_sakharov.DBCon;

namespace pr13_sakharov
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static List<int> JuriList;

        private void MainForm_Load(object sender, EventArgs e)
        {
            activityBindingSource.DataSource = DBConst.model.Activity.ToList();
        }

        private void ShowJuriBtn_Click(object sender, EventArgs e)
        {
            JuriList = new List<int>();
            //if )
            //{

            //}
            //else
            //{
                JuriList = JsonSerializer.Deserialize<List<int>>
                (activityDataGridView.CurrentRow.Cells[6].Value.ToString());
                FormShowJuri formShowJuri = new FormShowJuri();
                formShowJuri.ShowDialog();
            //}
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FormAddActivity activity = new FormAddActivity();
            activity.ShowDialog();
            activityBindingSource.DataSource = DBConst.model.Activity.ToList();
        }
    }
}
