using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using Dapper;
using System.Data;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Diagnostics;
using System.Linq;
using System.Dynamic;

namespace DoorLock_Library.DataBaseConnection.classes
{
    public class DataBlockAccessor<T> where T : new()
    {
        private IDbConnection dbConnection;

        private string ConnectionsString;

        public DataBlockAccessor()
        {


            //this.ConnectionsString = "Host=25.46.122.26;Database=doorLock;Username=postgres;Persist Security Info=True;Password=NEO@lebeko1992";
            //this.ConnectionsString = "Host=25.47.157.197;Database=doorLock;Username=postgres;Persist Security Info=True;Password=NEO@lebeko1992";
            this.ConnectionsString = "User ID=gsecdzhviuuigt;Password=c3b889cd63c8b85fc3cb7ba0c98810f224b62156d671321e6c1ef5e57e1e86f2;Host=174.129.18.42;Port=5432;Database=ddkpskf26qdlgj;SSL Mode=Require;TrustServerCertificate=True;";
            this.dbConnection = null;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public string GetCurrentMethod()
        {
            var st = new StackTrace();
            var sf = st.GetFrame(1);

            return sf.GetMethod().Name;
        }

        public string GetSprocName(string _currentMethod)
        {
            string value = "";
            MethodInfo mInfo = typeof(DataBlockAccessor<T>).GetMethod(_currentMethod);
            var customAttributes = (SprocNameAttribute[])Attribute.GetCustomAttributes(mInfo, typeof(SprocNameAttribute), true);
            if (customAttributes.Length > 0)
            {
                var myAttribute = customAttributes[0];
                value = myAttribute.SprocName;
                // TODO: Do something with the value
            }

            return value;
        }




        public T QueryDataSingle(string functionname, dynamic sampleObject)
        {
            T _SignUp = new T();

            try
            {

                using (this.dbConnection = new NpgsqlConnection(ConnectionsString))
                {
                    this.dbConnection.Open();

                    _SignUp = this.dbConnection.Query<T>(functionname, (Object)sampleObject, commandType: CommandType.StoredProcedure).FirstOrDefault();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                //Dispose();
            }


            return _SignUp;
        }


        public List<T> QueryData(string functionname, dynamic sampleObject)
        {
            List<T> Temp = new List<T>();

            try
            {

                using (this.dbConnection = new NpgsqlConnection(ConnectionsString))
                {
                    this.dbConnection.Open();

                    Temp = this.dbConnection.Query<T>(functionname, (Object)sampleObject, commandType: CommandType.StoredProcedure).ToList();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                //Dispose();
            }


            return Temp;
        }

        public T QueryDataSingle(string functionname)
        {
            T Temp = new T();

            try
            {

                using (this.dbConnection = new NpgsqlConnection(ConnectionsString))
                {
                    this.dbConnection.Open();

                    Temp = this.dbConnection.Query<T>(functionname, commandType: CommandType.StoredProcedure).FirstOrDefault();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                //Dispose();
            }


            return Temp;
        }

        public List<T> QueryData(string functionname)
        {
            List<T> Temp = new List<T>();

            try
            {

                using (this.dbConnection = new NpgsqlConnection(ConnectionsString))
                {
                    this.dbConnection.Open();

                    Temp = this.dbConnection.Query<T>(functionname, commandType: CommandType.StoredProcedure).ToList();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                //Dispose();
            }


            return Temp;
        }

        public T insertData(string functionname, dynamic sampleObject)
        {
            T Temp = new T();
            try
            {
                using (this.dbConnection = new NpgsqlConnection(this.ConnectionsString))
                {
                    this.dbConnection.Open();
                    Temp = this.dbConnection.QueryFirst<T>(functionname, (Object)sampleObject, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Temp;
        }

    }
}
