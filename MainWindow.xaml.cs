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

namespace Names
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                if (lstNames.SelectedItem != null)
                {
                    // Replace the text of the selected item with the edited text
                    int selectedIndex = lstNames.SelectedIndex;
                    lstNames.Items[selectedIndex] = txtName.Text;
                    lstNames.SelectedItem = null; // Clear the selection
                }
                else if (!lstNames.Items.Contains(txtName.Text))
                {
                    // If it's a new entry, add it to the list
                    lstNames.Items.Add(txtName.Text);
                }
                txtName.Clear();
            }
        }

        private void ButtonDelName_Click(object sender, RoutedEventArgs e)
        {
            if (lstNames.SelectedItem != null)
            {
                lstNames.Items.Remove(lstNames.SelectedItem);
            }
        }

        private void ListNames_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lstNames.SelectedItem != null)
            {
                txtName.Text = lstNames.SelectedItem.ToString();
            }
        }
    }
}
