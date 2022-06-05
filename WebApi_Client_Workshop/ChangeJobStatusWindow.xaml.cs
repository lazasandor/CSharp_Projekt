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
using System.Windows.Shapes;
using WebApi_Common.Models;

namespace WebApi_Client_Workshop
{
    /// <summary>
    /// Interaction logic for ChangeJobStatusWindow.xaml
    /// </summary>
    public partial class ChangeJobStatusWindow : Window
    {
        private string _status;
        private Job _job;
        public ChangeJobStatusWindow(Job job)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            InitializeComponent();

            if (job != null)
            {
                _job = job;
            }
        }

        private void JobStatusNew_ButtonClick(object sender, RoutedEventArgs e)
        {
            _status = "Felvett munka";
            ChangeStatusToSelected(_job);
            DialogResult = true;
            Close();

        }
        private void JobStatusWorking_ButtonClick(object sender, RoutedEventArgs e)
        {
            _status = "Elvégzés alatt";
            ChangeStatusToSelected(_job);
            DialogResult = true;
            Close();

        }

        private void JobStatusDone_ButtonClick(object sender, RoutedEventArgs e)
        {    
            _status = "Befejezett munka";
            MessageBoxResult msgBoxResult = MessageBox.Show("A befejezett munka állapot kiválasztása után\na munka törlődik!\nBiztosan törli?",
                "Igen",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning,
                MessageBoxResult.No
                );
            if (msgBoxResult == MessageBoxResult.Yes)
            {
                DataProviders.DataProviderWorkshop.DeleteJob(_job.Id);
            }
            //ChangeStatusToSelected(_job);
            DialogResult = true;
            Close();
        }
        private void WindowBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        internal void ChangeStatusToSelected(Job job)
        {
            
            using (var context = new WebApi_Server.Repositories.JobContext())
            {
                if (job != null)
                {
                    var id = job.Id;
                    var entity = context.Jobs.FirstOrDefault(item => item.Id == id);
                    if (entity != null)
                    {
                        if (_status != null)
                        {
                            entity.Status = _status;
                            context.SaveChanges(); 
                        }

                    }
                }
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
