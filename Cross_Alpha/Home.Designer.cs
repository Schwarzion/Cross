namespace Cross_Alpha
{
    partial class Home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.register_button = new System.Windows.Forms.Button();
            this.Race_button = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.Gray;
            this.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_button.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.Color.Transparent;
            this.register_button.Location = new System.Drawing.Point(14, 95);
            this.register_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(217, 74);
            this.register_button.TabIndex = 0;
            this.register_button.TabStop = false;
            this.register_button.Text = "Enregistrement";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Race_button
            // 
            this.Race_button.BackColor = System.Drawing.Color.Gray;
            this.Race_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Race_button.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Race_button.ForeColor = System.Drawing.Color.Transparent;
            this.Race_button.Location = new System.Drawing.Point(14, 13);
            this.Race_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Race_button.Name = "Race_button";
            this.Race_button.Size = new System.Drawing.Size(217, 74);
            this.Race_button.TabIndex = 1;
            this.Race_button.TabStop = false;
            this.Race_button.Text = "Course";
            this.Race_button.UseVisualStyleBackColor = false;
            this.Race_button.Click += new System.EventHandler(this.Race_button_Click);
            // 
            // button_close
            // 
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.button_close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_close.Location = new System.Drawing.Point(146, 176);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(85, 26);
            this.button_close.TabIndex = 15;
            this.button_close.TabStop = false;
            this.button_close.Text = "Fermer";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(14, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 26);
            this.button3.TabIndex = 16;
            this.button3.TabStop = false;
            this.button3.Text = "Help!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_help_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(245, 214);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.Race_button);
            this.Controls.Add(this.register_button);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button Race_button;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button3;
    }
}

