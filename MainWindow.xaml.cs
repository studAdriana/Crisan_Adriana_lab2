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

namespace Crisan_Adriana_lab2
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private DoughnutMachine myDoughnutMachine;
        private void frmMain_Loaded(object sender, RoutedEventArgs e)
        {
            myDoughnutMachine = new DoughnutMachine();
        }
        private void glazedToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            glazedToolStripMenuItem.IsChecked = true;
            sugarToolStripMenuItem.IsChecked = false;
            myDoughnutMachine.MakeDoughnuts(DoughnutType.Glazed);
        }
        private void sugarToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            glazedToolStripMenuItem.IsChecked = false;
            sugarToolStripMenuItem.IsChecked = true;
            myDoughnutMachine.MakeDoughnuts(DoughnutType.Sugar);
        }
    }
    private void DoughnutCompleteHandler()
    {
        switch (myDoughnutMachine.Flavor)
        {
            case DoughnutType.Glazed:
                mRaisedGlazed++;
                txtGlazedRaised.Text = mRaisedGlazed.ToString();
                break;

            case DoughnutType.Sugar:
                mRaisedSugar++;
                txtSugarRaised.Text = mRaisedSugar.ToString();
                break;
                //...
        }
    }
}
