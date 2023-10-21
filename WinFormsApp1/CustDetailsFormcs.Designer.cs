namespace WinFormsApp1
{
    partial class CustDetailsFormcs
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
            label2 = new Label();
            label1 = new Label();
            ID = new Label();
            saveButton = new Button();
            AddressTextBox = new TextBox();
            CustNameTextBox = new TextBox();
            CustIDTextBox = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 167);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 13;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 105);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(63, 50);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 11;
            ID.Text = "ID";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(294, 101);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(93, 29);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(127, 160);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(125, 27);
            AddressTextBox.TabIndex = 9;
            // 
            // CustNameTextBox
            // 
            CustNameTextBox.Location = new Point(127, 103);
            CustNameTextBox.Name = "CustNameTextBox";
            CustNameTextBox.Size = new Size(125, 27);
            CustNameTextBox.TabIndex = 8;
            // 
            // CustIDTextBox
            // 
            CustIDTextBox.Location = new Point(127, 47);
            CustIDTextBox.Name = "CustIDTextBox";
            CustIDTextBox.Size = new Size(125, 27);
            CustIDTextBox.TabIndex = 7;
            // 
            // CustDetailsFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ID);
            Controls.Add(saveButton);
            Controls.Add(AddressTextBox);
            Controls.Add(CustNameTextBox);
            Controls.Add(CustIDTextBox);
            Name = "CustDetailsFormcs";
            Text = "CustDetailsFormcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label ID;
        private Button saveButton;
        private TextBox AddressTextBox;
        private TextBox CustNameTextBox;
        private TextBox CustIDTextBox;
    }
}