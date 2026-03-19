namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMessage.KeyDown += txtMessage_KeyDown;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
        private void SendMessage()
        {
            string typed_msg = txtMessage.Text;
            if (string.IsNullOrWhiteSpace(typed_msg));
            {
                return;
            }

            lstEcho.Items.Add(typed_msg);
            txtMessage.Clear();
            txtMessage.Focus();
            txtMessage.SelectionStart = txtMessage.Text.Length;
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
                e.SuppressKeyPress = true;
            }
        }

        private void lstEcho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            lstEcho.Items.Clear();
        }
    }
}
