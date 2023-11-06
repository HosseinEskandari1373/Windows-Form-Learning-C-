using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO
{
    public partial class Form1 : Form
    {
        Person p = new Person();
        List<Person> people = null;
        public Form1()
        {
            InitializeComponent();
            people = new List<Person>();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            //p._id = 10;
            //p._firstName = "Hossein";
            //p._lastName = "Eskandari";

            //Person p = new Person();
            //p._firstName = "Hossin";

            //Person p1 = p;

            //MessageBox.Show(p1._firstName);

            //Person p = new Person();
            //Person p1 = new Person(0);

            //MessageBox.Show(p1.Valid_Person());

            //Person p = new Person();
            //p.ID = 10001;
            //p.FirstName = "Hossein";
            //p.LastName = "Eskandari";
            //MessageBox.Show(p.ID.ToString());
            //MessageBox.Show(p.FullName);

            Person p = new Person();
            p.ID = 10001;
            p.FirstName = "حسین";
            p.LastName = "اسکندری";

            people.Add(p);

            Person p1 = new Person();
            p1.ID = 10002;
            p1.FirstName = "محمد";
            p1.LastName = "اسکندری";

            people.Add(p1);

            //ListPeople.DataSource = people;
            //ListPeople.DisplayMember = "FullName";

            GridPeople.AutoGenerateColumns = false;
            GridPeople.DataSource = people.ToList();
        }
    }
}
