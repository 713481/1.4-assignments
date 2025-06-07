using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
        public class KnifeBehaviour : IWeaponBehaviour
        {
            public void UseWeapon()
            {
                Console.WriteLine("Cutting with a knife");
            }
        }
        public class AxeBehaviour : IWeaponBehaviour
        {
            public void UseWeapon()
            {
                Console.WriteLine("Chopping with an axe");
            }
        }
        public class BowAndArrowBehaviour : IWeaponBehaviour
        {
            public void UseWeapon()
            {
                Console.WriteLine("Shooting an arrow with a bow");
            }
        }
        public class SwordBehaviour : IWeaponBehaviour
        {
            public void UseWeapon()
            {
                Console.WriteLine("Swinging a sword");
            }
        }
}
