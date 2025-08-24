using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Currency_converter
{
    public partial class Form1 : Form
    {
        private UdpClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button_Conect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_IPadress.Text))
            {
                MessageBox.Show("Введіть IP-адресу!");
                return;
            }
            try
            {
                client = new UdpClient();
                label_Conect.Text = "Підключено!";
                label_Conect.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка підключення: " + ex.Message);
            }
        }

     

    }
}