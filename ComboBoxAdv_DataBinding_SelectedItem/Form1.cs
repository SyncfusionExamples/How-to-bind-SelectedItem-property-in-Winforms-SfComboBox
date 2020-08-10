using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxAdv_DataBinding_SelectedItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ViewModel viewModel = new ViewModel();

            sfComboBox1.DataSource = viewModel.Items;
            sfComboBox1.DisplayMember = "LongName";
            sfComboBox1.ValueMember = "ShortName";

            sfComboBox1.DataBindings.Add(new Binding("SelectedItem", viewModel,"Selected",true, DataSourceUpdateMode.OnPropertyChanged));

        }
    }
}
