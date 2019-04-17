namespace Cross_Alpha
{
    partial class Race
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
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.time_elapsed = new System.Windows.Forms.Label();
            this.race_type = new System.Windows.Forms.ComboBox();
            this.button_return = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.name_1 = new System.Windows.Forms.Label();
            this.name_2 = new System.Windows.Forms.Label();
            this.name_3 = new System.Windows.Forms.Label();
            this.time_3 = new System.Windows.Forms.Label();
            this.time_2 = new System.Windows.Forms.Label();
            this.time_1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Classement = new System.Windows.Forms.GroupBox();
            this.rank_show = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Classement.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Gray;
            this.button_start.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_start.FlatAppearance.BorderSize = 3;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.Color.Snow;
            this.button_start.Location = new System.Drawing.Point(547, 291);
            this.button_start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(330, 113);
            this.button_start.TabIndex = 3;
            this.button_start.TabStop = false;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.Gray;
            this.button_stop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_stop.FlatAppearance.BorderSize = 3;
            this.button_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stop.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stop.ForeColor = System.Drawing.Color.Snow;
            this.button_stop.Location = new System.Drawing.Point(7, 291);
            this.button_stop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(330, 113);
            this.button_stop.TabIndex = 4;
            this.button_stop.TabStop = false;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // time_elapsed
            // 
            this.time_elapsed.AutoSize = true;
            this.time_elapsed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time_elapsed.Font = new System.Drawing.Font("Cooper Black", 105F);
            this.time_elapsed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.time_elapsed.Location = new System.Drawing.Point(7, 86);
            this.time_elapsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_elapsed.Name = "time_elapsed";
            this.time_elapsed.Size = new System.Drawing.Size(866, 161);
            this.time_elapsed.TabIndex = 5;
            this.time_elapsed.Text = "00:00:00.00";
            this.time_elapsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // race_type
            // 
            this.race_type.BackColor = System.Drawing.Color.DarkGray;
            this.race_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.race_type.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race_type.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.race_type.FormattingEnabled = true;
            this.race_type.IntegralHeight = false;
            this.race_type.Location = new System.Drawing.Point(11, 19);
            this.race_type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.race_type.Name = "race_type";
            this.race_type.Size = new System.Drawing.Size(188, 27);
            this.race_type.TabIndex = 6;
            this.race_type.DropDown += new System.EventHandler(this.race_type_DropDown);
            // 
            // button_return
            // 
            this.button_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_return.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.button_return.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_return.Location = new System.Drawing.Point(12, 1000);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(199, 68);
            this.button_return.TabIndex = 15;
            this.button_return.TabStop = false;
            this.button_return.Text = "Retour";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_close
            // 
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_close.Location = new System.Drawing.Point(1709, 1000);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(199, 68);
            this.button_close.TabIndex = 14;
            this.button_close.TabStop = false;
            this.button_close.Text = "Fermer";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.Gray;
            this.button_reset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_reset.FlatAppearance.BorderSize = 3;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.Snow;
            this.button_reset.Location = new System.Drawing.Point(345, 291);
            this.button_reset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(194, 113);
            this.button_reset.TabIndex = 16;
            this.button_reset.TabStop = false;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // name_1
            // 
            this.name_1.AutoSize = true;
            this.name_1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.name_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name_1.Location = new System.Drawing.Point(17, 70);
            this.name_1.Name = "name_1";
            this.name_1.Size = new System.Drawing.Size(99, 19);
            this.name_1.TabIndex = 19;
            this.name_1.Text = "1ère place :";
            // 
            // name_2
            // 
            this.name_2.AutoSize = true;
            this.name_2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.name_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name_2.Location = new System.Drawing.Point(17, 132);
            this.name_2.Name = "name_2";
            this.name_2.Size = new System.Drawing.Size(109, 19);
            this.name_2.TabIndex = 20;
            this.name_2.Text = "2ème place : ";
            // 
            // name_3
            // 
            this.name_3.AutoSize = true;
            this.name_3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.name_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name_3.Location = new System.Drawing.Point(17, 200);
            this.name_3.Name = "name_3";
            this.name_3.Size = new System.Drawing.Size(109, 19);
            this.name_3.TabIndex = 21;
            this.name_3.Text = "3ème place : ";
            // 
            // time_3
            // 
            this.time_3.AutoSize = true;
            this.time_3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.time_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time_3.Location = new System.Drawing.Point(17, 229);
            this.time_3.Name = "time_3";
            this.time_3.Size = new System.Drawing.Size(0, 19);
            this.time_3.TabIndex = 24;
            // 
            // time_2
            // 
            this.time_2.AutoSize = true;
            this.time_2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.time_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time_2.Location = new System.Drawing.Point(17, 160);
            this.time_2.Name = "time_2";
            this.time_2.Size = new System.Drawing.Size(0, 19);
            this.time_2.TabIndex = 23;
            // 
            // time_1
            // 
            this.time_1.AutoSize = true;
            this.time_1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.time_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time_1.Location = new System.Drawing.Point(17, 98);
            this.time_1.Name = "time_1";
            this.time_1.Size = new System.Drawing.Size(0, 19);
            this.time_1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ok_button);
            this.groupBox1.Controls.Add(this.button_reset);
            this.groupBox1.Controls.Add(this.race_type);
            this.groupBox1.Controls.Add(this.time_elapsed);
            this.groupBox1.Controls.Add(this.button_stop);
            this.groupBox1.Controls.Add(this.button_start);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 410);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(232, 22);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 17;
            this.ok_button.TabStop = false;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.time_2);
            this.groupBox2.Controls.Add(this.name_1);
            this.groupBox2.Controls.Add(this.time_3);
            this.groupBox2.Controls.Add(this.name_2);
            this.groupBox2.Controls.Add(this.name_3);
            this.groupBox2.Controls.Add(this.time_1);
            this.groupBox2.Location = new System.Drawing.Point(902, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 410);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(99, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Podium";
            // 
            // Classement
            // 
            this.Classement.Controls.Add(this.rank_show);
            this.Classement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Classement.Location = new System.Drawing.Point(1379, 65);
            this.Classement.Name = "Classement";
            this.Classement.Size = new System.Drawing.Size(529, 409);
            this.Classement.TabIndex = 28;
            this.Classement.TabStop = false;
            this.Classement.Text = "Classement";
            // 
            // rank_show
            // 
            this.rank_show.AutoSize = true;
            this.rank_show.Location = new System.Drawing.Point(20, 32);
            this.rank_show.Name = "rank_show";
            this.rank_show.Size = new System.Drawing.Size(0, 13);
            this.rank_show.TabIndex = 0;
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1920, 1021);
            this.ControlBox = false;
            this.Controls.Add(this.Classement);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_close);
            this.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Race";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Race_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Race_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Classement.ResumeLayout(false);
            this.Classement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label time_elapsed;
        private System.Windows.Forms.ComboBox race_type;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label name_1;
        private System.Windows.Forms.Label name_2;
        private System.Windows.Forms.Label name_3;
        private System.Windows.Forms.Label time_3;
        private System.Windows.Forms.Label time_2;
        private System.Windows.Forms.Label time_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Classement;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label rank_show;
    }
}