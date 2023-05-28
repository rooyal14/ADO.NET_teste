using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ControllerProject;
using ModelProject;
using System.Configuration;
using System.Data;

namespace ControllerProject
{
    
    public static class Criptografia
    {
        public static string GerarHash(this string transformaHash)
        { 
            var hash = SHA1.Create();
            var encoding = new ASCIIEncoding();
            var array = encoding.GetBytes(transformaHash); 

            array = hash.ComputeHash(array);

            var strHexa = new StringBuilder();

            foreach (var item in array)
            { 
                strHexa.Append(item.ToString("x2")); 
            }

            return strHexa.ToString();  

        }
     }
}
