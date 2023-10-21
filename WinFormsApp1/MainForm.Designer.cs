namespace WinFormsApp1
{
    partial class MainForm
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
            btnAdd = new Button();
            txtAdd = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtAddCust = new TextBox();
            btnAddCust = new Button();
            label2 = new Label();
            label4 = new Label();
            Displaybtn = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(462, 95);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 31);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(146, 99);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(255, 27);
            txtAdd.TabIndex = 1;
            txtAdd.TextChanged += txtAdd_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 99);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 2;
            label1.Text = "Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 146);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 4;
            label3.Text = "Eg: 13,'Item13',35";
            // 
            // txtAddCust
            // 
            txtAddCust.Location = new Point(146, 199);
            txtAddCust.Name = "txtAddCust";
            txtAddCust.Size = new Size(255, 27);
            txtAddCust.TabIndex = 5;
            txtAddCust.TextChanged += txtAddCust_TextChanged;
            // 
            // btnAddCust
            // 
            btnAddCust.Location = new Point(462, 197);
            btnAddCust.Name = "btnAddCust";
            btnAddCust.Size = new Size(108, 31);
            btnAddCust.TabIndex = 6;
            btnAddCust.Text = "Add";
            btnAddCust.UseVisualStyleBackColor = true;
            btnAddCust.Click += btnAddCust_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 199);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 250);
            label4.Name = "label4";
            label4.Size = new Size(245, 20);
            label4.TabIndex = 8;
            label4.Text = "Eg: '521h0495','Item13','Thong Nhat'";
            // 
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Displaybtn);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnAddCust);
            Controls.Add(txtAddCust);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtAdd);
            Controls.Add(btnAdd);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtAdd;
        private Label label1;
        private Label label3;
        private TextBox txtAddCust;
        private Button btnAddCust;
        private Label label2;
        private Label label4;
        private Button Displaybtn;
    }
}