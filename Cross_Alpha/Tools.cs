using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Cross_Alpha
{
    class Tools
    {
        private MySqlConnection connection;

        private void InitConnection()
        {
            this.connection = new MySqlConnection("SERVER=127.0.0.1;DATABASE=cross_alpha;UID=root;PASSWORD=");
        }

        public Tools()
        {
            this.InitConnection();
        }

        public ArrayList Read_Name(string name)
        {
            ArrayList Name_List = new ArrayList();
            try
            {
                this.connection.Open();
                MySqlCommand get_Name = this.connection.CreateCommand();
                get_Name.CommandText = "SELECT Nom FROM eleve WHERE Nom LIKE '" + name + "%' ORDER BY Nom ASC";
                MySqlDataReader Lire = get_Name.ExecuteReader();
                while (Lire.Read())
                    Name_List.Add(Lire.GetString("Nom"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.connection.Close();
            return Name_List;
        }

        public ArrayList Read_Firstname(string name)
        {
            ArrayList Firstname_List = new ArrayList();
            try
            {
                this.connection.Open();
                MySqlCommand get_Firstname = this.connection.CreateCommand();
                get_Firstname.CommandText = "SELECT Prenom FROM eleve WHERE Nom LIKE '" + name + "%' ORDER BY Nom ASC";
                MySqlDataReader Lire = get_Firstname.ExecuteReader();
                while (Lire.Read())
                    Firstname_List.Add(Lire.GetString("Prenom"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.connection.Close();
            return Firstname_List;
        }


        public string[] Read_Data(String name, String firstname)
        {
            string[] Data = new string[1];
            try
            {
                this.connection.Open();
                MySqlCommand lire_D = this.connection.CreateCommand();
                lire_D.CommandText = "SELECT * FROM eleve WHERE Nom=@name AND Prenom=@firstname";
                lire_D.Parameters.AddWithValue("@name", name);
                lire_D.Parameters.AddWithValue("@firstname", firstname);
                MySqlDataReader Lire = lire_D.ExecuteReader();
                while (Lire.Read())
                {
                    Data[0] = Lire.GetString("Classe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.connection.Close();
            return Data;
        }

        public List<string> Get_race_types()
        {
            List<string> race = new List<string>();
            try
            {
                this.connection.Open();
                MySqlCommand check_race_type = this.connection.CreateCommand();
                check_race_type.CommandText = "SELECT Parcours FROM `course`";
                MySqlDataReader Read_2 = check_race_type.ExecuteReader();
                while (Read_2.Read())
                    race.Add(Read_2.GetString("Parcours"));
            }
            catch (Exception ex)
            {
                this.connection.Close();
                MessageBox.Show(ex.Message);
            }
            this.connection.Close();
            return race;
        }
        
        public string Get_race_id(string race_type)
        {
            string res = "";
            try
            {
                this.connection.Open();
                MySqlCommand check_race_type = this.connection.CreateCommand();
                check_race_type.CommandText = "SELECT Parcours FROM course WHERE race_type=@race_type";
                check_race_type.Parameters.AddWithValue("@race_type", race_type);
                MySqlDataReader Read_2 = check_race_type.ExecuteReader();
                while (Read_2.Read())
                    res = Read_2.GetString("Parcours");
                this.connection.Close();
                return res;
            }
            catch (Exception ex)
            {
                this.connection.Close();
                MessageBox.Show(ex.Message);
                return res;
            }
        }

        private string Rfid_to_ID_parcours(string rfid)
        {
            string res = "";
            try
            {
                this.connection.Open();
                MySqlCommand check_race_type = this.connection.CreateCommand();
                check_race_type.CommandText = "SELECT ID_parcours FROM eleve WHERE RFID=@rfid";
                check_race_type.Parameters.AddWithValue("@rfid", rfid);
                MySqlDataReader Read_2 = check_race_type.ExecuteReader();
                while (Read_2.Read())
                    res = Read_2.GetString("ID_parcours");
                this.connection.Close();
                Debug.Print("ID Parcours : " + res);
                return res;
            }
            catch (Exception ex)
            {
                this.connection.Close();
                MessageBox.Show(ex.Message);
                return res;
            }
        }

        private string Parcours_to_ID(string race)
        {
            string res = "";
            try
            {
                this.connection.Open();
                MySqlCommand check_race_type = this.connection.CreateCommand();
                check_race_type.CommandText = "SELECT ID FROM course WHERE Parcours=@race";
                check_race_type.Parameters.AddWithValue("@race", race);
                MySqlDataReader Read_2 = check_race_type.ExecuteReader();
                while (Read_2.Read())
                    res = Read_2.GetString("ID");
                this.connection.Close();
                Debug.Print("ID : " + res);
                return res;
            }
            catch (Exception ex)
            {
                this.connection.Close();
                MessageBox.Show(ex.Message);
                return res;
            }
        }

        public bool Race_compare(string rfid, string race)
        {
            if (String.Equals(Rfid_to_ID_parcours(rfid), Parcours_to_ID(race)) == true)
                return true;
            else
                return false;


        }


        public void Add_data(string rfid, string time, int rank, string race_type)
        {
            try
            {
                this.connection.Open();
                MySqlCommand add = this.connection.CreateCommand();
                add.CommandText = "INSERT INTO classement(Classement, Chronometre, Eleve_rfid, Course_id) VALUES (@rank, @time, @rfid, @type)";
                add.Parameters.AddWithValue("@rfid", rfid);
                add.Parameters.AddWithValue("@time", time);
                add.Parameters.AddWithValue("@rank", rank);
                add.Parameters.AddWithValue("@type", race_type);
                add.ExecuteNonQuery();
                this.connection.Close();
            }
            catch (Exception ex)
            {
                this.connection.Close();
                MessageBox.Show(ex.Message);
            }
            this.connection.Close();
        }

        public void Add_RFID(string RFID, string Name, string Firstname, string Classe)
        {
            {
                try
                {
                    this.connection.Open();
                    MySqlCommand insert_RFID = this.connection.CreateCommand();
                    insert_RFID.CommandText = "UPDATE eleve SET RFID=@RFID WHERE Nom=@name AND Prenom=@firstname AND Classe=@Classe";
                    insert_RFID.Parameters.AddWithValue("@RFID", RFID);
                    insert_RFID.Parameters.AddWithValue("@Name", Name);
                    insert_RFID.Parameters.AddWithValue("@Firstname", Firstname);
                    insert_RFID.Parameters.AddWithValue("@Classe", Classe);
                    insert_RFID.ExecuteNonQuery();
                    this.connection.Close();
                }
                catch (Exception ex)
                {
                    this.connection.Close();
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public string Get_complete_name(string rfid)
        {
            String Data = "";
            try
            {
                this.connection.Open();
                MySqlCommand lire_D = this.connection.CreateCommand();
                lire_D.CommandText = "SELECT * FROM eleve WHERE rfid=@rfid";
                lire_D.Parameters.AddWithValue("@rfid", rfid);
                MySqlDataReader Lire = lire_D.ExecuteReader();
                while (Lire.Read())
                {
                    Data = Lire.GetString("Nom");
                    Data += " ";
                    Data += Lire.GetString("Prenom");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                this.connection.Close();
            return Data;
        }

        public void Rfid_to_Rank(string rfid)
        {
            try
            {
                this.connection.Open();
                //MySqlCommand;
            }
            catch (Exception ex)
            {
                this.connection.Close();
                MessageBox.Show(ex.Message);
            }
        
        }

    }
}