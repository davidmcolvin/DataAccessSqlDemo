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
      this.labelLastNameSearch = new System.Windows.Forms.Label();
      this.textBoxLastNameSerach = new System.Windows.Forms.TextBox();
      this.buttonSearch = new System.Windows.Forms.Button();
      this.textBoxLastNameInsert = new System.Windows.Forms.TextBox();
      this.labelLastNameInsert = new System.Windows.Forms.Label();
      this.textBoxEmailInsert = new System.Windows.Forms.TextBox();
      this.labelEmailInsert = new System.Windows.Forms.Label();
      this.textBoxPhoneInsert = new System.Windows.Forms.TextBox();
      this.labelPhoneNumberInsert = new System.Windows.Forms.Label();
      this.buttonInsert = new System.Windows.Forms.Button();
      this.textBoxFirstNameInsert = new System.Windows.Forms.TextBox();
      this.labelFirstNameInsert = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // personsFoundListBox
      // 
      this.personsFoundListBox.FormattingEnabled = true;
      this.personsFoundListBox.ItemHeight = 25;
      this.personsFoundListBox.Location = new System.Drawing.Point(51, 146);
      this.personsFoundListBox.Name = "personsFoundListBox";
      this.personsFoundListBox.Size = new System.Drawing.Size(526, 304);
      this.personsFoundListBox.TabIndex = 0;
      // 
      // labelLastNameSearch
      // 
      this.labelLastNameSearch.AutoSize = true;
      this.labelLastNameSearch.Location = new System.Drawing.Point(51, 74);
      this.labelLastNameSearch.Name = "labelLastNameSearch";
      this.labelLastNameSearch.Size = new System.Drawing.Size(124, 26);
      this.labelLastNameSearch.TabIndex = 1;
      this.labelLastNameSearch.Text = "Last Name:";
      // 
      // textBoxLastNameSerach
      // 
      this.textBoxLastNameSerach.Location = new System.Drawing.Point(181, 71);
      this.textBoxLastNameSerach.Name = "textBoxLastNameSerach";
      this.textBoxLastNameSerach.Size = new System.Drawing.Size(204, 32);
      this.textBoxLastNameSerach.TabIndex = 2;
      // 
      // buttonSearch
      // 
      this.buttonSearch.Location = new System.Drawing.Point(449, 63);
      this.buttonSearch.Name = "buttonSearch";
      this.buttonSearch.Size = new System.Drawing.Size(115, 46);
      this.buttonSearch.TabIndex = 3;
      this.buttonSearch.Text = "Search";
      this.buttonSearch.UseVisualStyleBackColor = true;
      this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
      // 
      // textBoxLastNameInsert
      // 
      this.textBoxLastNameInsert.Location = new System.Drawing.Point(181, 530);
      this.textBoxLastNameInsert.Name = "textBoxLastNameInsert";
      this.textBoxLastNameInsert.Size = new System.Drawing.Size(396, 32);
      this.textBoxLastNameInsert.TabIndex = 7;
      // 
      // labelLastNameInsert
      // 
      this.labelLastNameInsert.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
      this.labelLastNameInsert.AutoSize = true;
      this.labelLastNameInsert.Location = new System.Drawing.Point(51, 533);
      this.labelLastNameInsert.Name = "labelLastNameInsert";
      this.labelLastNameInsert.Size = new System.Drawing.Size(124, 26);
      this.labelLastNameInsert.TabIndex = 6;
      this.labelLastNameInsert.Text = "Last Name:";
      // 
      // textBoxEmailInsert
      // 
      this.textBoxEmailInsert.Location = new System.Drawing.Point(181, 580);
      this.textBoxEmailInsert.Name = "textBoxEmailInsert";
      this.textBoxEmailInsert.Size = new System.Drawing.Size(396, 32);
      this.textBoxEmailInsert.TabIndex = 9;
      // 
      // labelEmailInsert
      // 
      this.labelEmailInsert.AutoSize = true;
      this.labelEmailInsert.Location = new System.Drawing.Point(101, 583);
      this.labelEmailInsert.Name = "labelEmailInsert";
      this.labelEmailInsert.Size = new System.Drawing.Size(74, 26);
      this.labelEmailInsert.TabIndex = 8;
      this.labelEmailInsert.Text = "Email:";
      // 
      // textBoxPhoneInsert
      // 
      this.textBoxPhoneInsert.Location = new System.Drawing.Point(181, 626);
      this.textBoxPhoneInsert.Name = "textBoxPhoneInsert";
      this.textBoxPhoneInsert.Size = new System.Drawing.Size(396, 32);
      this.textBoxPhoneInsert.TabIndex = 11;
      // 
      // labelPhoneNumberInsert
      // 
      this.labelPhoneNumberInsert.AutoSize = true;
      this.labelPhoneNumberInsert.Location = new System.Drawing.Point(94, 626);
      this.labelPhoneNumberInsert.Name = "labelPhoneNumberInsert";
      this.labelPhoneNumberInsert.Size = new System.Drawing.Size(81, 26);
      this.labelPhoneNumberInsert.TabIndex = 10;
      this.labelPhoneNumberInsert.Text = "Phone:";
      // 
      // buttonInsert
      // 
      this.buttonInsert.Location = new System.Drawing.Point(250, 686);
      this.buttonInsert.Name = "buttonInsert";
      this.buttonInsert.Size = new System.Drawing.Size(115, 46);
      this.buttonInsert.TabIndex = 12;
      this.buttonInsert.Text = "Insert";
      this.buttonInsert.UseVisualStyleBackColor = true;
      this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
      // 
      // textBoxFirstNameInsert
      // 
      this.textBoxFirstNameInsert.Location = new System.Drawing.Point(181, 481);
      this.textBoxFirstNameInsert.Name = "textBoxFirstNameInsert";
      this.textBoxFirstNameInsert.Size = new System.Drawing.Size(396, 32);
      this.textBoxFirstNameInsert.TabIndex = 5;
      // 
      // labelFirstNameInsert
      // 
      this.labelFirstNameInsert.AutoSize = true;
      this.labelFirstNameInsert.Location = new System.Drawing.Point(50, 484);
      this.labelFirstNameInsert.Name = "labelFirstNameInsert";
      this.labelFirstNameInsert.Size = new System.Drawing.Size(125, 26);
      this.labelFirstNameInsert.TabIndex = 4;
      this.labelFirstNameInsert.Text = "First Name:";
      // 
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(622, 744);
      this.Controls.Add(this.textBoxFirstNameInsert);
      this.Controls.Add(this.labelFirstNameInsert);
      this.Controls.Add(this.buttonInsert);
      this.Controls.Add(this.textBoxPhoneInsert);
      this.Controls.Add(this.labelPhoneNumberInsert);
      this.Controls.Add(this.textBoxEmailInsert);
      this.Controls.Add(this.labelEmailInsert);
      this.Controls.Add(this.textBoxLastNameInsert);
      this.Controls.Add(this.labelLastNameInsert);
      this.Controls.Add(this.buttonSearch);
      this.Controls.Add(this.textBoxLastNameSerach);
      this.Controls.Add(this.labelLastNameSearch);
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
    private System.Windows.Forms.Label labelLastNameSearch;
    private System.Windows.Forms.TextBox textBoxLastNameSerach;
    private System.Windows.Forms.Button buttonSearch;
    private System.Windows.Forms.TextBox textBoxLastNameInsert;
    private System.Windows.Forms.Label labelLastNameInsert;
    private System.Windows.Forms.TextBox textBoxEmailInsert;
    private System.Windows.Forms.Label labelEmailInsert;
    private System.Windows.Forms.TextBox textBoxPhoneInsert;
    private System.Windows.Forms.Label labelPhoneNumberInsert;
    private System.Windows.Forms.Button buttonInsert;
    private System.Windows.Forms.TextBox textBoxFirstNameInsert;
    private System.Windows.Forms.Label labelFirstNameInsert;
  }
}

