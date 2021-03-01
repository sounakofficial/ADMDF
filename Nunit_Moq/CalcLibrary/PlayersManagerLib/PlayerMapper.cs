using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PlayersManagerLib
{
    public interface IPlayerMapper
    {
        bool IsPlayerNameExistsInDb(string name);

        void AddNewPlayerIntoDb(string name);
    }

    public class PlayerMapper : IPlayerMapper
    {
        private readonly string _connectionString = "Data Source = (local);Initial Catalog=GameDB;Integrated Security=true";

        public void AddNewPlayerIntoDb(string name)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "inser into player ([Name]) values(@name)";
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool IsPlayerNameExistsInDb(string name)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select count(*) from Player where 'Name' = @name";
                    cmd.Parameters.AddWithValue("@name", name);
                    var existingPlayerCount = (int)cmd.ExecuteScalar();
                    return existingPlayerCount > 0;
                }
            }
        }
    }
}