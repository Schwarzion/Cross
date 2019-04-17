namespace Cross_Alpha
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Firstname = new System.Windows.Forms.Label();
            this.label_Class = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_RFID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chercher l\'élève";
            // 
            // name_combobox
            // 
            this.name_combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.name_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_combobox.FormattingEnabled = true;
            this.name_combobox.Location = new System.Drawing.Point(156, 27);
            this.name_combobox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.name_combobox.Name = "name_combobox";
            this.name_combobox.Size = new System.Drawing.Size(180, 23);
            this.name_combobox.Sorted = true;
            this.name_combobox.TabIndex = 1;
            this.name_combobox.DropDown += new System.EventHandler(this.name_combobox_DropDown);
            this.name_combobox.SelectedIndexChanged += new System.EventHandler(this.name_combobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Infos élève";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prénom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Classe";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Name.Location = new System.Drawing.Point(98, 94);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(159, 17);
            this.label_Name.TabIndex = 6;
            this.label_Name.Text = "                                                  ";
            // 
            // label_Firstname
            // 
            this.label_Firstname.AutoSize = true;
            this.label_Firstname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Firstname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Firstname.Location = new System.Drawing.Point(98, 130);
            this.label_Firstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Firstname.Name = "label_Firstname";
            this.label_Firstname.Size = new System.Drawing.Size(84, 17);
            this.label_Firstname.TabIndex = 7;
            this.label_Firstname.Text = "                         ";
            // 
            // label_Class
            // 
            this.label_Class.AutoSize = true;
            this.label_Class.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Class.Location = new System.Drawing.Point(98, 163);
            this.label_Class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Class.Name = "label_Class";
            this.label_Class.Size = new System.Drawing.Size(84, 17);
            this.label_Class.TabIndex = 8;
            this.label_Class.Text = "                         ";
            // 
            // button_register
            // 
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Location = new System.Drawing.Point(139, 258);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(120, 26);
            this.button_register.TabIndex = 9;
            this.button_register.Text = "S\'enregistrer";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Visible = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // textBox_RFID
            // 
            this.textBox_RFID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_RFID.Location = new System.Drawing.Point(168, 198);
            this.textBox_RFID.MaxLength = 10;
            this.textBox_RFID.Multiline = true;
            this.textBox_RFID.Name = "textBox_RFID";
            this.textBox_RFID.Size = new System.Drawing.Size(100, 22);
            this.textBox_RFID.TabIndex = 10;
            this.textBox_RFID.TextChanged += new System.EventHandler(this.textBox_RFID_TextChanged);
            this.textBox_RFID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_RFID_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Scanner votre carte";
            // 
            // button_close
            // 
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(295, 258);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(85, 26);
            this.button_close.TabIndex = 12;
            this.button_close.Text = "Fermer";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_return
            // 
            this.button_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_return.Location = new System.Drawing.Point(17, 261);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(84, 23);
            this.button_return.TabIndex = 13;
            this.button_return.Text = "Retour";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(392, 296);
            this.ControlBox = false;
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_RFID);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.label_Class);
            this.Controls.Add(this.label_Firstname);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_combobox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox name_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Firstname;
        private System.Windows.Forms.Label label_Class;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox textBox_RFID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_return;
    }
}