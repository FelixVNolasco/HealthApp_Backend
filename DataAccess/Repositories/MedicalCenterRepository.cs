using DataAccess.SQLClient;
using Microsoft.Data.SqlClient;
using Models.Entities;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class MedicalCenterRepository : IMedicalCenterRepository<MedicalCenter>
    {
        private readonly Client sqlClient;

        public MedicalCenterRepository(Client sqlClient)
        {
            this.sqlClient = sqlClient;
        }

        //CREATE A MEDICAL CENTER
        public bool CreateCenter(MedicalCenter medicalCenter)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO MedicalCenter (address, phoneNumber, rating) VALUES (@address, @phoneNumber, @rating)", sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.Clear();

                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("@address", medicalCenter.address));
                list.Add(new SqlParameter("@phoneNumber", medicalCenter.phoneNumber));
                list.Add(new SqlParameter("@rating", medicalCenter.rating));
                sqlCommand.Parameters.AddRange(list.ToArray<SqlParameter>());
                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        //GET ALL THE MEDICAL CENTERS
        public IEnumerable<MedicalCenter> GetAllCenters()
        {
            List<MedicalCenter> medicalCenterList = new List<MedicalCenter>();
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT id, address, phoneNumber, rating " +
                                                       "FROM MedicalCenter", sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                SqlDataReader reader;
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    MedicalCenter medicalCenter = new MedicalCenter();
                    medicalCenter.id = Int32.Parse(reader["id"].ToString());
                    medicalCenter.address = reader["address"].ToString();
                    medicalCenter.phoneNumber = reader["phoneNumber"].ToString();
                    medicalCenter.rating = reader["rating"].ToString();

                    medicalCenterList.Add(medicalCenter);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
            }
            finally
            {
                sqlConnection.Close();
            }

            return medicalCenterList;
        }

        //GET A MEDICAL CENTER IN SPECIFIC
        public MedicalCenter GetCenter(int id)
        {
            MedicalCenter medicalCenter = new MedicalCenter();
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT id, address, phoneNumber, rating FROM MedicalCenter WHERE id = @id", sqlConnection);
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters["@id"].Value = id;

                SqlDataReader reader;
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    medicalCenter.id = Int32.Parse(reader["id"].ToString());
                    medicalCenter.address = reader["address"].ToString();
                    medicalCenter.phoneNumber= reader["phoneNumber"].ToString();
                    medicalCenter.rating = reader["rating"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
            }
            finally
            {
                sqlConnection.Close();
            }
            return medicalCenter;
        }


        //UPDATE A MEDICAL CENTER IN SPECIFIC
        public bool UpdateCenter(MedicalCenter medicalCenter)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("UPDATE MedicalCenter SET phoneNumber  = @phoneNumber" +
                                                       " WHERE id = @id", sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.Clear();

                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("@id", medicalCenter.id));
                list.Add(new SqlParameter("@field", medicalCenter.phoneNumber));                

                sqlCommand.Parameters.AddRange(list.ToArray<SqlParameter>());
                sqlCommand.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        //REMOVE A MEDICAL CENTER IN SPECIFIC
        public bool RemoveCenter(int id)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("DELETE FROM MedicalCenter WHERE id = @id", sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters["@id"].Value = id;

                SqlDataReader reader;
                reader = sqlCommand.ExecuteReader();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
