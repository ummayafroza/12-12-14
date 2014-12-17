namespace saveNameApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameInputTextBox = new System.Windows.Forms.TextBox();
            this.saveNameButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.showAllNameButton = new System.Windows.Forms.Button();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.countNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            // 
            // nameInputTextBox
            // 
            this.nameInputTextBox.Location = new System.Drawing.Point(108, 30);
            this.nameInputTextBox.Name = "nameInputTextBox";
            this.nameInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameInputTextBox.TabIndex = 1;
            this.nameInputTextBox.TextChanged += new System.EventHandler(this.nameInputTextBox_TextChanged);
            // 
            // saveNameButton
            // 
            this.saveNameButton.Location = new System.Drawing.Point(239, 30);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(75, 23);
            this.saveNameButton.TabIndex = 2;
            this.saveNameButton.Text = "Save Name";
            this.saveNameButton.UseVisualStyleBackColor = true;
            this.saveNameButton.Click += new System.EventHandler(this.saveNameButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Count Name";
            // 
            // showAllNameButton
            // 
            this.showAllNameButton.Location = new System.Drawing.Point(239, 80);
            this.showAllNameButton.Name = "showAllNameButton";
            this.showAllNameButton.Size = new System.Drawing.Size(75, 23);
            this.showAllNameButton.TabIndex = 5;
            this.showAllNameButton.Text = "Show All";
            this.showAllNameButton.UseVisualStyleBackColor = true;
            this.showAllNameButton.Click += new System.EventHandler(this.showAllNameButton_Click);
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(108, 153);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(120, 95);
            this.nameListBox.TabIndex = 6;
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // countNameTextBox
            // 
            this.countNameTextBox.Location = new System.Drawing.Point(108, 75);
            this.countNameTextBox.Name = "countNameTextBox";
            this.countNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.countNameTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 381);
            this.Controls.Add(this.countNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.showAllNameButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveNameButton);
            this.Controls.Add(this.nameInputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Save Name in Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInputTextBox;
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showAllNameButton;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox countNameTextBox;
    }
}

