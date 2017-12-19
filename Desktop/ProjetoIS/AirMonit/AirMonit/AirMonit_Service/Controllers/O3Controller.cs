﻿using AirMonit_Service.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AirMonit_Service.Controllers
{
    public class O3Controller : ApiController
    {
        private string CONNSTRING = System.Configuration.ConfigurationManager.ConnectionStrings["AirMonit_Service.Properties.Settings.DBConn"].ConnectionString;

        [Route("api/O3")]
        public IEnumerable<O3> Get()
        {
            List<O3> lista = new List<O3>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM O3";
                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    O3 n = new O3();
                    n.value = (int)reader["value"];
                    n.date = (DateTime)reader["date"];
                    n.local = (string)reader["local"];


                    lista.Add(n);
                }

                conn.Close();
                reader.Close();
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return lista;
        }

        [Route("api/{local}/O3/{date}")]
        public IEnumerable<O3> GetSensorCityDate(string local, string date) //NOTA: date pode ser um Date e não um String? confirmar com grupo / ficheiro TODO
        {
            List<O3> lista = new List<O3>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM O3 WHERE date >= @datw AND date <= @date and local = @local";
                cmd.Parameters.AddWithValue("@date", date + "T00:00:00.000");
                cmd.Parameters.AddWithValue("@date", date + "T23:59:59.000");
                cmd.Parameters.AddWithValue("@local", local);

                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    O3 n = new O3();
                    n.value = (int)reader["value"];
                    n.date = (DateTime)reader["date"];
                    n.local = (string)reader["local"];


                    lista.Add(n);
                }

                conn.Close();
                reader.Close();
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return lista;
        }

        [Route("api/{local}/O3")]
        public IEnumerable<O3> GetSensorCity(string local) //NOTA: date pode ser um Date e não um String? confirmar com grupo / ficheiro TODO
        {
            List<O3> lista = new List<O3>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM O3 WHERE local = @local";
                cmd.Parameters.AddWithValue("@local", local);

                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    O3 n = new O3();
                    n.value = (int)reader["value"];
                    n.date = (DateTime)reader["date"];
                    n.local = (string)reader["local"];


                    lista.Add(n);
                }

                conn.Close();
                reader.Close();
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return lista;
        }
    }
}