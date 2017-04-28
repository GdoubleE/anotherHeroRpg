using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosWorld.CharacterClasses
{
    public class NPC : Entity
    {
        Random rand = new Random();
        //default constructor
        public NPC() : base()
        {

        }

        public NPC(string name, EntityGender eGender, EntityClass eClass)
            : base()
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
        }
    }
}
