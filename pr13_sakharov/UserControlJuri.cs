using pr13_sakharov.DBCon;
using System.Windows.Forms;

namespace pr13_sakharov
{
    public partial class UserControlJuri : UserControl
    {
        public UserControlJuri()
        {
            InitializeComponent();
        }
        public void Fill(User user, int number)
        {
            labelName.Text = "Жюри - " + number.ToString();
            userBindingSource.DataSource = user;
        }
    }
}
