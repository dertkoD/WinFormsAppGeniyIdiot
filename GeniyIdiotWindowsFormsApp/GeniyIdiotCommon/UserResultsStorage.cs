using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeniyIdiotCommon
{
    public class UserResultsStorage
    {
        public static string path = "userResults.json";

        public static void AddNewUser(User newUser)
        {
            Init();
            var allUsers = GetAll();
            allUsers.Add(newUser);
            Save(allUsers);
        }

        public static void Save(List<User> allUsers)
        {
            var serialized = JsonConvert.SerializeObject(allUsers, Formatting.Indented);
            FileProvider.Replace(path, serialized);
        }

        public static List<User> GetAll()
        {
            var serializedUsers = FileProvider.Get(path);
            var users = JsonConvert.DeserializeObject<List<User>>(serializedUsers);
            return users;
        }

        private static void Init()
        {
            if (!FileProvider.IsExists(path))
            {
                List<User> emptyUsers = new List<User>();
                Save(emptyUsers);
            }
        }
    }
}
