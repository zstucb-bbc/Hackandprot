using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackingandSavingPage.Areas.SqlInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HackingandSavingPage.Features
{
    public class HackingandSavingPageUserDao
    {
       

        public SqlInjectionModel getUser(string username, string password) {
            SqlInjectionModel user = new SqlInjectionModel();
			
			/*
			string connectionSting;
            SqlConnection cnn;
            connectionSting = "Data Source=127.0.0.1,3026;Initial Catalog=hackingandprot ;User ID=jonas;Password=1234567890";
            cnn = new SqlConnection(connectionSting);
			cnn.Open();
		    SqlCommand command;
		    SqlDataReader dataReader;
			user.UserName ="NOTFOUND";
		    string sql = "Select username, password from hackingandprotuser where email=" + username + " and password=" + password;
		
		    command = new SqlCommand(sql, cnn);
		
		    dataReader = command.ExecuteReader();
		    while (dataReader.Read())
		    {
		      user.UserName = dataReader.GetValue(0) + "";
              user.Password = dataReader.GetValue(1) + "";
		    }
		
		    dataReader.Close();
		    cnn.Close(); */

			user.Email ="jongredig@gmail.com";  // beim erklären löschen und denn oberen code einkommentieren
			user.Married = false; // beim erklären löschen und denn oberen code einkommentieren
			user.UserName = "Jonas";// beim erklären löschen und denn oberen code einkommentieren
			user.Password = "1234";// beim erklären löschen und denn oberen code einkommentieren

		    return user;
        }

		public Boolean updateUser(String username) {
			return true; // beim erklären methode löschen
		}

		public Boolean existsUser(LoginModel model) {
			if ("NOTFOUND".Equals(getUser(model.UserName, model.Password).UserName)) {
				return false;
			} else {
				return true;
			}
			
		}
    
    }
}