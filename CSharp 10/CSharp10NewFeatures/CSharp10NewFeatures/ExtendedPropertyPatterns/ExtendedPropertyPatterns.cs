namespace CSharp10NewFeatures.ExtendedPropertyPatterns
{
    public class ExtendedPropertyPatterns
    {
        static List<User> UsersList = new List<User>()
        {
            new User(1,"Mohamed","Hashish",new Address("Egypt","Dakahlia")),            
            new User(3,"Khalid","Mohamed",new Address("Saudi Arabia","Makkah")),
            new User(4,"Ali","Ahmed",new Address("Morocco","Aldar Albidah")),
            new User(2,"Ibrahim ","Saad",new Address("Tunisia","Alqirwan")),
        };

        public static List<User> GetEgyptUsers()
        {
            var egyptUsers = new List<User>();
            foreach (var user in UsersList)
            {
                if (user is { HomeAddress.Country: "Egypt" })
                {
                    egyptUsers.Add(user);
                }
            }
            return egyptUsers;
        }

        public static List<User> GetingCountryUsers(string country)
        {
            var countryUsers = new List<User>();
            foreach (var user in UsersList)
            {
                if (user is { HomeAddress: { Country: var c } } && c == country)
                {
                    countryUsers.Add(user);
                }

                //Another way
                /*
                if (user is { HomeAddress.Country: var c } && c == country)
                {
                    countryUsers.Add(user);
                }
                */
            }
            return countryUsers;
        }
       
    }
}
