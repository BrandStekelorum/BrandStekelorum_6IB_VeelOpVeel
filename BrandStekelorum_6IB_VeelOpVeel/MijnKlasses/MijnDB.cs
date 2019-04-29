using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using BrandStekelorum_6IB_VeelOpVeel.MijnKlasses;

namespace BrandStekelorum_6IB_VeelOpVeel.MijnKlasses
{
    class MijnDB
    {
        //velden
        static string _mijnConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\6IB\Software\databanken\VeelOpVeel.accdb";
        OleDbConnection _conn = new OleDbConnection(_mijnConn);
        //properties

        //functies en methoden
        public List<Persoon> HaalPersonenOp()
        {
            List<Persoon> antwoord = new List<Persoon>();
            string sql = "SELECT * FROM Persoon";
            OleDbCommand commando = new OleDbCommand(sql, _conn);
            OleDbDataReader mijnReader;

            int ontvId = 0;
            string ontvNaam = "";
            List<Sport> sports = new List<Sport>();

            _conn.Open();

            mijnReader = commando.ExecuteReader();
            while (mijnReader.Read())
            {
                ontvId = Convert.ToInt32(mijnReader["Id"]);
                ontvNaam = Convert.ToString(mijnReader["Naam"]);
                
            }

            _conn.Close();
            return antwoord;
        } 

        public List<Sport> HaalSportVanPersoonOp(int idPersoon)
        {
            List<Sport> antwoord = new List<Sport>();

            string sql = "SELECT IdSport FROM PersoonSport WHERE IdPersoon = " + Convert.ToString(idPersoon) + "";
            OleDbCommand commando = new OleDbCommand(sql, _conn);
            OleDbDataReader mijnReader;
            int idSport = 0;

            mijnReader = commando.ExecuteReader();
            while (mijnReader.Read())
            {
                idSport = Convert.ToInt32(mijnReader["IdSport"]);

                

                
            }

            return antwoord;
        }

        public Sport HaalSportOP(int idSport)
        {
            Sport antwoord;
            string sql = "SELECT Naam FROM Sport WHERE Id = " + Convert.ToString(idSport) + "";

            return antwoord;
        }
        //Constructor
        public MijnDB() { }
    }
}
