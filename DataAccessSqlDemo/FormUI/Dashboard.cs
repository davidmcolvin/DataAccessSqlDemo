using System;
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

    DataAccess db = new DataAccess();

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

    private void buttonSearch_Click(object sender, EventArgs e)
    {
      persons = db.GetPersons(textBoxLastNameSerach.Text);

      UpdateBinding();
    }

    private void buttonInsert_Click(object sender, EventArgs e)
    {
      db.InsertPerson(textBoxFirstNameInsert.Text, textBoxLastNameInsert.Text, textBoxEmailInsert.Text, textBoxPhoneInsert.Text);
      textBoxFirstNameInsert.Text = "";
      textBoxLastNameInsert.Text = "";
      textBoxEmailInsert.Text = "";
      textBoxPhoneInsert.Text = "";

    }
  }
}
