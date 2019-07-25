using DataGridSample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Xceed.Wpf.DataGrid;

namespace DataGridSample.DGC
{
    /// <summary>
    /// DataGridControlSample.xaml の相互作用ロジック
    /// </summary>
    public partial class DataGridControlSample : Window
    {
        ContextMenuStrip _contextMenuStrip = new ContextMenuStrip();
        private ViewModel _vm;
        public DataGridControlSample(ViewModel vm)
        {
            _vm = vm;

            // ContextMenu
            ToolStripMenuItem addMenu = new ToolStripMenuItem("Add");
            addMenu.Click += new EventHandler(add_Click);

            ToolStripMenuItem deleteMenu = new ToolStripMenuItem("Delete");
            deleteMenu.Click += new EventHandler(delete_Click);

            _contextMenuStrip.Items.Add(addMenu);
            _contextMenuStrip.Items.Add(deleteMenu);

            this.DataContext = _vm;
            InitializeComponent();
        }

        private void ColumnManagerRow_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var point = e.GetPosition(null);
            _contextMenuStrip.Show((int)point.X, (int)point.Y);
        }

        void add_Click(object sender, EventArgs e)
        {
            var column = new Column();
            column.FieldName = "Add1";
            column.Title = "Add1";
            dataGridCntrl.Columns.Add(column);
        }
        void delete_Click(object sender, EventArgs e)
        {

        }
    }
}
