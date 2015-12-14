namespace Hw5
{
    partial class MainForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.Label();
            this.surName = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.ageUpDown = new System.Windows.Forms.NumericUpDown();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(40, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 327);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.Location = new System.Drawing.Point(331, 75);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 17);
            this.name.TabIndex = 1;
            this.name.Text = "Name:";
            // 
            // surName
            // 
            this.surName.AutoSize = true;
            this.surName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surName.Location = new System.Drawing.Point(331, 107);
            this.surName.Name = "surName";
            this.surName.Size = new System.Drawing.Size(77, 17);
            this.surName.TabIndex = 2;
            this.surName.Text = "Surname:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.Location = new System.Drawing.Point(331, 144);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(58, 17);
            this.email.TabIndex = 3;
            this.email.Text = "E-Mail:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.age.Location = new System.Drawing.Point(352, 190);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(41, 17);
            this.age.TabIndex = 4;
            this.age.Text = "Age:";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city.Location = new System.Drawing.Point(352, 237);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(40, 17);
            this.city.TabIndex = 5;
            this.city.Text = "City:";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNumber.Location = new System.Drawing.Point(279, 283);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(120, 17);
            this.phoneNumber.TabIndex = 6;
            this.phoneNumber.Text = "Phone Number:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genderLabel.Location = new System.Drawing.Point(331, 320);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(67, 17);
            this.genderLabel.TabIndex = 7;
            this.genderLabel.Text = "Gender:";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(405, 75);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(116, 23);
            this.nameText.TabIndex = 8;
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(405, 107);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(116, 23);
            this.surnameText.TabIndex = 9;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(405, 144);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(116, 23);
            this.emailText.TabIndex = 10;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(405, 280);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(116, 23);
            this.phoneText.TabIndex = 13;
            // 
            // ageUpDown
            // 
            this.ageUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ageUpDown.Location = new System.Drawing.Point(406, 188);
            this.ageUpDown.Name = "ageUpDown";
            this.ageUpDown.Size = new System.Drawing.Size(68, 23);
            this.ageUpDown.TabIndex = 15;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maleRadio.Location = new System.Drawing.Point(405, 318);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(59, 21);
            this.maleRadio.TabIndex = 16;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.femaleRadio.Location = new System.Drawing.Point(478, 316);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(75, 21);
            this.femaleRadio.TabIndex = 17;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(590, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 269);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newButton.Location = new System.Drawing.Point(342, 388);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(121, 34);
            this.newButton.TabIndex = 19;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateButton.Location = new System.Drawing.Point(516, 388);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(106, 34);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButton.Location = new System.Drawing.Point(662, 388);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(115, 34);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(406, 237);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(140, 25);
            this.cityComboBox.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 499);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.femaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.ageUpDown);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.city);
            this.Controls.Add(this.age);
            this.Controls.Add(this.email);
            this.Controls.Add(this.surName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surName;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.NumericUpDown ageUpDown;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox cityComboBox;
    }
}

