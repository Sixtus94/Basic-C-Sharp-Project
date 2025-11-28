using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethod
{
    class MathMethods
    {
        //MathMethods.cs
        //Creating three method that take an integer parameter and return an integer
        public static int Heal(int magic)
        {
            int hitpoints = magic + 10;
            return hitpoints;
        }
        public static int Defense(int defense)
        {
            int enemy_str = 5;
            int weapon_mt = 8;
            int triangle_bonus = -2;
            int crit_coeff = 2;
            int damage = (enemy_str + (weapon_mt + triangle_bonus) - defense) * crit_coeff;
            return damage;
        }
        public static int Attack(int strenght)
        {
            int enemy_def = 3;
            int weapon_mt = 9;
            int triangle_bonus = 1;
            int crit_coeff = 3;
            int damage = (strenght + (weapon_mt + triangle_bonus) - enemy_def) * crit_coeff;
            return damage;
        }
    }
}
