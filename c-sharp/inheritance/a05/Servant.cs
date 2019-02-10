using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a05
{
    class Servant
    {
        public double[] classAffinity = new double[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
        public double attack = 0;

        public int BaseAttack { get; set; }
        public int BusterAmount { get; set; }
        public int ArtsAmount { get; set; }
        public int QuickAmount { get; set; }
        public string AttributeAffinity { get; set; }
        public string NoblePhantasm { get; set; }
        
        public double Hit(int enemyClass)
        {
            switch(enemyClass)
            {
                case 0: // Saber
                    attack *= classAffinity[0];
                    return attack;
                case 1: // Archer
                    attack *= classAffinity[1];
                    return attack;
                case 2: // Lancer
                    attack *= classAffinity[2];
                    return attack;
                case 3: // Rider
                    attack *= classAffinity[3];
                    return attack;
                case 4: // Assassin
                    attack *= classAffinity[4];
                    return attack;
                case 5: // Caster
                    attack *= classAffinity[5];
                    return attack;
                case 6: // Berserker
                    attack *= classAffinity[6];
                    return attack;
                case 7: // Ruler
                    attack *= classAffinity[7];
                    return attack;
            }
            return 1;
        }

    }
}
