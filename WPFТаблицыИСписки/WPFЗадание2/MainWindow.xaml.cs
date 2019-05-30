using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFЗадание2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        class Person
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public Person[] Employes { get; set; }
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            lbListBoxMain.ItemsSource = new Person[] { 
                new Person() { LastName = "Иванов" , FirstName = "Иван",
                Employes = new[] {new Person(){LastName = "Алексеев" , FirstName = "Алексей"}}},
                new Person() { LastName = "Петров" , FirstName = "Петр",
                Employes = new[] {new Person(){LastName = "Федоров" , FirstName = "Федр"},
                    new Person(){LastName = "Маринина" , FirstName = "Марина"}}}
            };
        }
    }
}
