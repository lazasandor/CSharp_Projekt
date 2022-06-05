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
    
    public partial class MainWindow : Window
    {
        

        private long _selectedJobId;

        public List<Job> jobs { get; set; } = (List<Job>)DataProvider.GetJobs();

        private readonly Job _job;
        public MainWindow()
        {
           
            _job = new Job();
            InitializeComponent();
            ComboBox.Text = "Felvett munka";
        }

        private void UpdateJobsToList()
        {
           var jobs = DataProvider.GetJobs();
           DataGrid.ItemsSource = jobs;    
        }

        private void Modify_ButtonClick(object sender, RoutedEventArgs e)
        {
            

            using (var context = new WebApi_Server.Repositories.JobContext())
            {
                var entity = context.Jobs.FirstOrDefault(item => item.Id == _selectedJobId);
                if (entity != null)
                {

                    if (!CustomerNameValidation(FullName.Text) || !LicensePlateNumberValidation(RegNumber.Text,true) || !OtherValidations())
                    {
                        return;
                    }

                    if (ComboBox.Text.Equals("Befejezett munka"))
                    {
                        MessageBoxResult msgBoxResult = MessageBox.Show("A befejezett munka állapot kiválasztása után\na munka törlődik!\nBiztosan törli?",
                        "Igen",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Warning,
                        MessageBoxResult.No
                        );
                        if (msgBoxResult == MessageBoxResult.Yes)
                        {
                            DataProvider.DeleteJob(entity.Id);
                        }
                        UpdateJobsToList();
                        return;
                    }

                    entity.Customer = FullName.Text;
                        entity.CarType = CarType.Text;
                        entity.LicensePlateNumber = RegNumber.Text;
                        entity.Description = TechnicalFailureDesc.Text;
                        entity.Status = ComboBox.Text;
                        context.SaveChanges();
                        MessageBox.Show("Munka sikeresen módosítva!");
                    
                    
                }
                else
                {
                    MessageBox.Show("Válasszon ki munkát a módosításhoz!");
                }
            }
            UpdateJobsToList();
            ClearTexts();
        }

        private void AddNew_ButtonClick(object sender, RoutedEventArgs e)
        {
            if (!CustomerNameValidation(FullName.Text) || !LicensePlateNumberValidation(RegNumber.Text,false) || !OtherValidations())
            {
                return;
            }    

         _job.Customer = FullName.Text;
         _job.CarType = CarType.Text;
         _job.LicensePlateNumber = RegNumber.Text;
         _job.Description = TechnicalFailureDesc.Text;
         _job.Status = ComboBox.Text;
         _job.Date = DateTime.Now;

         DataProvider.CreateJob(_job);
         MessageBox.Show("Munka sikeresen felvételre került!");
            
            
         UpdateJobsToList();
         ClearTexts();
        }

        public bool LicensePlateNumberValidation(string licensePlateNumber, bool isValidationForModify)
        {
            if (string.IsNullOrEmpty(licensePlateNumber))
            {
                MessageBox.Show("A rendszám mező nem lehet üres!");
                return false;
            }
            if (!Regex.Match(licensePlateNumber, "^[A-Z]{3}-[0-9]{3}$").Success)
            {
                MessageBox.Show("Helytelen rendszám!\nElfogadott rendszám formátum: XXX-123!");
                return false;
            }
            if (IsLicensePlateNumberExists(licensePlateNumber))
            {
                if (isValidationForModify)
                {
                    return true;
                }
                MessageBox.Show("Ez a rendszám már szerepel az adatbázisban!");
                return false;
            }

            return true;
        }

        public bool CustomerNameValidation(string customerName)
        {
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("A név mező nem lehet üres!");
                return false;
            }
            if (!Regex.Match(customerName, "^[a-zA-Z]{4,}(?: [a-zA-Z]+){0,2}$").Success)
            {
                MessageBox.Show("Megadott név formátuma nem megfelelő!");
                return false;
            }
            
            return true;
        }

        private bool OtherValidations()
        {
            if (string.IsNullOrEmpty(ComboBox.Text))
            {
                MessageBox.Show("Válasszon ki egy állapotot!");
                return false;
            }
            if (string.IsNullOrEmpty(TechnicalFailureDesc.Text))
            {
                MessageBox.Show("A hiba leírás mező nem lehet üres!");
                return false;
            }
            if (string.IsNullOrEmpty(CarType.Text))
            {
                MessageBox.Show("A gépjármű típusa mező nem lehet üres!");
                return false;
            }
            if (!Regex.Match(CarType.Text, "^[a-zA-Z]{2,}(?: [a-zA-Z]+){0,2}$").Success)
            {
                MessageBox.Show("Megadott gépjármű név formátuma nem megfelelő!");
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
                FullName.Text = selectedJob.Customer;
                CarType.Text = selectedJob.CarType;
                RegNumber.Text = selectedJob.LicensePlateNumber;
                TechnicalFailureDesc.Text = selectedJob.Description;
                ComboBox.Text = selectedJob.Status;
                _selectedJobId = selectedJob.Id;
            }
        }

        private void ClearTexts()
        {
            FullName.Text = "";
            CarType.Text = "";
            RegNumber.Text = "";
            TechnicalFailureDesc.Text = "";
            ComboBox.Text = "Felvett munka";
        }

        private bool IsLicensePlateNumberExists(string plateNumber)
        {
            var jobs = DataProvider.GetJobs();

            foreach (var job in jobs)
            {
                if (job.LicensePlateNumber.Equals(plateNumber))
                {
                    return true;
                }
            }
            return false;
        }

        public void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void TrayButton_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

        private void WindowBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
