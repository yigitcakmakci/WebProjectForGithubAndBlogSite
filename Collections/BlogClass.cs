﻿using Microsoft.AspNetCore.Mvc;
using WebProjectForGithubAndBlogSite.Collections.Interface;
using WebProjectForGithubAndBlogSite.Models;
using System.Data.SqlClient;
using WebProjectForGithubAndBlogSite.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebProjectForGithubAndBlogSite.Collections
{
    public class BlogClass : IBlogClass
    {
        public List<BlogContentDataModel> GetContentDataModel() {
            List<BlogContentDataModel> blogContents = new List<BlogContentDataModel>();
            using (SqlConnection connection = new SqlConnection(SqlConnectionClass.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, Title, Description, Content, Image FROM BlogContent";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Her satır için bir Product nesnesi oluştur
                            BlogContentDataModel BlogContent = new BlogContentDataModel
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Description = reader.GetString(2),
                                Content = reader.GetString(3),
                                Image = reader.GetString(4),
                            };

                            // Ürünü listeye ekle
                            blogContents.Add(BlogContent);
                        }
                    }

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Veri başarıyla eklendi.");
                    }
                    else
                    {
                        Console.WriteLine("Veri eklenirken hata oluştu.");
                    }
                }
                connection.Close();
                return (blogContents);
            }

        }
    }
}
