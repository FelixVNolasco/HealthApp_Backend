using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SQLClient;
using Models.Entities;
using Models.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess.Repositories
{
    public class DoctorRepository : IRepository<Doctor>
    {

        private readonly Client sqlClient;

        public DoctorRepository(Client sqlClient)
        {
            //DEPENDENCY INJECTION
            this.sqlClient = sqlClient;
        }


        public bool CreateDoctor(Doctor doctor)
        {
            //INSERT DOCTOR TO THE DATABASE
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Doctor (firstname, lastname, birthdate, graduation_date, phone_number, email) VALUES (@firstname, @lastname, @birthdate, @graduation_date, @phone_number, @email)", sqlConnection);

                sqlCommand.Parameters.Clear();
                List<SqlParameter> list = new List<SqlParameter>();

                list.Add(new SqlParameter("@firstname", doctor.firstname));
                list.Add(new SqlParameter("@lastname", doctor.lastname));
                list.Add(new SqlParameter("@birthdate", doctor.birthdate));
                list.Add(new SqlParameter("@graduation_date", doctor.graduation_date));
                list.Add(new SqlParameter("@phone_number", doctor.phone_number));
                list.Add(new SqlParameter("@email", doctor.email));

                sqlCommand.Parameters.AddRange(list.ToArray<SqlParameter>());

                //sqlCommand.CommandType = System.Data.CommandType.Text;

                sqlConnection.Open();
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

        public IEnumerable<Doctor> GetAllDoctors()
        {
            //GET ALL THE EXISTING DOCTORS

            List<Doctor> doctorsList = new List<Doctor>();
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT id, firstname, lastname, birthdate, graduation_date, phone_number, email " +
                                                       "FROM Doctor", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.Text;

                SqlDataReader reader;

                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Doctor doctor = new Doctor();
                    doctor.id = Int32.Parse(reader["id"].ToString());
                    doctor.firstname = reader["firstname"].ToString();
                    doctor.lastname = reader["lastname"].ToString();
                    doctor.birthdate = reader["birthdate"].ToString();
                    doctor.graduation_date = reader["graduation_date"].ToString();
                    doctor.phone_number = reader["phone_number"].ToString();
                    doctor.email = reader["email"].ToString();
                    doctorsList.Add(doctor);
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

            return doctorsList;

        }

        public Doctor GetDoctor(int id)
        {
            //GET A DOCTOR IN PARTICULAR
            Doctor doctor = new Doctor();
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT  id, firstname, lastname, birthdate, graduation_date, phone_number, email FROM Doctor WHERE id = @id", sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.Text;

                sqlCommand.Parameters.Add("@id", SqlDbType.Int);

                sqlCommand.Parameters["@id"].Value = id;

                SqlDataReader reader;

                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    doctor.id = Int32.Parse(reader["id"].ToString());
                    doctor.firstname = reader["firstname"].ToString();
                    doctor.lastname = reader["lastname"].ToString();
                    doctor.birthdate = reader["birthdate"].ToString();
                    doctor.graduation_date = reader["graduation_date"].ToString();
                    doctor.phone_number = reader["phone_number"].ToString();
                    doctor.email = reader["email"].ToString();
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

            return doctor;
        }

        public bool UpdateDoctor(Doctor doctor)
        {
            //UPDATE AN ESPECIFIC DOCTOR
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("UPDATE Doctor SET firstname = " +
                                                       "@firstname, lastName = @lastname, birthdate  = @birthdate, phone_number = @phone_number, email = @email" +
                                                       " WHERE id = @id", sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.Text;

                sqlCommand.Parameters.Clear();

                List<SqlParameter> list = new List<SqlParameter>();

                list.Add(new SqlParameter("@id", doctor.id));
                list.Add(new SqlParameter("@firstname", doctor.firstname));
                list.Add(new SqlParameter("@lastname", doctor.lastname));
                list.Add(new SqlParameter("@birthdate", doctor.birthdate));
                list.Add(new SqlParameter("@phone_number", doctor.phone_number));
                list.Add(new SqlParameter("@email", doctor.email));

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

        public bool RemoveDoctor(int id)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Doctor WHERE id = @id", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.Text;

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
