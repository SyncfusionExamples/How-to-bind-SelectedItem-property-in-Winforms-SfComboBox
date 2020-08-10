using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxAdv_DataBinding_SelectedItem
{
    public class State
    {
        private string shortName;
        private string longName;

        public State(string LongName, string ShortName)
        {
            this.longName = LongName;
            this.shortName = ShortName;
        }

        public string ShortName
        {
            get { return shortName; }
        }

        public string LongName
        {
            get { return longName; }
        }
    }
}
