using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxAdv_DataBinding_SelectedItem
{
    class ViewModel
    {
        private List<State> items;

        public List<State> Items
        {
            get { return items; }
            set { items = value; }
        }

        private object selected;

        public object Selected
        {
            get { return selected; }
            set { selected = value; }
        }


        public ViewModel()
        {
            Items = new List<State>();
            Items.Add(new State("Alaska", "AK"));
            Items.Add(new State("Arizona", "AZ"));
            Items.Add(new State("Colorado", "CO"));
            Items.Add(new State("Ontario", "ON"));
            Items.Add(new State("BritishColumbia", "BC"));

            Selected = Items[3];

        }

    }
}
