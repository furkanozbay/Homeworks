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
    public partial class AddNewUserForm : Form
    {
        MainForm mainForm;
        Person person = new Person();
        bool isComplete1 = true, isComplete2 = false;


        public AddNewUserForm()
        {
            InitializeComponent();

        }
        public AddNewUserForm(MainForm form)
        {
            InitializeComponent();
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.cityComboBox.Items.Add("New York");
            this.cityComboBox.Items.Add("Eskişehir");
            this.cityComboBox.SelectedIndex = 0;
            this.mainForm = form;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.nameText.Text)){
                person.name = this.nameText.Text;
            }
            else
            {
                MessageBox.Show("Please fill the name", "Warning");
                return;
            }

            if (!string.IsNullOrEmpty(this.surnameText.Text)){
                person.surname = this.surnameText.Text;
            }
            else
            {
                MessageBox.Show("Please fill the Surname", "Warning");
                return;
            }
            if (!string.IsNullOrEmpty(this.cityComboBox.Text))
            {
                person.city = this.cityComboBox.Text;
            }
            else
            {
                MessageBox.Show("Please choose the city", "Warning");
                return;
            }

            bool isNumeric = long.TryParse(this.phoneText.Text, out person.phoneNumber);
            if (!isNumeric)
            {
                MessageBox.Show("Please enter valid phonenumber", "Warning");
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
            if (!string.IsNullOrEmpty(this.ageButton.Value.ToString()) && this.ageButton.Value>0)
            {
                person.age = Convert.ToInt32(this.ageButton.Value);

            }
            else {
                MessageBox.Show("Please enter valid age", "Warning");
                return;
            }
            if (maleRadio.Checked || femaleRadio.Checked){
                person.gender = (femaleRadio.Checked) ? "Female" : "Male";
            }
            else
            {
                MessageBox.Show("Please choose gender", "Warning");
            }
            if (isComplete2)
            {
                mainForm.getPerson(person);
                this.Dispose();
            }
            else if (!isComplete2)
            {
                MessageBox.Show("Please select picture", "Warning");
            }
           
        }

        private void addImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();



            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                isComplete2 = true;
                person.img = pictureBox1.Image;
            }
            else if (!isComplete2)
            {
                MessageBox.Show("Please select picture", "Warning");
            }


        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
