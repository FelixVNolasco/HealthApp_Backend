using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SQLClient;
using Models.Entities;
using Models.Interfaces;
using Microsoft.Data.SqlClient;

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


        public Doctor CreateDoctor(Doctor doctor)
        {
            //INSERT DOCTOR TO THE DATABASE
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("", sqlConnection);


            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
            }
            finally
            {
                sqlConnection.Close();
            }


            Doctor doctor1 = new Doctor();
            return doctor1;
        }

        public IEnumerable<Doctor> GetAllDoctors()
        {
            //GET ALL THE EXISTING DOCTORS

            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Doctor", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.Text;

                SqlDataReader reader;

                reader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
            }
            finally
            {
                sqlConnection.Close();
            }

            List<Doctor> doctorsList = new List<Doctor>();

            Doctor doctor1 = new Doctor();

            doctorsList.Add(doctor1);

            Doctor doctor2 = new Doctor();

            doctorsList.Add(doctor2);

            return doctorsList;
        }

        public Doctor GetDoctor(int id)
        {
            //GET A DOCTOR IN PARTICULAR

            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Doctor", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.Text;

                SqlDataReader reader;

                reader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
            }
            finally
            {
                sqlConnection.Close();
            }
            Doctor doctor1 = new Doctor();
            return doctor1;
        }

        public Doctor UpdateDoctor(Doctor doctor)
        {
            //UPDATE AN ESPECIFIC DOCTOR
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Doctor", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.Text;

                SqlDataReader reader;

                reader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
            }
            finally
            {
                sqlConnection.Close();
            }

            Doctor doctor1 = new Doctor();
            return doctor1;
        }

        public Doctor RemoveDoctor(int id)
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = sqlClient.GetStringConnection();

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Doctor", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.Text;

                SqlDataReader reader;

                reader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
            }
            finally
            {
                sqlConnection.Close();
            }

            Doctor doctor1 = new Doctor();
            return doctor1;
        }

    }
}
