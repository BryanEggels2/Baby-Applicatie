using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Killer_app
{
    public partial class frm_settings : Form
    {
        private readonly Action _update;
        
        Query query = new Query();
        public frm_settings(Action update)//pass de functie om de combobox te updaten
        {
            InitializeComponent();
            cb_geslacht.DropDownStyle = ComboBoxStyle.DropDownList; //readonly combobox
            _update = update;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Baby nieuwe_baby = new Baby();
            nieuwe_baby.voornaam = tb_voornaam.Text;
            nieuwe_baby.achternaam = tb_achternaam.Text;
            nieuwe_baby.geslacht = comboboxcheck();
            nieuwe_baby.leeftijd = 50;
            nieuwe_baby.Insert();
            _update();
            this.Close();
            
            
        }
        private char comboboxcheck()
        {
            if (cb_geslacht.Text == "Man")
            {
                return 'M';
            }
            else
            {
                return 'V';
            }
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            query.Delete("Baby");
            _update();
        }

    }

}
