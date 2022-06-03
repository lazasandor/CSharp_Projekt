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
using WebApi_Client_Workshop.DataProviders;
using WebApi_Common.Models;


namespace WebApi_Client_Workshop
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

        public void UpdateJobsToList()
        {
            var jobs = DataProviderWorkshop.GetJobs();
            WorkShop_DataGrid.ItemsSource = jobs;
        }

        private void WorkshopClientJobList_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateJobsToList();
        }

        private void WorkShop_DataGrid_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var selectedJob = WorkShop_DataGrid.SelectedItem as Job;

            if (selectedJob != null)
            {
                var window = new ChangeJobStatusWindow(selectedJob);
                if (window.ShowDialog() ?? false)
                {
                    UpdateJobsToList();
                }
            }

            
            
        }
    }
}
