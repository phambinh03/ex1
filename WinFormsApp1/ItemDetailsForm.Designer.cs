namespace WinFormsApp1
{
    partial class ItemDetailsForm
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
            ItemIDTextBox = new TextBox();
            ItemNameTextBox = new TextBox();
            SizeTextBox = new TextBox();
            saveButton = new Button();
            ID = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // ItemIDTextBox
            // 
            ItemIDTextBox.Location = new Point(130, 49);
            ItemIDTextBox.Name = "ItemIDTextBox";
            ItemIDTextBox.Size = new Size(125, 27);
            ItemIDTextBox.TabIndex = 0;
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Location = new Point(130, 105);
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(125, 27);
            ItemNameTextBox.TabIndex = 1;
            // 
            // SizeTextBox
            // 
            SizeTextBox.Location = new Point(130, 162);
            SizeTextBox.Name = "SizeTextBox";
            SizeTextBox.Size = new Size(125, 27);
            SizeTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(297, 103);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(93, 29);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(66, 52);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 4;
            ID.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 107);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 169);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 6;
            label2.Text = "Size";
            // 
            // ItemDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ID);
            Controls.Add(saveButton);
            Controls.Add(SizeTextBox);
            Controls.Add(ItemNameTextBox);
            Controls.Add(ItemIDTextBox);
            Name = "ItemDetailsForm";
            Text = "ItemDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ItemIDTextBox;
        private TextBox ItemNameTextBox;
        private TextBox SizeTextBox;
        private Button saveButton;
        private Label ID;
        private Label label1;
        private Label label2;
    }
}