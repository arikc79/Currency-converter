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

        private async void buttonDisconect_Click(object sender, EventArgs e)
        {
            client?.Close();
            label_Conect.Text = "Відключено!";
            label_Conect.ForeColor = System.Drawing.Color.Red;
        }


        private async void button_Convert_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                MessageBox.Show("Спочатку підключіться до сервера!");
                return;
            }

            string currencyA = comboBox_SelectСurrency_A.SelectedItem?.ToString();
            string currencyB = comboBox_SelectCurrency_B.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(currencyA) || string.IsNullOrEmpty(currencyB))
            {
                MessageBox.Show("Виберіть валюти!");
                return;
            }

            try
            {
                MemoryStream stream = new MemoryStream();
                XmlSerializer serializer = new XmlSerializer(typeof(Message));
                Message m = new Message
                {
                    mes = $"{currencyA} {currencyB}",
                    user = Environment.UserDomainName + @"\" + Environment.UserName
                };
                serializer.Serialize(stream, m);
                byte[] arr = stream.ToArray();
                stream.Close();

                IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(textBox_IPadress.Text), 49152);
                await client.SendAsync(arr, arr.Length, serverEndPoint);

                UdpReceiveResult result = await client.ReceiveAsync();
                string rate = Encoding.UTF8.GetString(result.Buffer);
                label2.Text = rate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка конвертації: " + ex.Message);
            }
        }
    }
}