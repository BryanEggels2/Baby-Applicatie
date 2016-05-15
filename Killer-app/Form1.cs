using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Killer_app
{
    public partial class Form1 : Form
    {
        Query query = new Query(); //nieuwe query class aanmaken om queries te lezen/invoeren en deleten.
        DateTime datum = DateTime.Now;
        public Form1()  
        {
            InitializeComponent();
            string sqldate = datum.ToString("yyyy-MM-dd");
            lbl_date.Text = sqldate.ToString();
            combobox_add();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            int i = 0;
            int babyid = (comboBox1.SelectedItem as Baby).id;
            if (tb_slapen.Text == "" && tb_huilen.Text == "" && tb_wassen.Text == "")
            {
                MessageBox.Show("please use the textboxes");
            }

            if (Int32.TryParse(tb_huilen.Text, out i)) //als het een integer is, invoeren in de database
            {
                query.Insert(babyid, "1", tb_huilen.Text);
                    
            }
            if(Int32.TryParse(tb_slapen.Text, out i)) //als het een integer is, invoeren in de database
            {
                query.Insert(babyid, "2", tb_slapen.Text);
            }
            if (Int32.TryParse(tb_wassen.Text, out i)) //als het een integer is, invoeren in de database
            {
                query.Insert(babyid, "3", tb_wassen.Text);
            }
            
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            int babyid = (comboBox1.SelectedItem as Baby).id;
            lbl_huiltotaal.Text = query.Select(babyid.ToString(), 1.ToString()).ToString(); //lees de kolom "Huilen" uit.
            lbl_slaaptotaal.Text = query.Select(babyid.ToString(), 2.ToString()).ToString(); //lees de kolom "Slapen" uit.
            lbl_wastotaal.Text = query.Select(babyid.ToString(), 3.ToString()).ToString();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            query.Delete("Baby_eigenschappen"); //delete de tabel Baby_eigenschappen
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            frm_settings settings = new frm_settings(this.combobox_add);
            settings.Show();
        }
        private void combobox_add()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = query.namen();

            comboBox1.DisplayMember = "voornaam";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = bs;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_huiltotaal.Text = query.Select((comboBox1.SelectedItem as Baby).id.ToString(), 1.ToString()).ToString();
            lbl_slaaptotaal.Text = query.Select((comboBox1.SelectedItem as Baby).id.ToString(), 2.ToString()).ToString();
            lbl_wastotaal.Text = query.Select((comboBox1.SelectedItem as Baby).id.ToString(), 3.ToString()).ToString();
        }
    }
}



