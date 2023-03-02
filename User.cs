using System;
using System.Text.RegularExpressions;


namespace UserValidation{

    public class User{

            public Boolean ValidateName(string firstName){   
               String Pattern = "[A-Z]{1}[a-z]{2,}";
               return Regex.IsMatch(firstName,Pattern);
            }

            public Boolean Validatemail(string email){
                string Pattern ="^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-][a-zA-Z0-9]+)*.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email,Pattern);
            }
      
        }

    }

