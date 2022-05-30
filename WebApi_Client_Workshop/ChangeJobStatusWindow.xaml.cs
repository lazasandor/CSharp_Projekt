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
        public ChangeJobStatusWindow()
        {
            InitializeComponent();
        }

        private void JobStatusNew_ButtonClick(object sender, RoutedEventArgs e)
        {
            _status = "Felvett munka";
            ChangeStatusToSelected(_job);
            
            
        }
        private void JobStatusWorking_ButtonClick(object sender, RoutedEventArgs e)
        {
            _status = "Elvégzés alatt";
            ChangeStatusToSelected(_job);
           

        }

        private void JobStatusDone_ButtonClick(object sender, RoutedEventArgs e)
        {    
            _status = "Befejezett munka";
            ChangeStatusToSelected(_job);
            
        }

        public string StatusReturn()
        {
            return _status;
        }

        internal void ChangeStatusToSelected(Job job)
        {   
            _job = job;
            using (var context = new WebApi_Server.Repositories.JobContext())
            {
                var selected = job;
                if (selected != null)
                {
                    var id = selected.Id;
                    var entity = context.Jobs.FirstOrDefault(item => item.Id == id);
                    if (entity != null)
                    {
                        var newStatus = _status;
                        if (newStatus != null)
                        {
                            entity.Status = newStatus;
                            context.SaveChanges();
                            Close();
                        }

                    }
                }
            }
        }
    }
}
