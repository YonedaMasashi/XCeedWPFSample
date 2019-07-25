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
using DataGridSample.DG;
using DataGridSample.DGC;
using DataGridSample.Model;

namespace DataGridSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel _vm;

        public MainWindow()
        {
            InitializeComponent();

            _vm = new ViewModel();
            for (int i = 0; i < 10; ++i)
            {
                var goods = new Goods();
                goods._Name = string.Format("Name{0}", i);
                goods._Price = i;
                goods._Vender = (Vendor)(i % 4);
                goods._isAvailable = true;

                _vm._Model._Goods.Add(goods);
            }
        }

        private void DataGridBtn_Click(object sender, RoutedEventArgs e)
        {
            var dataGridWindow = new DataGridSample.DG.DataGridSample(_vm);
            dataGridWindow.ShowDialog();

        }

        private void DataTableBtn_Click(object sender, RoutedEventArgs e)
        {
            var dataGridControlWindow = new DataGridControlSample(_vm);
            dataGridControlWindow.ShowDialog();
        }
    }
}
