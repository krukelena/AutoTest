using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Builders
{
    public class UserBuilder
    {
        public UserBuilder()
        {
            _user = new User();
        }


        private User _user;


        public User Build()
        {
            return _user;
        }

        public UserBuilder SetUsername(String username)
        {
            _user.Username = username;

            return this;
        }

        public UserBuilder SetPassword(String password)
        {
            _user.Password = password;

            return this;
        }
    }
}
