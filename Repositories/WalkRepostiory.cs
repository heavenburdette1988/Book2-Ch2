﻿using DogGoMVC2.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace DogGoMVC2.Repositories
{
    public class WalkRepostiory : IWalkRepository
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

        public List<Walk> GetAllWalks()
        {

            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT w.Id AS 'Walk Id', w.Date, w.Duration, w.WalkerId, w.DogId,
                               wr.Id AS 'Walker Id', wr.[Name] AS 'Walker Name', wr.NeighborhoodId AS 'Walkers NeighborhoodId', wr.ImageUrl AS 'Walker Img',
                               n.Id AS 'Hood Id', n.[Name] AS 'Hood Name',
                               d.Id AS 'Dog Id', d.[Name] AS 'Dog Name', d.Breed, d.ImageUrl AS 'Dog Img',
                               o.Id AS 'Owner Id', o.[Name] AS 'Owner Name', o.Email, o.[Address], o.Phone, o.NeighborhoodId AS 'Owners NeighborhoodId'
                        FROM Walks w
                            LEFT JOIN Walker wr ON w.WalkerId = wr.Id
                            LEFT JOIN Neighborhood n ON wr.NeighborhoodId = n.Id
                            LEFT JOIN Dog d ON w.DogId = d.Id
                            LEFT JOIN Owner o ON d.OwnerId = o.Id
                    ";



                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Walk> walks = new List<Walk>();

                    while (reader.Read())
                    {
                        Walk walk = new Walk()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Walk Id")),
                            Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                            Duration = reader.GetInt32(reader.GetOrdinal("Duration")),
                            WalkerId = reader.GetInt32(reader.GetOrdinal("Walker Id")),
                            DogId = reader.GetInt32(reader.GetOrdinal("Dog Id")),
                            Walker = new Walker()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Walker Id")),
                                Name = reader.GetString(reader.GetOrdinal("Walker Name")),
                                NeighborhoodId = reader.GetInt32(reader.GetOrdinal("Walkers NeighborhoodId")),
                                ImageUrl = reader.GetString(reader.GetOrdinal("Walker Img")),
                                Neighborhood = new Neighborhood()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Hood Id")),
                                    Name = reader.GetString(reader.GetOrdinal("Hood Name"))
                                }
                            },
                            Dog = new Dog()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Dog Id")),
                                Name = reader.GetString(reader.GetOrdinal("Dog Name")),
                                Breed = reader.GetString(reader.GetOrdinal("Breed")),
                                Owner = new Owner()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Owner Id")),
                                    Name = reader.GetString(reader.GetOrdinal("Owner Name")),
                                    Address = reader.GetString(reader.GetOrdinal("Address")),
                                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                    NeighborhoodId = reader.GetInt32(reader.GetOrdinal("Owners NeighborhoodId"))
                                }
                            }
                        };

                        walks.Add(walk);
                    }

                    reader.Close();

                    return walks;
                }
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
                SELECT w.Id AS 'Walk Id', w.Date, w.Duration, w.WalkerId, w.DogId,
                               wr.Id AS 'Walker Id', wr.[Name] AS 'Walker Name', wr.NeighborhoodId AS 'Walkers NeighborhoodId', wr.ImageUrl AS 'Walker Img',
                               n.Id AS 'Hood Id', n.[Name] AS 'Hood Name',
                               d.Id AS 'Dog Id', d.[Name] AS 'Dog Name', d.Breed, d.ImageUrl AS 'Dog Img',
                               o.Id AS 'Owner Id', o.[Name] AS 'Owner Name', o.Email, o.[Address], o.Phone, o.NeighborhoodId AS 'Owners NeighborhoodId'
                        FROM Walks w
                            LEFT JOIN Walker wr ON w.WalkerId = wr.Id
                            LEFT JOIN Neighborhood n ON wr.NeighborhoodId = n.Id
                            LEFT JOIN Dog d ON w.DogId = d.Id
                            LEFT JOIN Owner o ON d.OwnerId = o.Id
                        WHERE w.WalkerId = @id
            ";

                    cmd.Parameters.AddWithValue("@id", walkId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Walk> walks = new List<Walk>();

                    while (reader.Read())
                    {
                        Walk walk = new Walk()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Walk Id")),
                            Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                            Duration = reader.GetInt32(reader.GetOrdinal("Duration")),
                            WalkerId = reader.GetInt32(reader.GetOrdinal("Walker Id")),
                            DogId = reader.GetInt32(reader.GetOrdinal("Dog Id")),
                            Walker = new Walker()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Walker Id")),
                                Name = reader.GetString(reader.GetOrdinal("Walker Name")),
                                NeighborhoodId = reader.GetInt32(reader.GetOrdinal("Walkers NeighborhoodId")),
                                ImageUrl = reader.GetString(reader.GetOrdinal("Walker Img")),
                                Neighborhood = new Neighborhood()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Hood Id")),
                                    Name = reader.GetString(reader.GetOrdinal("Hood Name"))
                                }
                            },
                            Dog = new Dog()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Dog Id")),
                                Name = reader.GetString(reader.GetOrdinal("Dog Name")),
                                Breed = reader.GetString(reader.GetOrdinal("Breed")),
                                Owner = new Owner()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Owner Id")),
                                    Name = reader.GetString(reader.GetOrdinal("Owner Name")),
                                    Address = reader.GetString(reader.GetOrdinal("Address")),
                                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                    NeighborhoodId = reader.GetInt32(reader.GetOrdinal("Owners NeighborhoodId"))
                                }
                            }
                        };

                        walks.Add(walk);
                    }

                    reader.Close();

                    return walks;
                }
            }
        }

    }
}