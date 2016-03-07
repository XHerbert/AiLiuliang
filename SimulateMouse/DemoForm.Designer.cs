namespace SimulateMouse
{
    partial class DemoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer Generated Code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.chkAnimation = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCursor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // movementTimer
            // 
            this.movementTimer.Interval = 30;
            this.movementTimer.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // chkAnimation
            // 
            this.chkAnimation.AutoSize = true;
            this.chkAnimation.Location = new System.Drawing.Point(93, 15);
            this.chkAnimation.Name = "chkAnimation";
            this.chkAnimation.Size = new System.Drawing.Size(151, 18);
            this.chkAnimation.TabIndex = 1;
            this.chkAnimation.Text = "Animate mouse trial";
            this.chkAnimation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cursor Position";
            // 
            // tbCursor
            // 
            this.tbCursor.BackColor = System.Drawing.Color.Lavender;
            this.tbCursor.Location = new System.Drawing.Point(121, 49);
            this.tbCursor.Name = "tbCursor";
            this.tbCursor.ReadOnly = true;
            this.tbCursor.Size = new System.Drawing.Size(118, 22);
            this.tbCursor.TabIndex = 3;
            // 
            // DemoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(256, 84);
            this.Controls.Add(this.tbCursor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkAnimation);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DemoForm";
            this.Text = "Mouse event demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.CheckBox chkAnimation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCursor;
    }
}

