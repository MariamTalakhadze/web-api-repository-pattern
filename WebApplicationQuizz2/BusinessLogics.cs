using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationQuizz2
{
    public class BusinessLogics
    {
        
        static IRepository<User> repo = new UsersRepository();
        
        public static IEnumerable<User> getAllUsers()
        {
            return repo.List;
        }

        public static User findUser(int id)
        {
            return repo.FindById(id);
        }

        public static bool addUser(User user)
        {
            try
            {
                repo.Add(user);
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public static bool updateUser(User user)
        {
            try
            {
                repo.Update(user);
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public static bool deleteUser(int id)
        {
            try
            {
                repo.Delete(id);
                return true;
            } catch(Exception ex)
            {
                return false;
            }
        }
    }
}