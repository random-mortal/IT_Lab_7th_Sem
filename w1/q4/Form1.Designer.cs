
namespace q4
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
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.colourComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.colourLabel = new System.Windows.Forms.Label();
            this.modelListBox = new System.Windows.Forms.ListBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Location = new System.Drawing.Point(305, 57);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(171, 17);
            this.heading.TabIndex = 0;
            this.heading.Text = "Purchase your dream car!";
            // 
            // nameComboBox
            // 
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Items.AddRange(new object[] {
            "Santro",
            "Ikon",
            "Lancer",
            "Cruz",
            "i10 Neo"});
            this.nameComboBox.Location = new System.Drawing.Point(237, 108);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(121, 24);
            this.nameComboBox.TabIndex = 1;
            // 
            // colourComboBox
            // 
            this.colourComboBox.FormattingEnabled = true;
            this.colourComboBox.Items.AddRange(new object[] {
            "Grey",
            "Black",
            "Maroon",
            "Blue",
            "Cyan"});
            this.colourComboBox.Location = new System.Drawing.Point(609, 104);
            this.colourComboBox.Name = "colourComboBox";
            this.colourComboBox.Size = new System.Drawing.Size(121, 24);
            this.colourComboBox.TabIndex = 2;
            this.colourComboBox.SelectedIndexChanged += new System.EventHandler(this.colourComboBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(49, 111);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(114, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Select the name:";
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Location = new System.Drawing.Point(417, 111);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(118, 17);
            this.colourLabel.TabIndex = 4;
            this.colourLabel.Text = "Select the colour:";
            // 
            // modelListBox
            // 
            this.modelListBox.FormattingEnabled = true;
            this.modelListBox.ItemHeight = 16;
            this.modelListBox.Items.AddRange(new object[] {
            "Classic",
            "Sport",
            "Performance",
            "Off-road"});
            this.modelListBox.Location = new System.Drawing.Point(237, 169);
            this.modelListBox.Name = "modelListBox";
            this.modelListBox.Size = new System.Drawing.Size(120, 84);
            this.modelListBox.TabIndex = 5;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(48, 169);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(117, 17);
            this.modelLabel.TabIndex = 6;
            this.modelLabel.Text = "Select the model:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(423, 175);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(105, 17);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Enter the price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(609, 169);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 22);
            this.priceTextBox.TabIndex = 8;
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(130, 306);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(105, 49);
            this.purchaseButton.TabIndex = 9;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(509, 306);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 49);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.modelListBox);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.colourComboBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.heading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.ComboBox colourComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.ListBox modelListBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

