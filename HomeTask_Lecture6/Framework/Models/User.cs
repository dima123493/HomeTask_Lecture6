using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;

namespace HomeTask_Lecture6.Users
{
    #region
    /* public class User
     {
         public string Username { get; set; }
         public string Password { get; set; }
         public string FirstName { get; set; }
         public string LastName { get; set; }

         public static User UserData()
         {
         string[] lines = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/Credentials.csv"));
         var readUsers = TextFieldParser;
             readUsers.TextFieldType = FieldType.Delimited;
             readUsers.SetDelimiters(";");
             string[] fields;
             fields = readUsers.ReadFields();
             return new User { Username = fields[0], Password = fields[1], FirstName = fields[2], LastName = fields[3] };
         }*/
    #endregion
    
    public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        public static User UserData()
        {
            string path = @"C:\Users\ִלטענטי\source\repos\HomeTask_Lecture6\HomeTask_Lecture6\Resourses\Credentials.csv";

            string[] readText = File.ReadAllLines(path);

            string[] _username = readText[0].Split(';');
            string[] _password = readText[1].Split(';');
            string[] _firstname = readText[2].Split(';');
            string[] _lastname = readText[3].Split(';');
            List<User> myuser = new List<User>();
            for (int i = 1; i < _username.Length; i++)
            {
                myuser.Add(
                    new User
                    {
                        Username = _username[i],
                        Password = _password[i],
                        FirstName = _firstname[i],
                        LastName = _lastname[i]
                    });
            }
        foreach (User item in myuser)
        {
            return myuser;
        }
    }
    }