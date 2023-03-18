using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Lab_1.Models;
using Lab_1.Extensions;
namespace Lab_1
{
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
        }
        public static void writebinary(string path, List<PersonVm> person)
        {

            StreamWriter file = new StreamWriter(path);
            person.Sort((a, b) => a.Address.CompareTo(b.Address));

            foreach (PersonVm student in person)
            {
                file.WriteLine(StringExtension.ToString(student));

            }
            file.Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            string path = @"C:\\Users\\Артем\\source\\repos\\2 sem\\Lab_1\INFO.txt";
            List<PersonVm> students = new List<PersonVm>();
            StreamReader file = new StreamReader(path);
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] parts = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                string[] name = parts[1].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                students.Add(new PersonVm { Address = parts[0].Trim(), SecondName = name[0].Trim() });


            }
            textBox3.Clear();
            foreach (PersonVm student in students)
            {
                textBox3.Text += student.Address;
                textBox3.Text += "\t";
                textBox3.Text += student.SecondName;
                textBox3.Text += "\r\n";
            }
            file.Close();
        }
        private void Person_Load(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
