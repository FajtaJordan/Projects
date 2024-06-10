using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace adatbazis_feladat
{
    internal class adatbazis
    {
        string kapcs_string; //ebbe megy bele a kapcsolat parancsa
        MySqlConnection kapcsolat;
        MySqlCommand parancs;
        string parancs_string;
        MySqlDataAdapter adapter;

        public adatbazis(string K)
        {
            kapcs_string = K;
        }
        public adatbazis(string S, string D, string U, string P)
        {
            //elso korben trimelunk
            S = S.Trim(); D = D.Trim(); U = U.Trim(); P = P.Trim();
            //megnezuk hogy van e pontos vesszo a vegen ha van eltavolitom
            if (S.Last() == ';') S = S.Remove(S.Length - 1, 1);
            if (D.Last() == ';') D = D.Remove(D.Length - 1, 1);
            if (U.Last() == ';') U = U.Remove(U.Length - 1, 1);
            if (P.Last() == ';') P = P.Remove(P.Length - 1, 1);
            //kapcsoolati string eloallitasa
            kapcs_string = S + ";" + D + ";" + U + ";" + P + ";";
        }
        private bool megnyitas()
        {
            try
            {
                kapcsolat = new MySqlConnection(kapcs_string);
                kapcsolat.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool bezaras()
        {
            try
            {
                kapcsolat.Close();
                return true;
            }
            catch { return false; }
        }
        public string SzamLekerdezes(string lekerdezes)
        {
            bezaras();
            if (megnyitas())
            {
                try
                {
                    parancs = new MySqlCommand(lekerdezes, kapcsolat);
                    return parancs.ExecuteScalar().ToString();
                }
                catch { return "hiba"; }
            }
            else return "hiba";
        }
        public List<string> ListaLekerdezes(string lekerdezes)
        {
            bezaras();
            List<string> L = new List<string>();
            if (megnyitas())
            {
                try
                {
                    parancs = new MySqlCommand(lekerdezes, kapcsolat);
                    MySqlDataReader olvas = parancs.ExecuteReader();
                    while (olvas.Read())
                    {
                        L.Add(olvas[0].ToString());
                    }
                }
                catch (Exception ex)
                {
                    L.Add("hiba");
                    L.Add(ex.ToString());

                }
            }
            else
            {
                L.Add("Hiba");
            }
            return L;
        }
        public bool DblDml(string lekerdezes)
        {
            bezaras();
            if (megnyitas())
            {
                try
                {
                    parancs = new MySqlCommand();
                    parancs.CommandText = lekerdezes;
                    parancs.Connection = kapcsolat;
                    parancs.ExecuteNonQuery();
                    bezaras();
                    return true;
                }
                catch
                {
                    return false;

                }
            }
            return false;
        }
        public DataSet TablazatLekerdezes(string lekerdezes)
        {
            bezaras();
            DataSet adatok = new DataSet();
            if (megnyitas())
            {
                try
                {
                    adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = new MySqlCommand(lekerdezes, kapcsolat);
                    adapter.Fill(adatok);
                    return adatok;

                }
                catch
                {


                }
            }
            return adatok;
        }
    }
}
