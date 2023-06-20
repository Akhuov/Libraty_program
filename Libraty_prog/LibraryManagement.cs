using Library_prog;


namespace Library_prog
{
    public class LibraryManagement : LibraryManagementCore
    {
        private EmailService emailService;

        public LibraryManagement()
        {
            emailService = new EmailService();
        }
        public void RegisterUser(string firsName,string lastName)
        {

        }
        public void RegisterUser(string firsName,string lastName,string userName)
        {
            var foundUser = false;

            foreach (var user in Store.Users)
                if(user.Email==userName)
                {
                    foundUser = true;
                    break;
                }

            if (foundUser) 
                return;

            Store.Users.Add(new User(firsName, lastName, userName));
            emailService.SendEmail(userName);
        }
    }
}
