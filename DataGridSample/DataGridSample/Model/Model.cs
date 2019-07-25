using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridSample.Model {
    public class ViewModel
    {
        public Model _Model { get; } = new Model();
    }
    public class Model
    {
        public List<Goods> _Goods { get; set; } = new List<Goods>();
        public Model()
        {
            for (int i = 0; i < 10; i++)
            {
                _Goods.Add(new Goods()
                {
                    _Name = "商品" + i,
                    _Price = i * 1000,
                    _isAvailable = (i % 2 == 1) ? true : false,
                    _Vender = Vendor.取引先A,
                });
            }
        }
    }
    public class Goods
    {
        public string _Name { get; set; }
        public int _Price { get; set; }
        public bool _isAvailable { get; set; }
        public Vendor _Vender { get; set; }
    }
    public enum Vendor
    {
        取引先A,
        取引先B,
        取引先C,
        取引先D,
    }
    public class VenderToComboBox
    {
        public string _Label { get; set; }
        public Vendor _Value { get; set; }
    }
}
