namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string typed_msg = txtMessage.Text;
            lstEcho.Items.Add(typed_msg);
            txtMessage.Clear();
        }

        private void lstEcho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
