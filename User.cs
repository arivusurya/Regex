using System;
using System.Text.RegularExpressions;


namespace UserValidation{

    public class User{

            public Boolean ValidateFirstName(string firstName){   
               String Pattern = "[A-Z]{1}[a-z]{2,}";
               return Regex.IsMatch(firstName,Pattern);
            }
      
        }

    }

