using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserTable.Models
{
    public class UserModel : UserModelBase
    {
        public List<User> GetAllUsers()
        {
            IEnumerable<User> AllUsers = this.Query<User>("dbo.uspGetUsers");
            List<User> UsersToReturn = new List<User>();
            UsersToReturn = AllUsers.ToList();

            bool exit = false;
            do
            {
                exit = false;
                for (int i = 0; i < UsersToReturn.Count - 1; i++)
                {
                    if (UsersToReturn[i].Priority > UsersToReturn[i + 1].Priority)
                    {
                        exit = true;
                        User temp = UsersToReturn[i];
                        UsersToReturn[i] = UsersToReturn[i + 1];
                        UsersToReturn[i + 1] = temp;
                    }
                }
            } while (exit);

            return UsersToReturn;
        }

        public void EditUser(User user)
        {

            List<User> userP = this.Query<User>("dbo.uspGetUser", ToDynamic(user.Id));
            user.Priority = userP[0].Priority;
            this.Query<User>("dbo.uspEditUser", ToDynamic(user));
        }

        public void RearrangeUser(IList<int> Ids)
        {
            IEnumerable<User> AllUsers = this.Query<User>("dbo.uspGetUsers");
            foreach (User user in AllUsers)
            {
                int counter = 0;
                foreach (int id in Ids)
                {
                    if (user.Id == id)
                    {
                        user.Priority = counter;
                    }
                    counter++;
                }
                this.Query<User>("dbo.uspEditUser", ToDynamic(user));
            }
        }

        public List<User> GetUser(int userId)
        {
            return this.Query<User>("dbo.uspGetUser", ToDynamic(userId));
        }

        public int AddUser(User user)
        {
            IEnumerable<User> AllUsers = this.Query<User>("dbo.uspGetUsers");
            if (AllUsers.Count() > 0)
            {
                user.Priority = AllUsers.Last().Priority + 1;
            }
            else
            {
                user.Priority = 0;
            }
            IEnumerable<User> returnedId = this.Query<User>("dbo.uspAddUser", ToDynamic(user));
            return returnedId.ToList()[0].Id;
        }

        public void DeleteUser(int Id)
        {
            IEnumerable<User> AllUsers = this.Query<User>("dbo.uspGetUsers");
            int Pr = -1;
            foreach (User user in AllUsers)
            {
                if (Id == user.Id)
                {
                    Pr = user.Priority;
                }
            }
            this.Query<User>("dbo.uspDeleteUser", ToDynamic(Id));
            foreach (User user in AllUsers)
            {
                if (user.Priority > Pr)
                {
                    user.Priority--;

                    this.Query<User>("dbo.uspEditUser", ToDynamic(user));
                }
            }
        }

        public dynamic ToDynamic(User Body)
        {
            var dBody = new DynamicParameters();
            dBody.Add("Id", Body.Id);
            dBody.Add("Priority", Body.Priority);
            dBody.Add("Name", Body.Name);
            dBody.Add("Age", Body.Age);
            return dBody;
        }

        public dynamic ToDynamic(int id)
        {
            var dId = new DynamicParameters();
            dId.Add("Id", id);
            return dId;
        }
    }
}