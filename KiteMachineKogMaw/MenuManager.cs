using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace KiteMachineKogMaw
{
    internal class MenuManager
    {
        // Create Main Segments
        public static Menu KiteMachineKogMawMenu, ComboMenu, HarassMenu, JungleMenu, LaneClearMenu, LastHitMenu, KillStealMenu, DrawingMenu, SettingMenu, ItemMenu;

        public static void Initialize()
        {
            // Addon Menu
            KiteMachineKogMawMenu = MainMenu.AddMenu("BallistaKogMaw", "BallistaKogMaw");
            KiteMachineKogMawMenu.AddGroupLabel("Ballista Kog'Maw");

            // Combo Menu
            ComboMenu = KiteMachineKogMawMenu.AddSubMenu("Combo Features", "ComboFeatures");
            ComboMenu.AddGroupLabel("Combo Features");
            ComboMenu.AddLabel("Independent boxes for Spells:");
            ComboMenu.Add("Qcombo", new CheckBox("Use Q"));
            ComboMenu.Add("Wcombo", new CheckBox("Use W"));
            ComboMenu.Add("Ecombo", new CheckBox("Use E"));
            ComboMenu.Add("Rcombo", new CheckBox("Use R"));
            ComboMenu.Add("Scombo", new Slider("Max R Stacks", 1, 1, 10));
            ComboMenu.AddSeparator(1);
            ComboMenu.Add("Mcombo", new Slider("Mana Limiter at mana %", 25));

            // Harass Menu
            HarassMenu = KiteMachineKogMawMenu.AddSubMenu("Harass Features", "HarassFeatures");
            HarassMenu.AddGroupLabel("Harass Features");
            HarassMenu.AddLabel("Independent boxes for Spells:");
            HarassMenu.Add("Qharass", new CheckBox("Use Q"));
            HarassMenu.Add("Wharass", new CheckBox("Use W", false));
            HarassMenu.Add("Eharass", new CheckBox("Use E", false));
            HarassMenu.Add("Rharass", new CheckBox("Use R", false));
            HarassMenu.Add("Sharass", new Slider("Max R Stacks", 1, 1, 10));
            HarassMenu.AddSeparator(1);
            HarassMenu.Add("Mharass", new Slider("Mana Limiter at Mana %", 25));

            // Jungle Menu
            JungleMenu = KiteMachineKogMawMenu.AddSubMenu("Jungle Features", "JungleFeatures");
            JungleMenu.AddGroupLabel("Jungle Features");
            JungleMenu.AddLabel("Independent boxes for Spells:");
            JungleMenu.Add("Qjungle", new CheckBox("Use Q"));
            JungleMenu.Add("Wjungle", new CheckBox("Use W"));
            JungleMenu.Add("Rjungle", new CheckBox("Use R", false));
            JungleMenu.Add("Sjungle", new Slider("Max R Stacks", 1, 1, 10));
            JungleMenu.AddSeparator(1);
            JungleMenu.Add("Mjungle", new Slider("Mana Limiter at Mana %", 25));

            // LaneClear Menu
            LaneClearMenu = KiteMachineKogMawMenu.AddSubMenu("Lane Clear Features", "LaneClearFeatures");
            LaneClearMenu.AddGroupLabel("Lane Clear Features");
            LaneClearMenu.AddLabel("Independent boxes for Spells:");
            LaneClearMenu.Add("Qlanec", new CheckBox("Use Q", false));
            LaneClearMenu.Add("Wlanec", new CheckBox("Use W", false));
            LaneClearMenu.Add("Rlanec", new CheckBox("Use R", false));
            LaneClearMenu.Add("Slanec", new Slider("Max R Stacks", 1, 1, 10));
            LaneClearMenu.AddSeparator(1);
            LaneClearMenu.Add("Mlanec", new Slider("Mana Limiter at Mana %", 25));

            // LastHit Menu
            LastHitMenu = KiteMachineKogMawMenu.AddSubMenu("Last Hit Features", "LastHitFeatures");
            LastHitMenu.AddGroupLabel("Last Hit Features");
            LastHitMenu.AddLabel("Independent boxes for Spells:");
            LastHitMenu.Add("Qlasthit", new CheckBox("Use Q"));
            LastHitMenu.Add("Rlasthit", new CheckBox("Use R", false));
            LastHitMenu.Add("Slasthit", new Slider("Max R Stacks", 1, 1, 10));
            LastHitMenu.AddSeparator(1);
            LastHitMenu.Add("Mlasthit", new Slider("Mana Limiter at Mana %", 25));

            // Kill Steal Menu
            KillStealMenu = KiteMachineKogMawMenu.AddSubMenu("KS Features", "KSFeatures");
            KillStealMenu.AddGroupLabel("Kill Steal Features");
            KillStealMenu.Add("Uks", new CheckBox("KS Mode"));
            KillStealMenu.AddSeparator(1);
            KillStealMenu.AddLabel("Independent boxes for Spells:");
            KillStealMenu.Add("Qks", new CheckBox("Use Q in KS"));
            KillStealMenu.Add("Rks", new CheckBox("Use R in KS"));

            // Drawing Menu
            DrawingMenu = KiteMachineKogMawMenu.AddSubMenu("Drawing Features", "DrawingFeatures");
            DrawingMenu.AddGroupLabel("Drawing Features");
            DrawingMenu.Add("Udrawer", new CheckBox("Use Drawer"));
            DrawingMenu.AddSeparator(1);
            DrawingMenu.AddLabel("Independent boxes for Spells:");
            DrawingMenu.Add("Qdraw", new CheckBox("Draw Q"));
            DrawingMenu.Add("Wdraw", new CheckBox("Draw W"));
            DrawingMenu.Add("Edraw", new CheckBox("Draw E"));
            DrawingMenu.Add("Rdraw", new CheckBox("Draw R"));
            DrawingMenu.AddSeparator(1);
            DrawingMenu.AddLabel("Skin Designer");
            DrawingMenu.Add("Udesigner", new CheckBox("Use Designer"));
            DrawingMenu.Add("Sdesign", new Slider("Skin Designer: ", 7, 0, 8));

            // Setting Menu
            SettingMenu = KiteMachineKogMawMenu.AddSubMenu("Settings", "Settings");
            SettingMenu.AddGroupLabel("Settings");
            SettingMenu.AddLabel("Automatic Leveler");
            SettingMenu.Add("Uleveler", new CheckBox("Use Leveler"));
            SettingMenu.AddSeparator(1);
            SettingMenu.AddLabel("Automatic Tear Stacker");
            SettingMenu.Add("Ustacker", new CheckBox("Use Stacker"));
            SettingMenu.AddSeparator(1);
            SettingMenu.AddLabel("Automatic Passive - Death Follower");
            SettingMenu.Add("Ufollower", new CheckBox("Use Follower"));
            SettingMenu.AddSeparator(1);
            SettingMenu.AddLabel("Gap Closer");
            SettingMenu.Add("Ugapc", new CheckBox("Use Gapcloser"));
            SettingMenu.Add("Egapc", new CheckBox("Use E to gapclose"));
            SettingMenu.Add("dontw", new KeyBind("Don't move in combo", false, KeyBind.BindTypes.PressToggle, 'A'));
            SettingMenu.AddSeparator(1);

            //Item Menu
            KiteMachineKogMawMenu.AddSubMenu("Items", "Items");
            ItemMenu.AddGroupLabel("Items");
            ItemMenu.Add("cutlass", new CheckBox("Use Bilgewater Cutlass"));
            ItemMenu.Add("botrk", new CheckBox("Use Blade of the Ruined King"));
           




        }


        // Assign Global Checks+
        public static bool ComboUseQ { get { return ComboMenu["Qcombo"].Cast<CheckBox>().CurrentValue; } }
        public static bool ComboUseW { get { return ComboMenu["Wcombo"].Cast<CheckBox>().CurrentValue; } }
        public static bool ComboUseE { get { return ComboMenu["Ecombo"].Cast<CheckBox>().CurrentValue; } }
        public static bool ComboUseR { get { return ComboMenu["Rcombo"].Cast<CheckBox>().CurrentValue; } }
        public static int ComboStacks { get { return ComboMenu["Scombo"].Cast<Slider>().CurrentValue; } }
        public static int ComboMana { get { return ComboMenu["Mcombo"].Cast<Slider>().CurrentValue; } }

        public static bool HarassUseQ { get { return HarassMenu["Qharass"].Cast<CheckBox>().CurrentValue; } }
        public static bool HarassUseW { get { return HarassMenu["Wharass"].Cast<CheckBox>().CurrentValue; } }
        public static bool HarassUseE { get { return HarassMenu["Eharass"].Cast<CheckBox>().CurrentValue; } }
        public static bool HarassUseR { get { return HarassMenu["Rharass"].Cast<CheckBox>().CurrentValue; } }
        public static int HarassStacks { get { return HarassMenu["Sharass"].Cast<Slider>().CurrentValue; } }
        public static int HarassMana { get { return HarassMenu["Mharass"].Cast<Slider>().CurrentValue; } }

        public static bool JungleUseQ { get { return JungleMenu["Qjungle"].Cast<CheckBox>().CurrentValue; } }
        public static bool JungleUseW { get { return JungleMenu["Wjungle"].Cast<CheckBox>().CurrentValue; } }
        public static bool JungleUseE { get { return JungleMenu["Ejungle"].Cast<CheckBox>().CurrentValue; } }
        public static bool JungleUseR { get { return JungleMenu["Rjungle"].Cast<CheckBox>().CurrentValue; } }
        public static int JungleStacks { get { return JungleMenu["Sjungle"].Cast<Slider>().CurrentValue; } }
        public static int JungleMana { get { return JungleMenu["Mjungle"].Cast<Slider>().CurrentValue; } }

        public static bool LaneClearUseQ { get { return LaneClearMenu["Qlanec"].Cast<CheckBox>().CurrentValue; } }
        public static bool LaneClearUseW { get { return LaneClearMenu["Wlanec"].Cast<CheckBox>().CurrentValue; } }
        public static bool LaneClearUseE { get { return LaneClearMenu["Elanec"].Cast<CheckBox>().CurrentValue; } }
        public static bool LaneClearUseR { get { return LaneClearMenu["Rlanec"].Cast<CheckBox>().CurrentValue; } }
        public static int LaneClearStacks { get { return LaneClearMenu["Slanec"].Cast<Slider>().CurrentValue; } }
        public static int LaneClearMana { get { return LaneClearMenu["Mlanec"].Cast<Slider>().CurrentValue; } }

        public static bool LastHitUseQ { get { return LastHitMenu["Qlasthit"].Cast<CheckBox>().CurrentValue; } }
        public static bool LastHitUseR { get { return LastHitMenu["Rlasthit"].Cast<CheckBox>().CurrentValue; } }
        public static int LastHitStacks { get { return LastHitMenu["Slasthit"].Cast<Slider>().CurrentValue; } }
        public static int LastHitMana { get { return LastHitMenu["Mlasthit"].Cast<Slider>().CurrentValue; } }

        public static bool KsMode { get { return KillStealMenu["Uks"].Cast<CheckBox>().CurrentValue; } }
        public static bool KsUseQ { get { return KillStealMenu["Qks"].Cast<CheckBox>().CurrentValue; } }
        public static bool KsUseR { get { return KillStealMenu["Rks"].Cast<CheckBox>().CurrentValue; } }

        public static bool DrawMode { get { return DrawingMenu["Udrawer"].Cast<CheckBox>().CurrentValue; } }
        public static bool DrawQ { get { return DrawingMenu["Qdraw"].Cast<CheckBox>().CurrentValue; } }
        public static bool DrawW { get { return DrawingMenu["Wdraw"].Cast<CheckBox>().CurrentValue; } }
        public static bool DrawE { get { return DrawingMenu["Edraw"].Cast<CheckBox>().CurrentValue; } }
        public static bool DrawR { get { return DrawingMenu["Rdraw"].Cast<CheckBox>().CurrentValue; } }
        public static bool DesignerMode { get { return DrawingMenu["Udesigner"].Cast<CheckBox>().CurrentValue; } }
        public static int DesignerSkin { get { return DrawingMenu["Sdesign"].Cast<Slider>().CurrentValue; } }

        public static bool LevelerMode { get { return SettingMenu["Uleveler"].Cast<CheckBox>().CurrentValue; } }
        public static bool StackerMode { get { return SettingMenu["Ustacker"].Cast<CheckBox>().CurrentValue; } }
        public static bool FollowerMode { get { return SettingMenu["Ufollower"].Cast<CheckBox>().CurrentValue; } }

        public static bool GapCloserMode { get { return SettingMenu["Ugapc"].Cast<CheckBox>().CurrentValue; } }
        public static bool GapCloserUseE { get { return SettingMenu["Egapc"].Cast<CheckBox>().CurrentValue; } }

        public static bool BC { get { return SettingMenu["BC"].Cast<CheckBox>().CurrentValue; } }
        public static bool BOTRK { get { return SettingMenu["BOTRK"].Cast<CheckBox>().CurrentValue; } }
        public static bool dontw { get { return SettingMenu["dontw"].Cast<KeyBind>().CurrentValue; } }
    }
}
