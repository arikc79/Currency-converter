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
        WaitClientQuery();
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


    private static string CalculateExchangeRate(string fromCurrency, string toCurrency)
    {
        double rate = 0.0;
        if (fromCurrency == "USD" && toCurrency == "EURO") rate = 0.92;
        else if (fromCurrency == "EURO" && toCurrency == "USD") rate = 1.09;

        else if (fromCurrency == "USD" && toCurrency == "UAH") rate = 41.50;
        else if (fromCurrency == "UAH" && toCurrency == "USD") rate = 0.0241;

        else if (fromCurrency == "EURO" && toCurrency == "UAH") rate = 45.20;
        else if (fromCurrency == "UAH" && toCurrency == "EURO") rate = 0.0221;

        else if (fromCurrency == "GBP" && toCurrency == "USD") rate = 1.28;
        else if (fromCurrency == "USD" && toCurrency == "GBP") rate = 0.781;

        else if (fromCurrency == "GBP" && toCurrency == "UAH") rate = 53.10;
        else if (fromCurrency == "UAH" && toCurrency == "GBP") rate = 0.0188;

        else if (fromCurrency == "GBP" && toCurrency == "EURO") rate = 1.39;
        else if (fromCurrency == "EURO" && toCurrency == "GBP") rate = 0.719;


        return rate.ToString("F4");
    }

}