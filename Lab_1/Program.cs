using System.Collections.Generic;
using System.Windows.Forms;
using Lab_1.Models;
namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Person myForm = new Person();
            var per = new List<PersonVm>() { new PersonVm("Artem", "Vorobiov", "11111", "Instytutska"),
                                            new PersonVm("Perseus", "Smith", "154689", "Volodymyrska"),
                                            new PersonVm("Barrett", "Ramirez", "698451", "Hrinchenko 34"),
                                            new PersonVm("Clark", "Barnes", "3658741", "Shota Rustaveli"),
                                            new PersonVm("Gunner", "Murphy", "475112", "Solomyanska")};
            string path = @"C:\\Users\\Артем\\source\\repos\\2 sem\\Lab_1\INFO.txt";
            Person.writebinary(path, per);
            myForm.Show();

            Application.Run();


        }
    }
}
