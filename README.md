# How-to-bind-SelectedItem-property-in-Winforms-SfComboBox
This example demonstrates how to bind the Winforms SfComboBox's SelectedItem property. 
You can select the item programmatically in MultiSelectionComboBox control by using SelectedItem or SelectedItems property. 

# C#

          public Form1()
            {
                InitializeComponent();
                ViewModel viewModel = new ViewModel();
                sfComboBox1.DataSource = viewModel.Items;
                sfComboBox1.DisplayMember = "LongName";
                sfComboBox1.ValueMember = "ShortName";
                sfComboBox1.DataBindings.Add(new Binding("SelectedItem", viewModel,"Selected",true, DataSourceUpdateMode.OnPropertyChanged));
            }

![Programatically SelectedItem](ComboBoxAdv_DataBinding_SelectedItem/Image/Programatically%20SelectedItem.png)

For more details please refer [How to bind SelectesItem property in SfComboBox](https://www.syncfusion.com/kb/11866/how-to-bind-selecteditem-property-of-sfcombobox-to-another-property)
