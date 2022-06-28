using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationMobile.Models
{
    [Table("todoitem")]
    public class ToDoItem
    {
        public ToDoItem()
        {
        }

        public ToDoItem(string description, string us)
        {
            Description = description;
            User = us;
        }

        [AutoIncrement, PrimaryKey, Column("_id")]
        public int Id { get; set; }
        [Unique]
        public string Description { get; set; }
        public string User { get; set; }
    }
}
