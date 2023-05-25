using Bogus;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
        public static class UserBuilder
        {
            static Faker Faker = new Faker();

            public static User StandartUser => new User
            {
                Name = TestContext.Parameters.Get("UserName"),
                Password = TestContext.Parameters.Get("UserPassword"),
            };

            public static User UserWithoutPassword => new User
            {
                Name = TestContext.Parameters.Get("UserName"),
                Password = "",
            };

            public static User GetRandomUser() => new()
            {
                Name = Faker.Internet.Email(provider: "AT_TMSQAC01_TEST.automation"),
                Password = Faker.Internet.Password(10),
            };

            public static User GetRandomUser(string email) => new()
            {
                Name = email,
                Password = Faker.Internet.Password(10),
            };
        }
    }


}
