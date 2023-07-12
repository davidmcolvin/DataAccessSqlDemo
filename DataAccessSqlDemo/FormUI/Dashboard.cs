﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
  public partial class Dashboard : Form
  {
    List<Person> persons = new List<Person>();

    public Dashboard()
    {
      InitializeComponent();

      UpdateBinding();
      personsFoundListBox.DisplayMember = "FullInfo";
    }

    private void UpdateBinding()
    {
      personsFoundListBox.DataSource = persons;
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
      DataAccess db = new DataAccess();

      persons = db.GetPersons(lastNameTextBox.Text);

      UpdateBinding();

    }
  }
}
