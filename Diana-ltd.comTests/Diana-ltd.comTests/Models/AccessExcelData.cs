using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace Diana_ltd.comTests.Models
{
      
    public class AccessExcelData
    {
        public static string fileName;
        public static string TestDataFileConnection()
        {
            var path = ConfigurationManager.AppSettings["TestDataSheetPath"];
          
      
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
		                              Data Source = {0}; 
		                              Extended Properties=Excel 12.0;", path + AccessExcelData.fileName);
            return con;
        }

        public static SearchBySizeTyre GetTestDataTyre(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();

                var query = string.Format("select * from [DataSet$] where key = '{0}'", keyName);
                var value = connection.Query<SearchBySizeTyre>(query).FirstOrDefault();

                connection.Close();
                
                return value;
            }
        }
        public static LoginFormUser GetTestDataLogin(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();

                var query = string.Format("select * from [DataSet$] where key = '{0}'", keyName);
                var value = connection.Query<LoginFormUser>(query).FirstOrDefault();

                connection.Close();

                return value;
            }
        }
        public static ContactFormUser GetTestDataContactForm(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();

                var query = string.Format("select * from [DataSet$] where key = '{0}'", keyName);
                var value = connection.Query<ContactFormUser>(query).FirstOrDefault();

                connection.Close();

                return value;
            }
        }
    }
    }

