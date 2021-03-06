using System;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
 namespace Models
 {
     public class UserLogin
     {
         private byte[] _salt = Convert.FromBase64String("U+sKO++VApFpLBUmpHDZPw==");
         private string _hash = "FYgdRJdpy0nghiS24gnfATCYerGltYAysh8lMWujuZ8="; 
         private int employeeid = 8675309;
        public int EmployeeID { get; set; } 
        public string Password { get; set; }       

        public bool CheckCreditials(){
            string getHash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: this.Password,
                salt: _salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
            ));
            if ((EmployeeID == employeeid) && (getHash == _hash)){
                return true;
            }
            return false;
        }


     }
 }