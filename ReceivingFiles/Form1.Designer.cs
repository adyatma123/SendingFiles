namespace SendingFiles
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
            lblStatus = new Label();
            lbConnections = new ListBox();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 19);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(99, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "My IP Address is :";
            lblStatus.Click += lblStatus_Click;
            // 
            // lbConnections
            // 
            lbConnections.FormattingEnabled = true;
            lbConnections.ItemHeight = 15;
            lbConnections.Location = new Point(12, 37);
            lbConnections.Name = "lbConnections";
            lbConnections.Size = new Size(309, 304);
            lbConnections.TabIndex = 2;
            lbConnections.SelectedIndexChanged += lbConnections_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 351);
            Controls.Add(lbConnections);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStatus;
        private ListBox lbConnections;
    }
}
