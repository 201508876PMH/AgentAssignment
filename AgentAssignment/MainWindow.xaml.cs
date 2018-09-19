using I4GUI;    
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

namespace AgentAssignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Agent agentObject = new Agent();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtBoxID_TextChanged(object sender, TextChangedEventArgs e)
        {
            agentObject.ID = txtBoxID.Text;
            txtBlock1.Text = txtBoxID.Text;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            agentObject.CodeName = txtBoxCodeName.Text;
            TxtBlock2.Text = txtBoxCodeName.Text;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            agentObject.Speciality = txtBoxSpeciality.Text;
            txtBlock3.Text = txtBoxSpeciality.Text;
        }

        private void txtBoxAssignment_TextChanged(object sender, TextChangedEventArgs e)
        {
            agentObject.Assignment = txtBoxSpeciality.Text;
            txtBlock4.Text = txtBoxSpeciality.Text;
        }
    }
}
