namespace Lecture23
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
            loadingLabel = new Label();
            userLabel = new Label();
            ordersLabel = new Label();
            SuspendLayout();
            // 
            // loadingLabel
            // 
            loadingLabel.AutoSize = true;
            loadingLabel.Location = new Point(321, 148);
            loadingLabel.Name = "loadingLabel";
            loadingLabel.Size = new Size(0, 25);
            loadingLabel.TabIndex = 0;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(273, 279);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(0, 25);
            userLabel.TabIndex = 1;
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.Location = new Point(701, 350);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(0, 25);
            ordersLabel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 735);
            Controls.Add(ordersLabel);
            Controls.Add(userLabel);
            Controls.Add(loadingLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loadingLabel;
        private Label userLabel;
        private Label ordersLabel;
    }
}
