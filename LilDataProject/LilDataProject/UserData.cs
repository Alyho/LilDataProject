using System.Collections.Generic;

namespace LilDataProject.Models
{

    public class UserData : IData
    {
        public List<User> Users;

        // this class does database work
        public UserData()
        {
            // instantiate connection to database
            Users = new List<User>();

            User user1 = new User();
            user1.Name = "Alyssa Ho";
            user1.Address = "1155 Coronet Ave";
            user1.Email = "alyssa@gmail.com";
            user1.Age = "16";
            user1.PhoneNumber = "626-768-0273";

            User user2 = new User();
            user2.Name = "Desiree";
            user2.Address = "123 Main Ave";
            user2.Email = "desiree@yahoo.com";
            user2.Age = "18";
            user2.PhoneNumber = "626-123-4567";

            Users.Add(user1);
            Users.Add(user2);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public User GetUser(int userId)
        {
            if (userId >= 0 && userId < Users.Count)
            {
                return Users[userId];
            }

            return new User();
        }
    }
}