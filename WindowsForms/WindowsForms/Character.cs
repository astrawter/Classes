using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public class Character
    {
        string firstName;
        string lastName;
        string gender;
        decimal age;
        bool immortal;
        string weapon;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public decimal Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public bool Immortal
        {
            get
            {
                return immortal;
            }

            set
            {
                immortal = value;
            }
        }

        public string Weapon
        {
            get
            {
                return weapon;
            }

            set
            {
                weapon = value;
            }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
    }

