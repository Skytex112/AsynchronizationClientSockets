using System.Net.Sockets;
using System.Net;
using System.Text;

namespace AsynchronizationClientSockets
{
    public partial class Form1 : Form
    {
        private Socket _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        EndPoint _serverEP;
        public Form1()
        {
            InitializeComponent();
        }

        private async void ConnectButAsync(object sender, EventArgs e)
        {
            if (_socket.Connected)
            {
                AnswerTextBox.Text = "You allready connected";
                return;
            }

            try
            {
                if (msgBox.Text == "")
                {
                    AnswerTextBox.Text = "To connect to server you need to enter 'username'";
                }


                await _socket.ConnectAsync(IPAddress.Loopback, 5000);
                byte[] request = Encoding.UTF8.GetBytes(msgBox.Text);
                await _socket.SendAsync(request);
                byte[] buffer = new byte[1024];
                int recieved = await _socket.ReceiveAsync(buffer);
                string msg = Encoding.UTF8.GetString(buffer, 0, recieved);

                AnswerTextBox.Text = msg;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private async void SENDAsync(object sender, EventArgs e)
        {
            if (!_socket.Connected)
            {
                MessageBox.Show("Allready connected to server");
                return;
            }

            try
            {
                byte[] request = Encoding.UTF8.GetBytes(msgBox.Text);
                await _socket.SendAsync(request);
                //msgBox.Text = $"Sended {request}";

                byte[] buffer = new byte[1024];
                int recieved = await _socket.ReceiveAsync(buffer);

                string value = Encoding.UTF8.GetString(buffer);

                AnswerTextBox.Text = value;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private async void Disconnect_buttonAsync(object sender, EventArgs e)
        {
            if (_socket.Connected)
            {
                byte[] buffer = Encoding.UTF8.GetBytes("DIS");
                _socket.Send(buffer);
                await _socket.DisconnectAsync(true);
                AnswerTextBox.Text = "Disconnected";
            }
            else
            {
                MessageBox.Show("Not connected to server, allready disconnected");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void UpdateButton(object sender, EventArgs e)
        {
            if (_socket.Connected)
            {
                byte[] buffer = Encoding.UTF8.GetBytes("UPD");
                _socket.Send(buffer);

                await _socket.ReceiveAsync(buffer);
                string value = Encoding.UTF8.GetString(buffer);

                AnswerTextBox.Text = value;
            }
            else
            {
                MessageBox.Show("Not connected to server, allready disconnected");
            }
        }

        /*
        private void SendUDP(object sender, EventArgs e)
        {
            try
            {
                string msg = msgBox.Text;
                byte[] data = Encoding.UTF8.GetBytes(msg);

                _socket.SendTo(data, _serverEP); //What is ServerEP? Where write it?

                byte[] buffer = new byte[1024];
                int recieved = _socket.ReceiveFrom(buffer, ref _serverEP); //Same question
                string reply = Encoding.UTF8.GetString(buffer, 0, recieved);
                AnswerTextBox.Text = reply;
            }
            catch(Exception ex )
            {
                MessageBox.Show("Some error");
            }
        }
        */
    }
}
