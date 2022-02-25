using DogGoMVC2.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace DogGoMVC2.Repositories
{
    public class WalkRepostiory: IWalkRepository
    {

        private readonly IConfiguration _config;

        // The constructor accepts an IConfiguration object as a parameter. This class comes from the ASP.NET framework and is useful for retrieving things out of the appsettings.json file like connection strings.
        public WalkRepostiory(IConfiguration config)
        {
            _config = config;
        }

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }


        public List<Walk> GetWalksByWalkerId(int walkId)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                SELECT Id, Date, Duration, WalkId, DogId
                FROM Walk
                WHERE WalkId = @walkId
            ";

                    cmd.Parameters.AddWithValue("@walkId", walkId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Walk> walks = new List<Walk>();

                    while (reader.Read())
                    {
                        Walk walk = new Walk()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Date = reader.GetString(reader.GetOrdinal("Date")),
                            Duration = reader.GetInt32(reader.GetOrdinal("Duration")),
                            WalkId = reader.GetInt32(reader.GetOrdinal("WalkId")),
                            DogId = reader.GetInt32(reader.GetOrdinal("DogId"))
                        };

                        // Check if optional columns are null
                        //if (reader.IsDBNull(reader.GetOrdinal("Notes")) == false)
                        //{
                        //    dog.Notes = reader.GetString(reader.GetOrdinal("Notes"));
                        //}
                        //if (reader.IsDBNull(reader.GetOrdinal("ImageUrl")) == false)
                        //{
                        //    dog.ImageUrl = reader.GetString(reader.GetOrdinal("ImageUrl"));
                        //}
                    
                        walks.Add(walk);
                    }
                    reader.Close();
                    return walks;
                }
            }
        }
    
