using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu.Values;
using Settings = KiteMachineKogMaw.MenuManager;

namespace KiteMachineKogMaw
{
    public class ItemManager
    {
        private static readonly AIHeroClient Player = EloBuddy.Player.Instance;

        // Offensive items
        public static readonly Item Cutlass = new Item((int)ItemId.Bilgewater_Cutlass, 550);
        public static readonly Item Botrk = new Item((int)ItemId.Blade_of_the_Ruined_King, 550);

        public static readonly Item Youmuu = new Item((int)ItemId.Youmuus_Ghostblade);

        public static bool UseBotrk(AIHeroClient target)
        {
            if (MenuManager.ItemMenu.Get<CheckBox>("botrk").CurrentValue && Botrk.IsReady() && target.IsValidTarget(Botrk.Range) && Player.Health + Player.GetItemDamage(target, (ItemId)Botrk.Id) < Player.MaxHealth)
            {
                return Botrk.Cast(target);
            }
            if (MenuManager.ItemMenu.Get<CheckBox>("cutlass").CurrentValue && Cutlass.IsReady() && target.IsValidTarget(Botrk.Range) && Player.Health + Player.GetItemDamage(target, (ItemId)Botrk.Id) < Player.MaxHealth)
            {
                return Cutlass.Cast(target);
            }
            return false;
        }

    }
}