namespace MyGarden
{
    partial class Form2
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
            pictureBoxGarden = new PictureBox();
            dataGridView1 = new DataGridView();
            button_1 = new Button();
            button_3 = new Button();
            button_5 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGarden).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGarden
            // 
            pictureBoxGarden.Location = new Point(12, 12);
            pictureBoxGarden.Name = "pictureBoxGarden";
            pictureBoxGarden.Size = new Size(716, 416);
            pictureBoxGarden.TabIndex = 0;
            pictureBoxGarden.TabStop = false;
            pictureBoxGarden.MouseMove += pictureBoxGarden_MouseMove;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(843, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 1;
            // 
            // button_1
            // 
            button_1.Location = new Point(768, 295);
            button_1.Name = "button_1";
            button_1.Size = new Size(94, 29);
            button_1.TabIndex = 2;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += button_1_Click;
            // 
            // button_3
            // 
            button_3.Location = new Point(768, 330);
            button_3.Name = "button_3";
            button_3.Size = new Size(94, 29);
            button_3.TabIndex = 3;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = true;
            button_3.Click += button_3_Click;
            // 
            // button_5
            // 
            button_5.Location = new Point(768, 365);
            button_5.Name = "button_5";
            button_5.Size = new Size(94, 29);
            button_5.TabIndex = 4;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = true;
            button_5.Click += button_5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(746, 12);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 5;
            label1.Text = "0";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 450);
            Controls.Add(label1);
            Controls.Add(button_5);
            Controls.Add(button_3);
            Controls.Add(button_1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBoxGarden);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxGarden).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxGarden;
        private DataGridView dataGridView1;
        private Button button_1;
        private Button button_3;
        private Button button_5;
        private Label label1;
    }
}