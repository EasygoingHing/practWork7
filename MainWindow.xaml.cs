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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Lorry> lorryList = new List<Lorry>();//список грузовиков        

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = 1;
                string brand = tbBrand.Text;
                int power = int.Parse(tbPwr.Text);
                int numberOfCylinders = int.Parse(tbNOC.Text);
                int loadcapasity = int.Parse(tbLoadCapacity.Text);

                Lorry tempCar = new Lorry(brand, numberOfCylinders, power, loadcapasity);
                lorryList.Add(tempCar);

                tbRes.Text = string.Empty;

                foreach (var item in lorryList)
                {
                    tbRes.Text += " Название грузовика номер " + i++ + '-' + item.Brand + '\n' +
                              " Мощность " + item.Power + '\n' +
                              " Кол-во цилиндров " + item.NumberOfCylinders + '\n' +
                              " Грузоподъёмность " + item.Loadcapacity + "\n\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Данные указаны не верно или отсутствуют");
                return;
            }

        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = 1;
                int autoNumber = int.Parse(tbDelete.Text);
                lorryList.Remove(lorryList[autoNumber - 1]);

                tbRes.Text = string.Empty;

                foreach (var item in lorryList)
                {
                    tbRes.Text += " Название грузовика номер " + i++ + '-' + item.Brand + '\n' +
                              " Мощность " + item.Power + '\n' +
                              " Кол-во цилиндров " + item.NumberOfCylinders + '\n' +
                              " Грузоподъёмность " + item.Loadcapacity + "\n\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Данные указаны неверно или объект не создан");
                return;
            }
        }

        private void ButtonChange_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = 1;
                string brand = tbBrand.Text;
                int power = int.Parse(tbPwr.Text);
                int numberOfCylinders = int.Parse(tbNOC.Text);
                int autoNumber = int.Parse(tbDelete.Text);
                int loadcapasity = int.Parse(tbLoadCapacity.Text);

                lorryList[autoNumber - 1].SetParams(numberOfCylinders, power, brand, loadcapasity);

                tbRes.Text = string.Empty;

                foreach (var item in lorryList)
                {
                    tbRes.Text += " Название грузовика номер " + i++ + '-' + item.Brand + '\n' +
                              " Мощность " + item.Power + '\n' +
                              " Кол-во цилиндров " + item.NumberOfCylinders + '\n' +
                              " Грузоподъёмность " + item.Loadcapacity + "\n\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Данные указаны неверно или объект не создан");
                return;
            }
        }

        private void ButtonIncrease(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = 1;
                int autoNumber = int.Parse(tbDelete.Text);

                Lorry tempcar = lorryList[autoNumber - 1]++;

                lorryList[autoNumber - 1] = tempcar;

                tbRes.Clear();

                foreach (var item in lorryList)
                {
                    tbRes.Text += " Название грузовика номер " + i++ + '-' + item.Brand + '\n' +
                              " Мощность " + item.Power + '\n' +
                              " Кол-во цилиндров " + item.NumberOfCylinders + '\n' +
                              " Грузоподъёмность " + item.Loadcapacity + "\n\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Данные указаны неверно или объект не создан");
                return;
            }
        }

        private void ButtonCompare(object sender, RoutedEventArgs e)
        {
            try
            {
                int lorry1 = int.Parse(tbFirstCar.Text);
                int lorry2 = int.Parse(tbSecondCar.Text);

                if (lorryList[lorry1 - 1] > lorryList[lorry2 - 1])
                {
                    tbRes.Text += "Первый грузовик круче\n";
                }
                else if (lorryList[lorry1 - 1] < lorryList[lorry2 - 1])
                {
                    tbRes.Text += "Второй грузовик круче\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Данные указаны не верно или объект не создан");
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Крутолапов Валерий Исп-31 Вариант - 1");
        }
    }
}


