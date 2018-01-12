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
using System.Data.Odbc;
using System.Data.OleDb;
using System.Configuration;


namespace Con_ODBS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string connectionString = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnectToServerButton2_Click(object sender, RoutedEventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefauldODBC"].ConnectionString;

            using (OdbcConnection con = new OdbcConnection(connectionString))
            {
                con.Open();
                ConnectMessage.Text += "Подключение открыто... \n";
                ConnectMessage.Text += "Свойство подкючения: \n";
                ConnectMessage.Text += "\t --> строка подключения:  \n" + con.ConnectionString + "\n";
                ConnectMessage.Text += "\t --> таймаут: " + con.ConnectionTimeout + "\n";
                ConnectMessage.Text += "\t --> сервер: " + con.ServerVersion + "\n";
                ConnectMessage.Text += "\t --> состояние: " + con.State + "\n";
                ConnectMessage.Text += "\t --> источник данных: " + con.DataSource + "\n";


            }
            ConnectMessage.Text += "Подключение закрыто... \n";
        }

        private void ConnectToServerButton_Click(object sender, RoutedEventArgs e)
        {
            connectionString = "Driver={Microsoft Access Driver (*.mdb)}; DBQ=accessDb_00.mdb; User ID=admin; Password=;";

            using (OdbcConnection con = new OdbcConnection(connectionString))
            {
            
                con.Open();
                ConnectMessage.Text += "Подключение открыто... \n";
                ConnectMessage.Text += "Свойство подкючения: \n";
                ConnectMessage.Text += "\t --> строка подключения:  \n" + con.ConnectionString + "\n";
                ConnectMessage.Text += "\t --> таймаут: " + con.ConnectionTimeout + "\n";
                ConnectMessage.Text += "\t --> сервер: " + con.ServerVersion + "\n";
                ConnectMessage.Text += "\t --> состояние: " + con.State + "\n";
                ConnectMessage.Text += "\t --> источник данных: " + con.DataSource + "\n";


            }
            ConnectMessage.Text += "Подключение закрыто... \n";

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ConnectMessage.Text = null;
        }
    }
}
