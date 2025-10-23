# How to Bind SelectedItem Property in WinForms SfComboBox
This example demonstrates how to **bind the SelectedItem property** of the **Syncfusion WinForms SfComboBox** control to another property in your application. Binding the SelectedItem property is useful when you want to synchronize the selected value in the combo box with a property in your data model or view model. This ensures that any changes in the UI are reflected in the underlying data and vice versa.

## Why Use Data Binding?
Data binding simplifies the process of keeping the UI and data model in sync. When you bind the SelectedItem property:
- The selected item in the combo box updates automatically when the bound property changes.
- Any user selection in the combo box updates the bound property without additional code.

## Implementation Steps
1. **Prepare the ViewModel**: Create a ViewModel class with a collection of items and a property to hold the selected item.
2. **Configure SfComboBox**:
   - Set the `DataSource` to the collection of items.
   - Define `DisplayMember` and `ValueMember` for proper display and value mapping.
3. **Bind SelectedItem**:
   - Use the `DataBindings.Add` method to bind the SelectedItem property of SfComboBox to the ViewModel property.

## Example Code
```csharp
public Form1()
{
    InitializeComponent();

    ViewModel viewModel = new ViewModel();

    sfComboBox1.DataSource = viewModel.Items;
    sfComboBox1.DisplayMember = "LongName";
    sfComboBox1.ValueMember = "ShortName";

    sfComboBox1.DataBindings.Add(
        new Binding("SelectedItem", viewModel, "Selected", true, DataSourceUpdateMode.OnPropertyChanged)
    );
}
```
This code binds the `SelectedItem` property of `sfComboBox1` to the `Selected` property in the ViewModel. The binding uses `DataSourceUpdateMode.OnPropertyChanged` to ensure updates occur immediately when the property changes.

## Reference
For more details, refer to the official Syncfusion Knowledge Base article:  
[How to Bind SelectedItem Property in SfComboBox](https://www.syncfusion.com/kb/11866/how-to-bind-selecteditem-property-of-sfcombobox-to-another-property)
