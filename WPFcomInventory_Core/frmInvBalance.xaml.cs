using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFERPQuickLauncher_Core;

namespace WPFcomInventory_Core
{
    /// <summary>
    /// Interaction logic for frmInvBalance.xaml
    /// </summary>
    public partial class frmInvBalance : Window
    {
        public frmInvBalance()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            //ClSFormShow myVar = new ClSFormShow();
            //MessageBoxResult resultc = MessageBox.Show(myVar.strConn);

            string strERPConn = ERPClass.g_Conn;
            //MessageBoxResult resultc = MessageBox.Show(strERPConn);

            //lblConnString.Content = strERPConn;

            //MessageBoxResult result = MessageBox.Show(lblConnString.Content);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
