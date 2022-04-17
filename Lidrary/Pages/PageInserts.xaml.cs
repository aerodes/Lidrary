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
using System.Windows.Threading;
using Lidrary.AppDataFiel;

namespace Lidrary.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageInserts.xaml
    /// </summary>
    public partial class PageInserts : Page
    {
        public PageInserts()
        {
            InitializeComponent();

            DispatcherTimer dispatcherTimer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            dispatcherTimer.Tick += UpdateData;
            dispatcherTimer.Start();
        }
        public void UpdateData(object sender, object e)
        {
            using (Library2Entities db = new Library2Entities())
            {
                List<ClassInsert> classInserts = new List<ClassInsert>();
                classInserts = db.Insert.ToList();
                ListInserts.ItemsSource = classInserts;
            }
        }
    }
}
