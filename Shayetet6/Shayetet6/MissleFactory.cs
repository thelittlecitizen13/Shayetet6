using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public static class MissleFactory
    {
        public static Missile CreateMissile(string missileType)
        {
            switch(missileType)
            {
                case "Torpedo":
                    return new Torpedo(missileType, 100 , 1000);
                case "Cruise":
                    return new Cruise(missileType, 20 ,3000) ;
                case "Balistic":
                    return new Balistic(missileType, 50, 150);
                default:
                    return null;
            }
        }
        public static Missile CreateMissile()
        {
            string type = UserInputValidator.ReadMissileTypeName();
            return CreateMissile(type);
        }
    }
}
