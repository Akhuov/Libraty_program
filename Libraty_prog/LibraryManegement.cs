using LibraryManagement;


namespace Libraty_prog
{
    public class LibraryManegement : LibraryManagementCore
    {
        public void RegisterUser(string firsName,string lastName)
        {

        }
        public void RegisterUser(string firsName,string lastName,string userName)
        {
            var foundUser = false;

            foreach (var user in Store.Users)
                if(user.UserName==userName)
                {
                    foundUser = true;
                    break;
                }

            if (foundUser) 
                return;

            Store.Users.Add(new User(firsName, lastName, userName));

        }
    }
}
