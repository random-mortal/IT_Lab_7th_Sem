
namespace q3
{
    partial class Form1
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
            this.heading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salaryLevelsComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Location = new System.Drawing.Point(290, 56);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(181, 17);
            this.heading.TabIndex = 0;
            this.heading.Text = "Employee Bonus Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter current salary:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(397, 153);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(121, 22);
            this.salaryTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select performance level:";
            // 
            // salaryLevelsComboBox
            // 
            this.salaryLevelsComboBox.FormattingEnabled = true;
            this.salaryLevelsComboBox.Items.AddRange(new object[] {
            "Level1",
            "Level2",
            "Level3",
            "Level4",
            "Level5",
            "Level6",
            "Level7",
            "Level8",
            "Level9",
            "Level10"});
            this.salaryLevelsComboBox.Location = new System.Drawing.Point(397, 224);
            this.salaryLevelsComboBox.Name = "salaryLevelsComboBox";
            this.salaryLevelsComboBox.Size = new System.Drawing.Size(121, 24);
            this.salaryLevelsComboBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Click to calculate bonus:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(397, 301);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(121, 22);
            this.bonusTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salaryLevelsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox salaryLevelsComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bonusTextBox;
    }
}

