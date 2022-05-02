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


        public string CreateDoctor(Doctor doctor)
        {
            //INSERT DOCTOR TO THE DATABASE
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();
                sqlConnection.Open();

                SqlCommand verifyCommand = new SqlCommand("SELECT distinct 1 id FROM ClinicalSpecialty WHERE id = @id", sqlConnection);
                verifyCommand.CommandType = CommandType.Text;
                verifyCommand.Parameters.Clear();
                verifyCommand.Parameters.AddWithValue("@id", doctor.specialty);
                
                SqlDataReader reader;
                reader = verifyCommand.ExecuteReader();

                string specialtyExists = "";
                while (reader.Read())
                {
                    specialtyExists = reader["id"].ToString();                    
                }

                sqlConnection.Close();


                if (specialtyExists == "1")
                {
                    //Console.WriteLine("La especialidad SI existe");

                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Doctor (firstname, lastname, birthdate, graduation_date, phone_number, email, specialty) VALUES (@firstname, @lastname, @birthdate, @graduation_date, @phone_number, @email, @specialty)", sqlConnection);

                    sqlCommand.Parameters.Clear();
                    List<SqlParameter> list = new List<SqlParameter>();

                    list.Add(new SqlParameter("@firstname", doctor.firstname));
                    list.Add(new SqlParameter("@lastname", doctor.lastname));
                    list.Add(new SqlParameter("@birthdate", doctor.birthdate));
                    list.Add(new SqlParameter("@graduation_date", doctor.graduation_date));
                    list.Add(new SqlParameter("@phone_number", doctor.phone_number));
                    list.Add(new SqlParameter("@email", doctor.email));
                    list.Add(new SqlParameter("@specialty", doctor.specialty));

                    sqlCommand.Parameters.AddRange(list.ToArray<SqlParameter>());

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    return "1";
                } else
                {
                    //Console.WriteLine("La especialidad NO existe");
                    return "2";
                }                

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
                return "3";
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

                SqlCommand sqlCommand = new SqlCommand("SELECT id, firstname, lastname, birthdate, graduation_date, phone_number, email, specialty " +
                                                       "FROM Doctor", sqlConnection);
                sqlCommand.CommandType = CommandType.Text;

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
                    doctor.specialty = reader["specialty"].ToString();
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

                //SqlCommand sqlCommand = new SqlCommand("SELECT  id, firstname, lastname, birthdate, graduation_date, phone_number, email FROM Doctor WHERE id = @id", sqlConnection);

                //SqlCommand sqlCommand = new SqlCommand("SELECT Doctor.id, firstname, lastname, birthdate, graduation_date, phone_number, email, ClinicalSpecialty.field, ClinicalSpecialty.specialty, ClinicalSpecialty.description "
                //                        + "FROM Doctor "
                //                        + "INNER JOIN ClinicalSpecialty ON ClinicalSpecialty.id = Doctor.specialty "
                //                        + "WHERE Doctor.id = @id;", sqlConnection);

                SqlCommand sqlCommand = new SqlCommand("SELECT id, firstname, lastname, birthdate, graduation_date, phone_number, email, specialty FROM Doctor WHERE id = @id", sqlConnection);

                sqlCommand.CommandType = CommandType.Text;
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
                    doctor.field = reader["specialty"].ToString();
                }

                sqlConnection.Close();
                sqlConnection.Open();

                SqlCommand newSQLComman = new SqlCommand("SELECT field, specialty, description FROM ClinicalSpecialty WHERE id = @idSpecialty", sqlConnection);

                newSQLComman.CommandType = CommandType.Text;
                newSQLComman.Parameters.Add("@idSpecialty", SqlDbType.Int);
                newSQLComman.Parameters["@idSpecialty"].Value = doctor.field;

                SqlDataReader newReader;
                newReader = newSQLComman.ExecuteReader();

                while (newReader.Read())
                {
                    doctor.field = newReader["field"].ToString();
                    doctor.specialty = newReader["specialty"].ToString();
                    doctor.description = newReader["description"].ToString();
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

                sqlCommand.CommandType = CommandType.Text;

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
