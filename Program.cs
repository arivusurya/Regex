﻿using System;


namespace UserValidation{
    public class Program{
        public static void Main(string[] args)
        {
            User userinfo = new User();
            Boolean Firstname = userinfo.ValidateName("Zeus");
           if(Firstname == false){
               Console.WriteLine("Enter the last name with capitalze and atleast had a 3 character");
           }
        }
    }
}
