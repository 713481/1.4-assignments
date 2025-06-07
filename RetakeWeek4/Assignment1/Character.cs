using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal abstract class Character
    {
        public IWeaponBehaviour Weapon { get; set; }
        public Character(IWeaponBehaviour weapon) 
        { 
            Weapon = weapon;
        }

        public void Fight()
        {
            Weapon.UseWeapon();
        }
    }
}
