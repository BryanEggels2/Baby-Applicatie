namespace Killer_app
{
    partial class frm_settings
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
            this.tb_voornaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_achternaam = new System.Windows.Forms.TextBox();
            this.cb_geslacht = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tb_voornaam
            // 
            this.tb_voornaam.Location = new System.Drawing.Point(106, 13);
            this.tb_voornaam.Name = "tb_voornaam";
            this.tb_voornaam.Size = new System.Drawing.Size(100, 20);
            this.tb_voornaam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Achternaam";
            // 
            // tb_achternaam
            // 
            this.tb_achternaam.Location = new System.Drawing.Point(106, 39);
            this.tb_achternaam.Name = "tb_achternaam";
            this.tb_achternaam.Size = new System.Drawing.Size(100, 20);
            this.tb_achternaam.TabIndex = 2;
            // 
            // cb_geslacht
            // 
            this.cb_geslacht.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_geslacht.FormattingEnabled = true;
            this.cb_geslacht.Items.AddRange(new object[] {
            "Man",
            "Vrouw"});
            this.cb_geslacht.Location = new System.Drawing.Point(106, 66);
            this.cb_geslacht.Name = "cb_geslacht";
            this.cb_geslacht.Size = new System.Drawing.Size(100, 21);
            this.cb_geslacht.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Geslacht";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Geboortedatum";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(307, 207);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "Add";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(4, 207);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(96, 23);
            this.del_button.TabIndex = 9;
            this.del_button.Text = "DELETE ALL";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 242);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_geslacht);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_achternaam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_voornaam);
            this.Name = "frm_settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_voornaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_achternaam;
        private System.Windows.Forms.ComboBox cb_geslacht;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}