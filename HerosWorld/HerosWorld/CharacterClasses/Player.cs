using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosWorld.CharacterClasses
{
    public class Player : Entity
    {
        Random rand = new Random();
        #region Player Constructors
        public Player() : base()
        {
        }

        public Player(string name, EntityGender eGender, EntityClass eClass)
            : base()
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
        }

        public Player(string name, EntityGender eGender, EntityClass eClass, EntityStat eStat)
            : base()
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
            CharacterStat = eStat;
        }
        #endregion
    }
}
