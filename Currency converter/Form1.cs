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
    }
}