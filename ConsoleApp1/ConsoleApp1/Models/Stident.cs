using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1.Models
{
    internal class Stident
    {
        static int _count = 1;
        public int id;
        string _fullname;
        

        public string FullName 
        { get
            { return _fullname; }
            set
            { 
                if ( isTrue(value))
                {
                    _fullname = value;
                    Console.WriteLine("ad dogrudur");
                }
                else if (!isTrue(value))
                {
                    Console.WriteLine("ad formati duzgun deyil");
                }
                               
            }
        }

        public Stident(string fullname)
        {
            FullName= fullname;
            id= _count++;

        }


        

        static bool ChechCorrectName(string fullname)
        {
            int count = 0;

            for (int j = 0; j < fullname.Length; j++)
            {
                if (Convert.ToChar(fullname[j]) == ' ')
                {
                    count++;
                }

                
            }
            for (int i = 0; i < fullname.Length; i++)
            {
               
                if (count==1 && Convert.ToChar(fullname[i]) == ' ' && char.IsUpper(fullname[0]) && char.IsUpper(fullname[i + 1]) )
                {                    
                             return true;          
                }                   
            }
           
            return false;
        }


        private static bool isLetter(string fullname)
        {
            for (int i = 0; i < fullname.Length; i++)
            {
                if (!char.IsLetter(fullname[i]) && fullname[i]!=' ' )
                {
                    return false;
                }
            }
            return true;

        }
        private static bool Namelength(string fullname)
        {
            string[] names = fullname.Split(' ');

            if (names[0].Length>=3 && names[0].Length<=10 && names[1].Length >= 3 && names[1].Length <= 10)
            {
                if (names[0].Substring(0, 1).ToUpper() + names[0].Substring(1).ToLower() == names[0] && (names[1].Substring(0, 1).ToUpper() + names[1].Substring(1).ToLower() == names[1]))
                    {
                    return true;
                }
            }
            return false;
        }


        private static bool isTrue(string fullname)
        {
            if (ChechCorrectName(fullname) && isLetter(fullname) && Namelength(fullname))
            { return true; }
            return false;
        }

















        public override string ToString()
        {
            return $"id: {id} full name: {_fullname}";
        }


    }
}
