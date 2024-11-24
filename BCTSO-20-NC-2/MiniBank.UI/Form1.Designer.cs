namespace MiniBank.UI
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
            msgBtn1 = new Button();
            msgBtn2 = new Button();
            msgLabel = new Label();
            SuspendLayout();
            // 
            // msgBtn1
            // 
            msgBtn1.Location = new Point(299, 404);
            msgBtn1.Name = "msgBtn1";
            msgBtn1.Size = new Size(112, 34);
            msgBtn1.TabIndex = 0;
            msgBtn1.Text = "Message 1";
            msgBtn1.UseVisualStyleBackColor = true;
            msgBtn1.Click += msgBtn1_Click;
            // 
            // msgBtn2
            // 
            msgBtn2.Location = new Point(417, 404);
            msgBtn2.Name = "msgBtn2";
            msgBtn2.Size = new Size(112, 34);
            msgBtn2.TabIndex = 0;
            msgBtn2.Text = "Message 2";
            msgBtn2.UseVisualStyleBackColor = true;
            msgBtn2.Click += msgBtn2_Click;
            // 
            // msgLabel
            // 
            msgLabel.AutoSize = true;
            msgLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            msgLabel.Location = new Point(323, 141);
            msgLabel.Name = "msgLabel";
            msgLabel.Size = new Size(0, 45);
            msgLabel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(msgLabel);
            Controls.Add(msgBtn2);
            Controls.Add(msgBtn1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button msgBtn1;
        private Button msgBtn2;
        private Label msgLabel;
    }
}
