using System;


namespace UserValidation{
    public class Program{
        public static void Main(string[] args)
        {
            User userinfo = new User();
            Boolean Firstname = userinfo.ValidateFirstName("Kratos");
           if(Firstname == false){
               Console.WriteLine("Enter the first name with capitalze and atleast had a 3 character");
           }
        }
    }
}
