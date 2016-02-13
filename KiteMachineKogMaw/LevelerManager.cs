﻿using EloBuddy;

namespace KiteMachineKogMaw
{
    internal class LevelerManager
    {
        // Clone Character Object
        public static AIHeroClient Champion = Program.Champion;

        public static void Initialize()
        {
            // Array of 18 levels
            int[] leveler = { 2, 3, 1, 2, 2, 4, 2, 3, 2, 3, 4, 3, 3, 1, 1, 4, 1, 1 };

            var avapoints = Champion.SpellTrainingPoints;
            while (avapoints >= 1)
            {
                // Calculate Skill For Next LevelUp
                var skill = leveler[Champion.Level - avapoints];

                switch (skill)
                {
                    case 1:
                        Champion.Spellbook.LevelSpell(SpellSlot.Q);
                        break;
                    case 2:
                        Champion.Spellbook.LevelSpell(SpellSlot.W);
                        break;
                    case 3:
                        Champion.Spellbook.LevelSpell(SpellSlot.E);
                        break;
                    case 4:
                        Champion.Spellbook.LevelSpell(SpellSlot.R);
                        break;
                }
                avapoints--;
            }
        }
    }
}