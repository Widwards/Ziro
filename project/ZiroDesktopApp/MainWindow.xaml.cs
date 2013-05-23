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

using ZiroDesktopApp.ServiceReference1;

namespace ZiroDesktopApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FileExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FileOpen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ZiroServerConnect_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("To main Ziro server connected");
        }

        private void TestZiroServerConnect_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("To test Ziro server connected");
        }

        //StatusBar evets
        private void MouseEnterExitArea(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "Close application";
        }
        private void MouseLeaveAnyArea(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "Ready";
        }
        private void MouseEnterToolsArea(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "Tools";
        }
        private void MouseEnterOpenFileArea(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "Open file";
        }
        private void MouseEnterEditArea(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "Edit";
        }
        private void MouseEnterHelpArea(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "Help";
        }
        private void MouseEnterTestZiroServerConnectionArea(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "Test Ziro server";
        }
        private void MouseEnterZiroServerConnectionArea(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "Main Ziro server";
        }
        private void MouseEnterConnectionToDbArea(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "List of connections to database";
        }
        private void MouseEnterDbArea(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "Data Base options";
        }
        private void MouseEnterFileArea(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "File";
        }
        private void MouseEnterWidwardsZiroServerConnectionArea(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "Widwards.cloudapp.net Ziro server";
        }
        private void MousEnterListOfNodesArea(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "List of connecting nodes";
        }

        private void ResizControl_Click(object sender, MouseButtonEventArgs e)
        {

        }
        //dragable
        private void MousLeftButtonDown_click(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void WidwardsZiroServerConnect_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("To widwards.cloudapp.net database connected");
        }

        private void ListBoxChanged(object sender, SelectionChangedEventArgs e)
        {

        }




    }
}
