using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zvonkov28._12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа, каждое с новой строки (для выхода введите 'done'):");

            int maxNumber = int.MinValue;
            string input = Console.ReadLine();

            while (input != "done")
            {
                int number = int.Parse(input);

                if (number > maxNumber)
                {
                    maxNumber = number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Максимальное число: {maxNumber}");
        }
    }

}
}
