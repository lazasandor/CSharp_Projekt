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
using WebApi_Common.Models;
using WebApi_Client_Jobs.DataProviders;

namespace WebApi_Client_Jobs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Job _job;
        public MainWindow()
        {
            _job = new Job();
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Modify_ButtonClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNew_ButtonClick(object sender, RoutedEventArgs e)
        {
            
            if (ValidateJob())
            {
                _job.Customer = FullName.Text;
                _job.CarType = CarType.Text;
                _job.LicensePlateNumber = RegNumber.Text;
                _job.Description = TechnicalFailureDesc.Text;
                _job.Status = ComboBox.Text;
                _job.Date = DateTime.Now;

                DataProvider.CreateJob(_job);

            }
        }

        private bool ValidateJob()
        {
            if (string.IsNullOrEmpty(FullName.Text))
            {
                MessageBox.Show("A név mező nem lehet üres!");
                return false;
            }

            if (string.IsNullOrEmpty(CarType.Text))
            {
                MessageBox.Show("A gépjármű típusa mező nem lehet üres!");
                return false;
            }

            if (string.IsNullOrEmpty(RegNumber.Text))
            {
                MessageBox.Show("A rendszám mező nem lehet üres!");
                return false;
            }

            if (string.IsNullOrEmpty(TechnicalFailureDesc.Text))
            {
                MessageBox.Show("A hiba leírás mező nem lehet üres!");
                return false;
            }

            if (string.IsNullOrEmpty(ComboBox.Text))
            {
                MessageBox.Show("Válasszon ki egy állapotot!");
                return false;
            }

            return true;
        }
    }
}
