namespace MyGarden
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
            pictureBoxGarden = new PictureBox();
            button_Apply = new Button();
            pictureBoxExampleInfo = new PictureBox();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGarden).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExampleInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxGarden
            // 
            pictureBoxGarden.Anchor = AnchorStyles.None;
            pictureBoxGarden.BackColor = SystemColors.AppWorkspace;
            pictureBoxGarden.Location = new Point(22, -73);
            pictureBoxGarden.Name = "pictureBoxGarden";
            pictureBoxGarden.Size = new Size(876, 561);
            pictureBoxGarden.TabIndex = 0;
            pictureBoxGarden.TabStop = false;
            pictureBoxGarden.MouseDown += pictureBox1_MouseDown;
            pictureBoxGarden.MouseLeave += pictureBoxGarden_MouseLeave;
            pictureBoxGarden.MouseMove += pictureBox1_MouseMove;
            pictureBoxGarden.MouseUp += pictureBox1_MouseUp;
            // 
            // button_Apply
            // 
            button_Apply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Apply.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Apply.Location = new Point(790, 494);
            button_Apply.Name = "button_Apply";
            button_Apply.Size = new Size(111, 51);
            button_Apply.TabIndex = 1;
            button_Apply.Text = "APPLY";
            button_Apply.UseVisualStyleBackColor = true;
            button_Apply.Visible = false;
            button_Apply.Click += button_Apply_Click;
            // 
            // pictureBoxExampleInfo
            // 
            pictureBoxExampleInfo.BackColor = SystemColors.GradientInactiveCaption;
            pictureBoxExampleInfo.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxExampleInfo.Location = new Point(209, 134);
            pictureBoxExampleInfo.Name = "pictureBoxExampleInfo";
            pictureBoxExampleInfo.Size = new Size(125, 267);
            pictureBoxExampleInfo.TabIndex = 2;
            pictureBoxExampleInfo.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBoxExampleInfo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBoxGarden);
            splitContainer1.Panel2.Controls.Add(button_Apply);
            splitContainer1.Panel2.MouseUp += splitContainer1_Panel2_MouseUp;
            splitContainer1.Size = new Size(1254, 557);
            splitContainer1.SplitterDistance = 337;
            splitContainer1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 557);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBoxGarden).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExampleInfo).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxGarden;
        private Button button_Apply;
        private PictureBox pictureBoxExampleInfo;
        private SplitContainer splitContainer1;
    }
}
