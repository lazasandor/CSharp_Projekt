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
using System.Text.RegularExpressions;

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

        private void UpdateJobsToList()
        {
           var jobs = DataProvider.GetJobs();
           DataGrid.ItemsSource = jobs;
        }

        private void Modify_ButtonClick(object sender, RoutedEventArgs e)
        {
            var jobs = DataProvider.GetJobs();
            foreach (var item in jobs)
            {
                if (item.Id == long.Parse(ID.Text))
                {
                    if (ValidateJob())
                    {
                        item.Customer = FullName.Text;
                        item.CarType = CarType.Text;
                        item.LicensePlateNumber = RegNumber.Text;
                        item.Description = TechnicalFailureDesc.Text;
                        item.Status = ComboBox.Text;
                        item.Date = DateTime.Now;

                        DataProvider.UpdateJob(item);
                    }
                }
            }
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
            UpdateJobsToList();
        }

        private bool ValidateJob()
        {
            if (string.IsNullOrEmpty(FullName.Text))
            {
                MessageBox.Show("A név mező nem lehet üres!");
                return false;
            }
            else if (!Regex.Match(FullName.Text, "^[a-zA-Z]{4,}(?: [a-zA-Z]+){0,2}$").Success)
            {
                MessageBox.Show("Megadott név formátuma nem megfelelő!");
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

            if (!Regex.Match(RegNumber.Text, "^[A-Z]{3}-[0-9]{3}$").Success && !Regex.Match(RegNumber.Text, "^[A-Z]{2} [A-Z]{2}-[0-9]{3}$").Success)
            {
                MessageBox.Show("Elfogadott rendszám formátum: XXX-123 vagy XX XX-123!");
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

        private void OfficeClientJobList_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateJobsToList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedJob = DataGrid.SelectedItem as Job;
            
            if (selectedJob != null)
            {
                ID.Text = selectedJob.Id.ToString();
                FullName.Text = selectedJob.Customer;
                CarType.Text = selectedJob.CarType;
                RegNumber.Text = selectedJob.LicensePlateNumber;
                TechnicalFailureDesc.Text = selectedJob.Description;
                ComboBox.Text = selectedJob.Status;
            }
        }

    }
}
