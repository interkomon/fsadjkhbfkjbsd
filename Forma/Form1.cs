using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using pract14;


namespace Forma
{
    public partial class Form1 : Form
    {
       private  List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

          
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button4.Visible = true;
            //Regex regex1 = new Regex("^[а-яА-Я]");
            //Regex regex12 = new Regex("^[А-Я]{1}[0-9]{3}[А-Я]{2}[0-9]{2,3}");
            //Regex regex2 = new Regex("^[0-9]");
            //if (tabControl3.SelectedIndex == 0)
            //{

            //    string number = textBox1.Text;
            //    string brand = textBox2.Text;
            //    string color = textBox3.Text;
            //    int mileage = int.Parse(textBox4.Text);
            //    string owner = textBox5.Text;
            //    if (!regex12.IsMatch(textBox1.Text))
            //    {
            //        MessageBox.Show("Введен неверный номер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    if(!regex1.IsMatch(textBox2.Text))
            //    {
            //        MessageBox.Show("Бренд состоит из букв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    if(!regex1.IsMatch(textBox3.Text))
            //    {
            //        MessageBox.Show("Цвет состоит из букв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    if(!regex2.IsMatch(textBox4.Text))
            //    {
            //        MessageBox.Show("Пробег состоит из цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    if(!regex1.IsMatch(textBox5.Text))
            //    {
            //        MessageBox.Show("Владелец состоит из букв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox4.Text.ToString() == "")
            //    {
            //        MessageBox.Show("Введите все значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        DateTime proverkacardata = dateTimePicker1.Value;
            //        PersonalCar personalCar = new PersonalCar(number, brand, color, mileage, owner, proverkacardata);
            //        cars.Add(personalCar);
            //    }
            //}
            //else if(tabControl3.SelectedIndex == 1)
            //{
            //    string number = textBox13.Text;
            //    string brand = textBox14.Text;
            //    string color = textBox15.Text;
            //    int mileage = int.Parse(textBox16.Text);
            //    string companyName = textBox18.Text;
            //    if(!regex12.IsMatch(textBox13.Text))
            //    {
            //        MessageBox.Show("Введен неверный номер", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //    else
            //    if(!regex1.IsMatch(textBox14.Text))
            //    {
            //        MessageBox.Show("Бренд состоит из букв", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //    else
            //    if(!regex1.IsMatch(textBox15.Text))
            //    {
            //        MessageBox.Show("Цвет состоит из букв", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    if (!regex2.IsMatch(textBox16.Text))
            //    {
            //        MessageBox.Show("Пробег состоит из цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    if (!regex1.IsMatch(textBox18.Text))
            //    {
            //        MessageBox.Show("Название компании состоит из букв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    if (textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox18.Text == "" || textBox16.Text.ToString() == "")
            //    {
            //        MessageBox.Show("Введите все значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        CompanyCar companyCar = new CompanyCar(number, brand, color, mileage, companyName);
            //        cars.Add(companyCar);
            //    }

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Regex regex1 = new Regex("^[а-яА-Я]");
            Regex regex12 = new Regex("^[А-Я]{1}[0-9]{3}[А-Я]{2}[0-9]{2,3}");
            Regex regex2 = new Regex("^[0-9]");
            if (tabControl3.SelectedIndex == 0)
            {

                string number = textBox1.Text;
                string brand = textBox2.Text;
                string color = textBox3.Text;
                int mileage = int.Parse(textBox4.Text);
                string owner = textBox5.Text;
                if (!regex12.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("Введен неверный номер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (!regex1.IsMatch(textBox2.Text))
                {
                    MessageBox.Show("Бренд состоит из букв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (!regex1.IsMatch(textBox3.Text))
                {
                    MessageBox.Show("Цвет состоит из букв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (!regex2.IsMatch(textBox4.Text))
                {
                    MessageBox.Show("Пробег состоит из цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (!regex1.IsMatch(textBox5.Text))
                {
                    MessageBox.Show("Владелец состоит из букв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox4.Text.ToString() == "")
                {
                    MessageBox.Show("Введите все значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DateTime proverkacardata = dateTimePicker1.Value;
                    PersonalCar personalCar = new PersonalCar(number, brand, color, mileage, owner, proverkacardata);
                    cars.Add(personalCar);
                }
                StreamWriter sw = File.AppendText("carss.txt");
                foreach (var car in cars)
                {
                    sw.WriteLine(car.info());
                }
                sw.Close();
                button3.Visible = true;
               
            }
            else if(tabControl3.SelectedIndex == 1)
                {
                 string number = textBox13.Text;
                string brand = textBox14.Text;
                string color = textBox15.Text;
                int mileage = int.Parse(textBox16.Text);
                string companyName = textBox18.Text;
                if (!regex12.IsMatch(textBox13.Text))
                {
                    MessageBox.Show("Введен неверный номер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (!regex1.IsMatch(textBox14.Text))
                {
                    MessageBox.Show("Бренд состоит из букв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (!regex1.IsMatch(textBox15.Text))
                {
                    MessageBox.Show("Цвет состоит из букв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (!regex2.IsMatch(textBox16.Text))
                {
                    MessageBox.Show("Пробег состоит из цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (!regex1.IsMatch(textBox18.Text))
                {
                    MessageBox.Show("Название компании состоит из букв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox18.Text == "" || textBox16.Text.ToString() == "")
                {
                    MessageBox.Show("Введите все значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 else
                {
                    DateTime proverkacardata = dateTimePicker1.Value;
                    CompanyCar companyCar = new CompanyCar(number, brand, color, mileage,companyName);
                    cars.Add(companyCar);
                }
                {
                    StreamWriter sw = File.AppendText("carss1.txt");
                    foreach (var car in cars)
                    {
                        sw.WriteLine(car.info());
                    }
                    sw.Close();
                    button3.Visible = true;
                }
              

            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            
           
            
            StreamReader sr = new StreamReader("carss.txt");
            listBox1.Items.Clear();
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                listBox1.Items.Add(line);
            }
            sr.Close();
            


        }

      

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
           
          

            listBox1.Visible = true;
            string[] lines = File.ReadAllLines("carss.txt");
            foreach(var line in lines)
            {
                string[] words = Regex.Split(line, @"[\p{P}\P{S}\s]+");
                if(words.Length >= 4)
                {
                    listBox1.Items.Add($"{words[0]}{words[1]}{words[2]}{words[3]}{words[4]}");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Номер");
            dt.Columns.Add("Марка");
            dt.Columns.Add("Цвет");
            dt.Columns.Add("Пробег");
            dt.Columns.Add("Владелец");
            dt.Columns.Add("Дата техосмотра");
            dt.Columns.Add("Название фирмы");
            string[] lines = File.ReadAllLines("carss.txt");
            foreach (string line in lines)
            {
                //string[] values = line.Split(' ');
                //DataRow row = dt.NewRow();
                //row["Номер"] = values[1];
                //row["Марка"] = values[3];
                //row["Цвет"] = values[5];
                //row["Пробег"] = values[7];
                //row["Владелец"] = values[9];
                //row["Дата техосмотра"] = values[11] + " " + values[12];
                //if (values.Length > 13 && values[13] == "Название" && values[14] == "фирмы")
                //{
                //    row["Название фирмы"] = values.Length > 15 ? values[15] : "";
                //}
                //else
                //{
                //    row["Название фирмы"] = "";
                //}
                //dt.Rows.Add(row);

            }
            //dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string search = textBox6.Text.Trim();
            if(string.IsNullOrWhiteSpace(search))
            {
                MessageBox.Show("Введиет запрос", "Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(search))
                    {
                        row.Selected = true;
                        found = true;
                        break;

                    }
                }
                if(found)
                {
                    break;
                }
                
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int del = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(del);
            List<string> lines = File.ReadAllLines("carss.txt").ToList();
            lines.RemoveAt(del);
            File.WriteAllLines("carss.txt", lines);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        public void VivodPersonal()
        {
            StreamReader sr = new StreamReader("carss.txt");
            while(!sr.EndOfStream)
            {
                string poisk = sr.ReadLine();
                string[] poiskk = poisk.Split(' ');
                dataGridView1.Rows.Add(poiskk[1], poiskk[3], poiskk[5], poiskk[7], poiskk[9], poiskk[12]);
            }
            sr.Close();


        }
        public void VivodCompany()
        {
            StreamReader sr = new StreamReader("carss1.txt");
            while (!sr.EndOfStream)
            {
                string poisk = sr.ReadLine();
                string[] poiskk = poisk.Split(' ');
                dataGridView1.Rows.Add(poiskk[1], poiskk[3], poiskk[5], poiskk[7], poiskk[10]);
            }
            sr.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if(comboBox1.Text == "Личные")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Номер", "Номер");
                dataGridView1.Columns.Add("Марка", "Марка");
                dataGridView1.Columns.Add("Цвет", "Цвет");
                dataGridView1.Columns.Add("Пробег", "Пробег");
                dataGridView1.Columns.Add("Владелец", "Владелец");
                dataGridView1.Columns.Add("Дата техосмотра", "Дата техосмотра");
                VivodPersonal();
            }  
                else if(comboBox1.Text =="Фирма")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Номер", "Номер");
                dataGridView1.Columns.Add("Марка", "Марка");
                dataGridView1.Columns.Add("Цвет", "Цвет");
                dataGridView1.Columns.Add("Пробег", "Пробег");
                dataGridView1.Columns.Add("Название фирмы", "Название фирмы");
                VivodCompany();


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("carss1.txt");
            listBox1.Items.Clear();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                listBox1.Items.Add(line);
            }
            sr.Close();
        }
    }
}
