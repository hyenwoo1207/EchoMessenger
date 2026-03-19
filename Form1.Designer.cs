namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lstEcho = new ListBox();
            txtMessage = new TextBox();
            btn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(286, 46);
            label1.TabIndex = 0;
            label1.Text = "Echo Messenger";
            // 
            // lstEcho
            // 
            lstEcho.BackColor = Color.Silver;
            lstEcho.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lstEcho.FormattingEnabled = true;
            lstEcho.Location = new Point(12, 79);
            lstEcho.Name = "lstEcho";
            lstEcho.Size = new Size(758, 200);
            lstEcho.TabIndex = 1;
            lstEcho.SelectedIndexChanged += lstEcho_SelectedIndexChanged;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtMessage.Location = new Point(12, 326);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(625, 31);
            txtMessage.TabIndex = 2;
            txtMessage.Text = "(여기에 입력하세요)";
            txtMessage.TextChanged += txtMessage_TextChanged;
            // 
            // btn
            // 
            btn.BackColor = Color.FromArgb(255, 128, 128);
            btn.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn.ForeColor = Color.FromArgb(192, 0, 0);
            btn.Location = new Point(656, 311);
            btn.Name = "btn";
            btn.Size = new Size(114, 61);
            btn.TabIndex = 3;
            btn.Text = "전송";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(618, 386);
            button1.Name = "button1";
            button1.Size = new Size(182, 52);
            button1.TabIndex = 4;
            button1.Text = "대화 기록 삭제";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn);
            Controls.Add(txtMessage);
            Controls.Add(lstEcho);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(0, 192, 192);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstEcho;
        private TextBox txtMessage;
        private Button btn;
        private Button button1;
    }
}
