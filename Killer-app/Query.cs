using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Killer_app
{
    class Query
    {
        
        static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fam_e\OneDrive\Documenten\Visual Studio 2015\Projects\Killer-app\Killer-app\Babydatabase.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection); //nieuwe class SqlConnection om de verbinding op te zetten.
        DateTime date = DateTime.Now;
        public int Select(string Babyid, string Eigenschap)
        {
            con.Open(); //zet de verbinding op met de SQL database.
            string query = string.Format("SELECT Eigenschap,tijd FROM Baby_eigenschappen WHERE Babyid = {0} AND Eigenschap = {1}", Babyid, Eigenschap); //maakt een query string met de meegegeven kolom.
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader(); //execute de query en zet output in reader.
            int tot = 0;
            while (reader.Read())   //als er een item is, lees dit uit.
            {
                string huilen = reader[1].ToString(); //zet de huidige regel van reader in de string 'optellen'.
                if (huilen != null && huilen != "")
                {
                    tot = tot + Convert.ToInt32(huilen); //telt alles bij elkaar op om het totaal aantal minuten van de activiteit uit te rekenen.
                }
            }
            reader.Close();
            con.Close();
            return tot;
        } //Select en read.
        public void Delete(string tabel)
        {
            con.Open();
            string del = "TRUNCATE TABLE " + tabel; //query
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            con.Close();
        } //Delete tabel Baby_eigenschappen.
        public void Insert(int Babyid, string Eigenschap, string tijd)
        {
            
            string sqldate = date.ToString("yyyy-MM-dd");
            con.Open();
            string insert = string.Format("INSERT INTO Baby_eigenschappen (Babyid,Eigenschap,Tijd,Datum) VALUES ('{0}','{1}','{2}','{3}')", Babyid, Eigenschap, tijd, sqldate); //insert hetgene wat er in de tekstboxen staat.
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.ExecuteNonQuery(); //uitvoeren query
            con.Close();
            
        } //Voor het invoegen van gegevens
        public void Insert_baby(string voornaam, string achternaam, char geslacht, int leeftijd)
        {
            string sqldate = date.ToString("yyyy-MM-dd");
            con.Open();
            string insert = string.Format("INSERT INTO Baby(Naam,Achternaam,Geslacht,Leeftijd,Datum) VALUES ('{0}','{1}','{2}',{3},'{4}')"
                ,voornaam, achternaam, geslacht, leeftijd, sqldate); //insert hetgene wat er in de tekstboxen staat.
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.ExecuteNonQuery(); //uitvoeren query
            con.Close();
        } //Voor het invoegen van gegevens
        public List<Baby> namen()
        {
            con.Open();
            string select = "SELECT * FROM Baby";
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Baby> lijst = new List<Baby>();
            while (reader.Read())
            {
                lijst.Add(new Baby { id = reader.GetInt32(0), voornaam = reader["Naam"].ToString(), achternaam = reader["Achternaam"].ToString(), leeftijd = reader.GetInt32(4), geslacht = reader["Geslacht"].ToString()[0] });
            }
            con.Close();
            return lijst;
        }

    }
}
