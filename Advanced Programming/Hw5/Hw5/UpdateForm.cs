using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw5
{
    public partial class UpdateForm : Form
    {
        Person person = new Person();
        MainForm form;
        public UpdateForm()
        {
            InitializeComponent();

        }
        public UpdateForm(Person person, MainForm form)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            this.cityComboBox.Items.Add("New York");
            this.cityComboBox.Items.Add("Eskişehir");
            this.person = person;
            this.form = form;
            this.nameText.Text = person.name;
            this.surnameText.Text = person.surname;
            this.emailText.Text = person.email;
            this.pictureBox1.Image = person.img;
            this.phoneText.Text = person.phoneNumber.ToString();
            if (person.gender.Equals("Male"))
                maleRadio.Select();
            else femaleRadio.Select();
            this.ageUpDown.Value = person.age;
            this.cityComboBox.Text = person.city;


        }

        private void changeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();



            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                person.img = pictureBox1.Image;
            }


        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.nameText.Text))
            {
                person.name = this.nameText.Text;
            }


            else
            {
                MessageBox.Show("Please fill the name", "Warning");
                return;
            }

            if (!string.IsNullOrEmpty(this.surnameText.Text))
            {
                person.surname = this.surnameText.Text;
            }
            else
            {
                MessageBox.Show("Please fill the Surname", "Warning");
                return;
            }

            if (!string.IsNullOrEmpty(this.cityComboBox.Text))
                person.city = this.cityComboBox.Text;
            else
            {
                MessageBox.Show("Please enter city", "Warning");
                return;
            }




            bool isNumeric = long.TryParse(this.phoneText.Text, out person.phoneNumber);
            if (!isNumeric)
            {
                MessageBox.Show("Please enter valid phonenumber");
                return;
            }
     
            if (!string.IsNullOrEmpty(this.emailText.Text))
            {
                person.email = this.emailText.Text;
            }
            else
            {
                MessageBox.Show("Please enter email", "Warning");
                return;
            }

            if (!string.IsNullOrEmpty(this.ageUpDown.Value.ToString()) && this.ageUpDown.Value>0)
            {
                person.age = Convert.ToInt32(this.ageUpDown.Value);

            }
            else
            {
                MessageBox.Show("Please enter valid age", "Warning");
                return;
            }


            if (maleRadio.Checked || femaleRadio.Checked)
            {
                person.gender = (femaleRadio.Checked) ? "Female" : "Male";
            }
            else
            {
                MessageBox.Show("Please choose gender", "Warning");
                return;
            }
           
                form.refresh();
                this.Dispose();
            


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
