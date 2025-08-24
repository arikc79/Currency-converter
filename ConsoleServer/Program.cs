using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml.Serialization;


public class Message
{
    public string mes { get; set; }
    public string user { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
      
        Console.ReadLine();
    }

    private static async void WaitClientQuery()
    {
        UdpClient server = new UdpClient(49152);

        while (true)
        {
            try
            {
                UdpReceiveResult result = await server.ReceiveAsync();
                IPEndPoint clientEndPoint = result.RemoteEndPoint;
                byte[] data = result.Buffer;

                if (data.Length > 0)
                {
                    MemoryStream stream = new MemoryStream(data);
                    XmlSerializer serializer = new XmlSerializer(typeof(Message));
                    Message message = (Message)serializer.Deserialize(stream);
                    stream.Close();

                    Console.WriteLine($"Підключено: IP: {clientEndPoint.Address}, Port: {clientEndPoint.Port}, User: {message.user}, Time: {DateTime.Now}");

                    // Обробка запиту
                    string[] currencies = message.mes.Split(' ');
                    string response = CalculateExchangeRate(currencies[0], currencies[1]);
                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);

                    // Відправка відповіді
                    await server.SendAsync(responseBytes, responseBytes.Length, clientEndPoint);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }

}