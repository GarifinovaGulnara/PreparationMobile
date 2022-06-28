using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using PreparationMobile.Models;

namespace PreparationMobile.DB
{
    public class CRUDOperations
    {
        readonly SQLiteConnection db;
        public CRUDOperations(string databasePath)
        {
            db = new SQLiteConnection(databasePath);
            db.CreateTable<Client>();
            db.CreateTable<ToDoItem>();
        }
        public IEnumerable<Client> GetClients()
        {
            return db.Table<Client>();
        }
        public IEnumerable<ToDoItem> GetList()
        {
            return db.Table<ToDoItem>();
        }
        public IEnumerable<ToDoItem> GetListSort()
        {
            return db.Table<ToDoItem>().Where(x => x.User == App.client.Login);
        }

        public int SaveToDoItem(ToDoItem projectModel)
        {
            if (projectModel.Id != 0)
            {
                db.Update(projectModel);
                return projectModel.Id;
            }
            else
            {
                return db.Insert(projectModel);
            }
        }
        public int DeleteFurniture(int id) { return db.Delete<ToDoItem>(id); }
        public int SaveClient(Client projectModel)
        {
            if (projectModel.Id != 0)
            {
                db.Update(projectModel);
                return projectModel.Id;
            }
            else
            {
                return db.Insert(projectModel);
            }
        }
    }
}
