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

namespace AgentAssignmentDelopgave3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Agents agents = new Agents();   //<-- DEN RIGTIGE


        Agent agentObject = new Agent();


        public MainWindow()
        {
            InitializeComponent();

            agents.Add(new Agent("007", "James Bond", "Being cool", "Save the world"));
            agents.Add(new Agent("123", "Gold Finger", "bad guy", "Destroy the world"));
            DataContext = agents;
            listBoxRight.ItemsSource = agents;
           


        }

        private void txtBoxID_TextChanged(object sender, TextChangedEventArgs e)
        {
            agentObject.ID = txtBoxID.Text;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            agentObject.CodeName = txtBoxCodeName.Text;

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            agentObject.Speciality = txtBoxSpeciality.Text;

        }

        private void txtBoxAssignment_TextChanged(object sender, TextChangedEventArgs e)
        {
            agentObject.Assignment = txtBoxSpeciality.Text;

        }

        private void listBoxOnLoad(object sender, RoutedEventArgs e)
        {

        }

    }
}
