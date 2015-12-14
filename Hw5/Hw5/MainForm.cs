using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Hw5
{
    public partial class MainForm : Form
    {
        private Person person;
        Person p2 = new Person();

        public MainForm()
        {
            InitializeComponent();
            this.Text = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.cityComboBox.Items.Add("New York");
            this.cityComboBox.Items.Add("Eskişehir");

            p2.name = "Fr";
            // this.listBox1.Items.Add(p2);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            AddNewUserForm form = new AddNewUserForm(this);
            form.ShowDialog();
        }
        public void getPerson(Person person)
        {
            this.person = person;
            addListBox(person);
        }
        public void addListBox(Person person)
        {
            this.listBox1.Items.Add(person);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                this.nameText.Text = (this.listBox1.SelectedItem as Person).name;
                this.surnameText.Text = (this.listBox1.SelectedItem as Person).surname;
                this.emailText.Text = (this.listBox1.SelectedItem as Person).email;
                this.cityComboBox.Text = (this.listBox1.SelectedItem as Person).city;
                this.ageUpDown.Value = (decimal)(person.age);
                
                this.phoneText.Text = (this.listBox1.SelectedItem as Person).phoneNumber.ToString();
                if ((this.listBox1.SelectedItem as Person).gender.Equals("Male"))
                {
                    maleRadio.Select();
                }
                else femaleRadio.Select();

                this.pictureBox1.Image = (this.listBox1.SelectedItem as Person).img;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0 && listBox1.SelectedItem!=null)
            {
                UpdateForm form = new UpdateForm((this.listBox1.SelectedItem as Person), this);
                form.ShowDialog();
            }
            else MessageBox.Show("There is no element","Warning");
        }

        public  void refresh()
        {
            listBox1.DisplayMember = "";
            listBox1.DisplayMember = "Name";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count > 0 && listBox1.SelectedItem != null)
            {
                int x = this.listBox1.SelectedIndex;
                this.listBox1.ClearSelected();
                this.listBox1.Items.RemoveAt(x);
                clearItems();
            }
            else MessageBox.Show("There is no element","Warning");

        }
        private void clearItems()
        {
            this.nameText.Text = "";
            this.surnameText.Text = "";
            this.emailText.Text = "";
            this.ageUpDown.Value = 0;
            this.cityComboBox.Text = "";
            this.maleRadio.Checked = false;
            this.femaleRadio.Checked = false;
            this.phoneText.Text = "";
            this.pictureBox1.Image = null;

        }
    }
}
