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
            ChangeStatusToSelected(_job);
            DialogResult = true;
            Close();
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
    }
}
