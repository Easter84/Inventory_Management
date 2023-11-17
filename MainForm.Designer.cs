namespace HW6_Inventory
{
    partial class MainForm
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
            DisplayListBox = new ListBox();
            OpenButton = new Button();
            AddButton = new Button();
            ExitButton = new Button();
            SaveButton = new Button();
            DeleteButton = new Button();
            SuspendLayout();
            // 
            // DisplayListBox
            // 
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.ItemHeight = 25;
            DisplayListBox.Location = new Point(12, 65);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(584, 204);
            DisplayListBox.TabIndex = 0;
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(12, 12);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(112, 34);
            OpenButton.TabIndex = 1;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(130, 12);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(112, 34);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add Item";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(484, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 34);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(367, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(112, 34);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(249, 12);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(112, 34);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Delete Item";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 281);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(ExitButton);
            Controls.Add(AddButton);
            Controls.Add(OpenButton);
            Controls.Add(DisplayListBox);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private ListBox DisplayListBox;
        private Button OpenButton;
        private Button AddButton;
        private Button ExitButton;
        private Button SaveButton;
        private Button DeleteButton;
    }
}