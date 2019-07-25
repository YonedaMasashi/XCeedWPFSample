using DataGridSample.Model;
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

namespace DataGridSample.DG
{
    /// <summary>
    /// DataGridSample.xaml の相互作用ロジック
    /// </summary>
    public partial class DataGridSample : Window
    {
        private ViewModel _vm;

        public DataGridSample(ViewModel vm)
        {
            _vm = vm;

            this.DataContext = _vm;
            InitializeComponent();
        }
    }
}
