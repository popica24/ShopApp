using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Configuration;
using Newtonsoft.Json.Linq;
namespace ShopApp
{
    public class UserList : IBaseOperations<User>
    {
        public List<User> Users
        {
            get;
            set;
        }
        private string Root
        {
            get;
            set;
        }
        public UserList()
        {
            Users = new List<User>();
            var RootPath = ConfigurationManager.AppSettings["Clients"];
            string FileName = "Clients.json";
            if (string.IsNullOrEmpty(RootPath))
            {
                RootPath = "Clients";
            }
            if (!Directory.Exists(RootPath)) Directory.CreateDirectory(RootPath);
            if (!File.Exists(Path.Combine(RootPath, FileName))) File.Create(Path.Combine(RootPath, FileName));
            Root = Path.Combine(RootPath, FileName);
        
        }

        public bool CheckCredidentials(User U)
        {
            string Json = File.ReadAllText(Root);
            if (string.IsNullOrEmpty(Json)) return false; 
            var _Users = JsonConvert.DeserializeObject<List<User>>(Json);
          
            return _Users.Any(o => o.Equals(U));
        }

        public bool CheckDuplicate(User U)
        {

            string Json = File.ReadAllText(Root);
            if (String.IsNullOrEmpty(Json)) return false;
            var _Users = JsonConvert.DeserializeObject<List<User>>(Json);
            return _Users.Any(o => o.Equals(U));
        }

        public void Add(User U)
        {

            string Json = File.ReadAllText(Root);
            if (String.IsNullOrEmpty(Json))
            {
                Users.Add(U);
                File.WriteAllText(Root, JsonConvert.SerializeObject(Users));
                return;
            }
            Users = JsonConvert.DeserializeObject<List<User>>(Json);
          
            if (CheckDuplicate(U)) return;
            Users.Add(U);
            File.WriteAllText(Root, JsonConvert.SerializeObject(Users));
        }
        public void Remove(User U)
        {
            string Json = File.ReadAllText(Root);
            if (String.IsNullOrEmpty(Json)) return;
            var _Users = JsonConvert.DeserializeObject<List<User>>(Json);
            if (_Users.Any(o => o.Equals(U))) _Users.Remove(U);
        }
        public User Search(User U)
        {
            string Json = File.ReadAllText(Root);
            if (String.IsNullOrEmpty(Json)) return null;
            var _Users = JsonConvert.DeserializeObject<List<User>>(Json);
            if (_Users.Any(o => o.Equals(U))) return U;
            return null;
        }
    }
}