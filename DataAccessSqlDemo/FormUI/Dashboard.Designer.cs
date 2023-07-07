namespace FormUI
{
  partial class Dashboard
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
      this.personsFoundListBox = new System.Windows.Forms.ListBox();
      this.lastNameLabel = new System.Windows.Forms.Label();
      this.lastNameTextBox = new System.Windows.Forms.TextBox();
      this.searchButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // personsFoundListBox
      // 
      this.personsFoundListBox.FormattingEnabled = true;
      this.personsFoundListBox.ItemHeight = 25;
      this.personsFoundListBox.Location = new System.Drawing.Point(51, 171);
      this.personsFoundListBox.Name = "personsFoundListBox";
      this.personsFoundListBox.Size = new System.Drawing.Size(526, 504);
      this.personsFoundListBox.TabIndex = 0;
      // 
      // lastNameLabel
      // 
      this.lastNameLabel.AutoSize = true;
      this.lastNameLabel.Location = new System.Drawing.Point(51, 74);
      this.lastNameLabel.Name = "lastNameLabel";
      this.lastNameLabel.Size = new System.Drawing.Size(124, 26);
      this.lastNameLabel.TabIndex = 1;
      this.lastNameLabel.Text = "Last Name:";
      // 
      // lastNameTextBox
      // 
      this.lastNameTextBox.Location = new System.Drawing.Point(181, 71);
      this.lastNameTextBox.Name = "lastNameTextBox";
      this.lastNameTextBox.Size = new System.Drawing.Size(396, 32);
      this.lastNameTextBox.TabIndex = 2;
      // 
      // searchButton
      // 
      this.searchButton.Location = new System.Drawing.Point(244, 119);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(115, 46);
      this.searchButton.TabIndex = 3;
      this.searchButton.Text = "Search";
      this.searchButton.UseVisualStyleBackColor = true;
      this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
      // 
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1131, 855);
      this.Controls.Add(this.searchButton);
      this.Controls.Add(this.lastNameTextBox);
      this.Controls.Add(this.lastNameLabel);
      this.Controls.Add(this.personsFoundListBox);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Dashboard";
      this.Text = "Data Access SQL Demo";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox personsFoundListBox;
    private System.Windows.Forms.Label lastNameLabel;
    private System.Windows.Forms.TextBox lastNameTextBox;
    private System.Windows.Forms.Button searchButton;
  }
}

