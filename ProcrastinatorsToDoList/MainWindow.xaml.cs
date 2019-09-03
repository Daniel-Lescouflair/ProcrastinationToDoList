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

namespace ProcrastinatorsToDoList
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

        //Function that handles adding items to list box.
        #region Add items to List
        private void AddTask_Click(object sender, RoutedEventArgs e)
        {

            if (!(UserInput.Text == ""))
            {
                ToDoList.Items.Add(UserInput.Text);
                UserInput.Text = String.Empty;
            }
            ToDoList.Items.Add(UserInput.Text);
            UserInput.Text = String.Empty;

        }


        #endregion

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
