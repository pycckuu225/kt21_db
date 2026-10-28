namespace WindowsFormsApp24
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblHouse = new System.Windows.Forms.Label();
            this.lblFlat = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblHobby = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.txtFlat = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.txtHobby = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.Location = new System.Drawing.Point(31, 40);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(123, 29);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Фамилия";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(31, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Имя";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirth.Location = new System.Drawing.Point(31, 134);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(191, 29);
            this.lblBirth.TabIndex = 2;
            this.lblBirth.Text = "Дата рождения";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSex.Location = new System.Drawing.Point(31, 187);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(59, 29);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "Пол";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStreet.Location = new System.Drawing.Point(31, 240);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(88, 29);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Улица";
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHouse.Location = new System.Drawing.Point(474, 40);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(61, 29);
            this.lblHouse.TabIndex = 5;
            this.lblHouse.Text = "Дом";
            // 
            // lblFlat
            // 
            this.lblFlat.AutoSize = true;
            this.lblFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFlat.Location = new System.Drawing.Point(474, 87);
            this.lblFlat.Name = "lblFlat";
            this.lblFlat.Size = new System.Drawing.Size(123, 29);
            this.lblFlat.TabIndex = 6;
            this.lblFlat.Text = "Квартира";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClass.Location = new System.Drawing.Point(474, 134);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(81, 29);
            this.lblClass.TabIndex = 7;
            this.lblClass.Text = "Класс";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroup.Location = new System.Drawing.Point(474, 187);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(95, 29);
            this.lblGroup.TabIndex = 8;
            this.lblGroup.Text = "Группа";
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHobby.Location = new System.Drawing.Point(474, 240);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(87, 29);
            this.lblHobby.TabIndex = 9;
            this.lblHobby.Text = "Хобби";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSurname.Location = new System.Drawing.Point(233, 37);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(203, 35);
            this.txtSurname.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(233, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 35);
            this.txtName.TabIndex = 11;
            // 
            // dtpBirth
            // 
            this.dtpBirth.CustomFormat = "dd.MM.yyyy";
            this.dtpBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirth.Location = new System.Drawing.Point(233, 133);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(203, 35);
            this.dtpBirth.TabIndex = 12;
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkMale.Location = new System.Drawing.Point(233, 192);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(139, 33);
            this.chkMale.TabIndex = 13;
            this.chkMale.Text = "Мужской";
            this.chkMale.UseVisualStyleBackColor = true;
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStreet.Location = new System.Drawing.Point(233, 237);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(203, 35);
            this.txtStreet.TabIndex = 14;
            // 
            // txtHouse
            // 
            this.txtHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHouse.Location = new System.Drawing.Point(615, 37);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(203, 35);
            this.txtHouse.TabIndex = 15;
            // 
            // txtFlat
            // 
            this.txtFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFlat.Location = new System.Drawing.Point(615, 84);
            this.txtFlat.Name = "txtFlat";
            this.txtFlat.Size = new System.Drawing.Size(203, 35);
            this.txtFlat.TabIndex = 16;
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtClass.Location = new System.Drawing.Point(615, 131);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(203, 35);
            this.txtClass.TabIndex = 17;
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(615, 186);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(203, 37);
            this.cmbGroup.TabIndex = 18;
            // 
            // txtHobby
            // 
            this.txtHobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHobby.Location = new System.Drawing.Point(615, 237);
            this.txtHobby.Name = "txtHobby";
            this.txtHobby.Size = new System.Drawing.Size(203, 35);
            this.txtHobby.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(511, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(345, 53);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Внести изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 375);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtHobby);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtFlat);
            this.Controls.Add(this.txtHouse);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblFlat);
            this.Controls.Add(this.lblHouse);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSurname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.Label lblFlat;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.TextBox txtFlat;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.TextBox txtHobby;
        private System.Windows.Forms.Button btnSave;
    }
}