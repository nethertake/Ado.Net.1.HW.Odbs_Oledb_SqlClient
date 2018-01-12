using System;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;


namespace Con_SqlClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string connectionString = "Data Source = 192.168.111.252; Initial Catalog = MCS; User ID =sa; Password = Mc123456";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnectToServerButton_Click(object sender, RoutedEventArgs e)
        {

            using(SqlConnection connection = new SqlConnection(connectionString))
            {



                ConnectMessage.Text = null;
                connection.Open();
                ConnectMessage.Text += "Подключение открыто... \n";
                //Получим информацию о подключении
                ConnectMessage.Text += "Свойство подкючения: \n";
                ConnectMessage.Text += "\t --> строка подключения:  \n" + connection.ConnectionString + "\n";
                ConnectMessage.Text += "\t --> сервер: " + connection.ServerVersion + "\n";
                ConnectMessage.Text += "\t --> workstationId: " + connection.WorkstationId + "\n";
                ConnectMessage.Text += "\t --> состояние: " + connection.State + "\n";
                ConnectMessage.Text += "\t --> таймаут:  " + connection.ConnectionTimeout + "\n";
            }
            ConnectMessage.Text += "Подключение закрыто... \n";
        }


        private void ConnectToServerButton2_Click(object sender, RoutedEventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                ConnectMessage.Text = null;
                connection.Open();
                ConnectMessage.Text += "Подключение открыто... \n";
                //Получим информацию о подключении
                ConnectMessage.Text += "Свойство подкючения: \n";
                ConnectMessage.Text += "\t --> строка подключения:  \n" + connection.ConnectionString + "\n";
                ConnectMessage.Text += "\t --> сервер: " + connection.ServerVersion + "\n";
                ConnectMessage.Text += "\t --> workstationId: " + connection.WorkstationId + "\n";
                ConnectMessage.Text += "\t --> состояние: " + connection.State + "\n";
                ConnectMessage.Text += "\t --> таймаут:  " + connection.ConnectionTimeout + "\n";
            }
            ConnectMessage.Text += "Подключение закрыто... \n";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ConnectMessage.Text = null;
        }
    }
}
