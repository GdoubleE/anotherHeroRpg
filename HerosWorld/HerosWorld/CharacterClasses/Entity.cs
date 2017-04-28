using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosWorld.CharacterClasses
{
    public enum EntityGender {Male, Female, Unknown}
    public enum EntityClass { Dwarf, Elf, Warrior, Mage, Unknown}
    public enum EntityStat { Strength, Agility, Intelligence, Charisma}

    public abstract class Entity
    {
        
        #region Fields Region
        protected string _name;
        protected EntityGender _gender;
        protected EntityClass _characterClass;
        protected EntityStat _characterStat;
        protected int _strength;
        protected int _agility;
        protected int _intelligence;
        protected int _charisma;
        protected int _strengthModifier;
        protected int _agilityModifier;
        protected int _intelligenceModifier;
        protected int _charismaModifier;
        #endregion


        #region Properties Region

        public string Name
        {
            get { return _name; }
            protected set { _name = value;}
        }
        public EntityGender Gender
        {
            get { return _gender; }
            protected set { _gender = value; }
        }
        public EntityClass CharacterClass
        {
            get { return _characterClass; }
            protected set { _characterClass = value; }
        }
        public EntityStat CharacterStat
        {
            get { return _characterStat; }
            protected set { _characterStat = value; }
        }

        public int Strength
        {
            get { return _strength + _strengthModifier; }
            protected set { _strength = value; }
        }
        public int Agility
        {
            get { return _agility + _agilityModifier; }
            protected set { _agility = value; }
        }
        public int Intelligence
        {
            get { return _intelligence + _intelligenceModifier; }
            protected set { _intelligence = value; }
        }
        public int Charisma
        {
            get { return _charisma + _charismaModifier; }
            protected set { _charisma = value; }
        }
        #endregion


        #region Constructor Region
        public Entity()
        {
            Name = "";
            Gender = EntityGender.Unknown;
            CharacterClass = EntityClass.Unknown;
            Strength = 0;
            Agility = 0;
            Intelligence = 0;
            Charisma = 0;
        }

        //public Entity()
        //{
        //    Name = "";
        //    Strength = 0;
        //    Agility = 0;
        //    Intelligence = 0;
        //    Charisma = 0;
        //}






        #endregion


        #region Methods Region

        #endregion




    }
}
