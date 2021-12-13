using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bron
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginuser.Text == "")
            {
                MessageBox.Show("Введите имя пользователя!");
                return;
            }

            if (passuser.Text == "")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            if (checklog())
                return;

            DateBase db = new DateBase();


            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`nik`, `rate`, `hour`, `place`) VALUES (@lu, @ru, @hu, @pu)", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = loginuser.Text;
            command.Parameters.Add("@ru", MySqlDbType.VarChar).Value = passuser.Text;
          

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Вы успешно зарегистрировались!");
            else
                MessageBox.Show("Произошла ошибка,проверьте правильность ввёденных данных!");

            db.closeConnection();
        }
        public Boolean checklog()
        {
            DateBase db = new DateBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `place` = @pu ", db.getConnection());
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = loginuser.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такое имя пользователя уже занято!");
                return true;
            }

            else
                return false;
        }

        private void loginuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void passuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }
    }

}
