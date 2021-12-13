using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bron
{
    public partial class BronForm : Form
    {
        public BronForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginu.Text == "")
            {
                MessageBox.Show("Введите имя пользователя!");
                return;
            }

            if (rateu.Text == "")
            {
                MessageBox.Show("Выберите тариф!");
                return;
            }

            if (houru.Text == "")
            {
                MessageBox.Show("Выберите кол-во часов!");
                return;
            }

            if (placeu.Text == "")
            {
                MessageBox.Show("Выберите место!");
                return;
            }

            if (checkl())
                return;

            if (checkp())
                return;
            

            { 
           

                DateBase db = new DateBase();

 

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`nik`, `rate`, `hour`, `place`) VALUES (@lu, @ru, @hu, @pu)", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = loginu.Text;
            command.Parameters.Add("@ru", MySqlDbType.VarChar).Value = rateu.Text;
            command.Parameters.Add("@hu", MySqlDbType.VarChar).Value = houru.Text;
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = placeu.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Бронирование прошло успешно!");
                else
                    MessageBox.Show("Произошла ошибка,проверьте правильность ввёденных данных!");

                db.closeConnection();
            }
    }

        public Boolean checkp()
        {
            DateBase db = new DateBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `place` = @pu ", db.getConnection());
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = placeu.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такое место уже забронированно!");
                return true;
            }

            else
                return false;
        }
        public Boolean checkl()
        {
            DateBase db = new DateBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `nik` = @lu ", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = loginu.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже забронировал место!");
                return true;
            }

            else
                return false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
