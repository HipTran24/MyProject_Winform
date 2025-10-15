namespace MyProject.GUI
{
    partial class ucUpdateInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUp = new Button();
            pnlControl = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowPanel = new FlowLayoutPanel();
            pnlControl.SuspendLayout();
            SuspendLayout();
            // 
            // btnUp
            // 
            btnUp.BackColor = Color.Transparent;
            btnUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUp.Location = new Point(28, 3);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(152, 34);
            btnUp.TabIndex = 0;
            btnUp.Text = "Đăng bài";
            btnUp.UseVisualStyleBackColor = false;
            btnUp.Click += btnUp_Click;
            // 
            // pnlControl
            // 
            pnlControl.Controls.Add(btnUp);
            pnlControl.Controls.Add(flowLayoutPanel1);
            pnlControl.Dock = DockStyle.Left;
            pnlControl.Location = new Point(0, 0);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(214, 613);
            pnlControl.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(220, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(952, 634);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // flowPanel
            // 
            flowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanel.Location = new Point(213, 3);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(882, 607);
            flowPanel.TabIndex = 26;
            // 
            // ucUpdateInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(flowPanel);
            Controls.Add(pnlControl);
            Name = "ucUpdateInfo";
            Size = new Size(1098, 613);
            Load += ucUpdateInfo_Load;
            pnlControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnUp;
        private Panel pnlControl;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowPanel;
    }
}
