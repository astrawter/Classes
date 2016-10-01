using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexandriaStrawter_CE02
{
    public class Character
    {
        string name;
        string gender;
        string description;
        bool race;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public bool Race
        {
            get
            {
                return race;
            }

            set
            {
                race = value;
            }
        }



        public override string ToString()
        {
            return name;
        }
    }
}
