namespace SavePersonNameApp
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
            this.personNameTextbox = new System.Windows.Forms.TextBox();
            this.nameSavebutton = new System.Windows.Forms.Button();
            this.saveAllbutton = new System.Windows.Forms.Button();
            this.PersonNameListBox = new System.Windows.Forms.ListBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name:";
            // 
            // personNameTextbox
            // 
            this.personNameTextbox.Location = new System.Drawing.Point(144, 39);
            this.personNameTextbox.Name = "personNameTextbox";
            this.personNameTextbox.Size = new System.Drawing.Size(144, 20);
            this.personNameTextbox.TabIndex = 1;
            // 
            // nameSavebutton
            // 
            this.nameSavebutton.Location = new System.Drawing.Point(294, 39);
            this.nameSavebutton.Name = "nameSavebutton";
            this.nameSavebutton.Size = new System.Drawing.Size(75, 23);
            this.nameSavebutton.TabIndex = 2;
            this.nameSavebutton.Text = "Save";
            this.nameSavebutton.UseVisualStyleBackColor = true;
            this.nameSavebutton.Click += new System.EventHandler(this.nameSavebutton_Click);
            // 
            // saveAllbutton
            // 
            this.saveAllbutton.Location = new System.Drawing.Point(294, 82);
            this.saveAllbutton.Name = "saveAllbutton";
            this.saveAllbutton.Size = new System.Drawing.Size(75, 23);
            this.saveAllbutton.TabIndex = 3;
            this.saveAllbutton.Text = "Save All";
            this.saveAllbutton.UseVisualStyleBackColor = true;
            this.saveAllbutton.Click += new System.EventHandler(this.saveAllbutton_Click);
            // 
            // PersonNameListBox
            // 
            this.PersonNameListBox.FormattingEnabled = true;
            this.PersonNameListBox.Location = new System.Drawing.Point(112, 124);
            this.PersonNameListBox.Name = "PersonNameListBox";
            this.PersonNameListBox.Size = new System.Drawing.Size(176, 134);
            this.PersonNameListBox.TabIndex = 4;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(141, 87);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(35, 13);
            this.countLabel.TabIndex = 5;
            this.countLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 332);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.PersonNameListBox);
            this.Controls.Add(this.saveAllbutton);
            this.Controls.Add(this.nameSavebutton);
            this.Controls.Add(this.personNameTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personNameTextbox;
        private System.Windows.Forms.Button nameSavebutton;
        private System.Windows.Forms.Button saveAllbutton;
        private System.Windows.Forms.ListBox PersonNameListBox;
        private System.Windows.Forms.Label countLabel;
    }
}

