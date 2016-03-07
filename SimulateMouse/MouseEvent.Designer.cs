using System.Windows.Forms;
namespace SimulateMouse
{
    partial class MouseEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.InputPhoneTimer = new System.Windows.Forms.Timer(this.components);
            this.startTask = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Msg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoftKey = new System.Windows.Forms.TextBox();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.InputPasswordTimer = new System.Windows.Forms.Timer(this.components);
            this.InputCodeTimer = new System.Windows.Forms.Timer(this.components);
            this.SignTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputPhoneTimer
            // 
            this.InputPhoneTimer.Interval = 8000;
            this.InputPhoneTimer.Tick += new System.EventHandler(this.InputPhoneTimer_Tick);
            // 
            // startTask
            // 
            this.startTask.Location = new System.Drawing.Point(12, 222);
            this.startTask.Name = "startTask";
            this.startTask.Size = new System.Drawing.Size(106, 25);
            this.startTask.TabIndex = 4;
            this.startTask.Text = "执行任务";
            this.startTask.UseVisualStyleBackColor = true;
            this.startTask.Click += new System.EventHandler(this.startTask_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(220, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1012, 728);
            this.webBrowser1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 64);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Msg.Location = new System.Drawing.Point(33, 311);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(0, 12);
            this.Msg.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoftKey);
            this.groupBox1.Controls.Add(this.txtTimeout);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 185);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数中心";
            // 
            // txtSoftKey
            // 
            this.txtSoftKey.Location = new System.Drawing.Point(42, 147);
            this.txtSoftKey.Name = "txtSoftKey";
            this.txtSoftKey.ReadOnly = true;
            this.txtSoftKey.Size = new System.Drawing.Size(153, 21);
            this.txtSoftKey.TabIndex = 9;
            this.txtSoftKey.Text = "b40ffbee5c1cf4e38028c197eb2fc751";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(42, 119);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(153, 21);
            this.txtTimeout.TabIndex = 8;
            this.txtTimeout.Text = "90";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(42, 91);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(153, 21);
            this.txtType.TabIndex = 7;
            this.txtType.Text = "2040";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(42, 63);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(153, 21);
            this.txtPass.TabIndex = 6;
            this.txtPass.Text = "qq12345678";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(42, 35);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(153, 21);
            this.txtAccount.TabIndex = 5;
            this.txtAccount.Text = "qq185427977";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "密钥";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "超时";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号";
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(0, 692);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(168, 58);
            this.webBrowser2.TabIndex = 8;
            this.webBrowser2.Visible = false;
            // 
            // InputPasswordTimer
            // 
            this.InputPasswordTimer.Interval = 3000;
            this.InputPasswordTimer.Tick += new System.EventHandler(this.InputPasswordTimer_Tick);
            // 
            // InputCodeTimer
            // 
            this.InputCodeTimer.Interval = 4000;
            this.InputCodeTimer.Tick += new System.EventHandler(this.InputCodeTimer_Tick);
            // 
            // SignTimer
            // 
            this.SignTimer.Interval = 4000;
            this.SignTimer.Tick += new System.EventHandler(this.SignTimer_Tick);
            // 
            // MouseEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 747);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.startTask);
            this.Name = "MouseEvent";
            this.Text = "MouseEvent";
            this.Load += new System.EventHandler(this.MouseEvent_Load);
            this.ClientSizeChanged += new System.EventHandler(this.MouseEvent_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startTask;
        private WebBrowser webBrowser1;
        private PictureBox pictureBox1;
        private Label Msg;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtPass;
        private TextBox txtAccount;
        private TextBox txtSoftKey;
        private TextBox txtTimeout;
        private TextBox txtType;
        private WebBrowser webBrowser2;
        private Timer InputCodeTimer;
        private Timer InputPhoneTimer;
        private Timer InputPasswordTimer;
        private Timer SignTimer;
    }
}