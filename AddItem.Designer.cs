namespace HW6_Inventory
{
    partial class AddItem
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
            OKButton = new Button();
            CancelButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            PriceTextBox = new TextBox();
            SuspendLayout();
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK;
            OKButton.Location = new Point(12, 230);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(112, 34);
            OKButton.TabIndex = 0;
            OKButton.Text = "Confirm";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(168, 230);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 34);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 3;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(130, 9);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(150, 31);
            NameTextBox.TabIndex = 5;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(130, 73);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(150, 31);
            DescriptionTextBox.TabIndex = 6;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(130, 137);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(150, 31);
            PriceTextBox.TabIndex = 7;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 287);
            Controls.Add(PriceTextBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Name = "AddItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OKButton;
        private Button CancelButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTextBox;
        private TextBox DescriptionTextBox;
        private TextBox PriceTextBox;
    }
}