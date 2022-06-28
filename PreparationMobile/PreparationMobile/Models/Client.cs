using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationMobile.Models
{
    [Table("clients")]
    public class Client
    {
        public Client()
        { }

        public Client(string surname, string name, string login, string pass, int roleId)
        {
            Surname = surname;
            Name = name;
            Login = login;
            Pass = pass;
            RoleId = roleId;
        }

        [AutoIncrement, PrimaryKey, Column("_id")]
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public int RoleId { get;set; }
    }
}
