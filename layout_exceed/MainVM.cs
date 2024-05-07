using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layout_exceed
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public List<ViewItem> ViewItems { get; set; }


        public MainVM()
        {
            ViewItems = new List<ViewItem>();
            ViewItems.Add(new ViewItem() { Test1 = "VERY "});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY "});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY VERY "});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY VERY LONG "});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY VERY LONG "});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY VERY LONG "});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY VERY LONG "});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY VERY LONG "});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY VERY LONG "});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY VERY LONG "});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY VERY LONG "});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY VERY LONG "});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY VERY LONG TEXT FOR TESTING PURPOSES"});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY VERY LONG TEXT FOR TESTING PURPOSES"});
            ViewItems.Add(new ViewItem() { Test1 = "VERY VERY VERY LONG TEXT FOR TESTING PURPOSES"});
        }
    }
}
