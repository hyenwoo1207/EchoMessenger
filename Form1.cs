namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMessage.KeyDown += txtMessage_KeyDown;
            // 초기 메시지 개수 라벨 갱신
            UpdateMessageCountLabel();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SendMessage();

        }
        private void SendMessage()
        {
            // 앞뒤 불필요한 공백 제거
            string typed_msg = txtMessage.Text.Trim();
            if (string.IsNullOrEmpty(typed_msg))
            {
                return;
            }

            // 현재 시간과 메시지를 결합하여 리스트에 출력
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string fullMsg = time + " " + typed_msg;
            lstEcho.Items.Add(fullMsg);
            // 메시지 추가 후 라벨 갱신
            UpdateMessageCountLabel();
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
                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string msg = "Hello";
                string result = time + " " + msg;
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
            // 리스트 초기화 후 라벨 갱신
            UpdateMessageCountLabel();
        }

        private void label2_Click(object sender, EventArgs e)
        {
   
        }

        // 리스트에 쌓인 메시지 개수를 하단 라벨에 표시
        private void UpdateMessageCountLabel()
        {
            // label2는 폼 디자이너에서 생성된 라벨 컨트롤 이름입니다.
            label2.Text = $"현재대화: {lstEcho.Items.Count}개";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            lstEcho.Items.Clear();
        }
    }
}
