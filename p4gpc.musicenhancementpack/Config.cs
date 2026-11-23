using p4gpc.musicenhancementpack.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace p4gpc.musicenhancementpack.Configuration
{
    public class Config : Configurable<Config>
    {
        /*
            User Properties:
                - Please put all of your configurable properties here.
    
            By default, configuration saves as "Config.json" in mod user config folder.    
            Need more config files/classes? See Configuration.cs
    
            Available Attributes:
            - Category
            - DisplayName
            - Description
            - DefaultValue

            // Technically Supported but not Useful
            - Browsable
            - Localizable

            The `DefaultValue` attribute is used as part of the `Reset` button in Reloaded-Launcher.
        */

        public enum ROTTT
        {
            [Display(Name = "Randomized - ROTTT Original")]
            Original,
            [Display(Name = "Randomized - ROTTT Reincarnation")]
            Reincarnation,
            [Display(Name = "Default P4G")]
            Default,
        }
        public enum Fog
        {
            [Display(Name = "Original")]
            Original,
            [Display(Name = "ATLUS Konishi Remix")]
            ATLUSKonishiRemix,
        }
        public enum Aqua
        {
            [Display(Name = "Persona 3")] // this is just Battle for Everyone's Souls but renamed for spoiler reasons.
            Original,
            [Display(Name = "Persona 3 Reload")]
            Reload,
            [Display(Name = "Default P4G")]
            Default,
        }
        public enum Backside
        {
            [Display(Name = "Original")]
            Original,
            [Display(Name = "Lotus Juice Remix")]
            LotusJuiceRemix,
        }
        public enum Aria
        {
            [Display(Name = "Original")]
            Original,
            [Display(Name = "Reload")]
            Reload,
        }
        public enum Tanaka
        {
            [Display(Name = "Original")]
            Original,
            [Display(Name = "Reload")]
            Reload,
        }
        public enum Joy
        {
            [Display(Name = "Original")]
            Original,
            [Display(Name = "Reload")]
            Reload,
        }
        public enum Escapade
        {
            [Display(Name = "Original")]
            Original,
            [Display(Name = "Persona Dancing mix")]
            PersonaDancing,
            [Display(Name = "Reload")]
            Reload,
        }

        [Category("Battles")]
        [DisplayName("Battle Music Behavior")]
        [Description("Choose battle music selection and behavior.\n\n" +
            "- Randomized - ROTTT Original: Randomizes battle music between the original version\n" +
            "of \"Reach Out To The Truth\" and Time To Make History - Original Full Size Version.\n" +
            "- Randomized - ROTTT Reincarnation: Randomizes battle music between the Reincarnation version\n" +
            "of \"Reach Out To The Truth\" and Time To Make History - Original Full Size Version.\n" +
            "- Default P4G: Uses P4G default beavior. Enable this if using battle theme mods like\n" +
            "P4G Randomized Battle Themes or similar.")]
        [DefaultValue(ROTTT.Reincarnation)]
        public ROTTT ROTTTVersion { get; set; } = ROTTT.Reincarnation;

        [Category("Battles")]
        [DisplayName("\"The Fog\" version")]
        [Description("Plays during the final boss battle.\n\n" +
            "- Original: Plays the original version of \"The Fog\".\n" +
            "- ATLUS Konishi Remix: Plays \"The Fog (ATLUS Konishi Remix)\" from Persona 4 Dancing.")]
        [DefaultValue(Fog.Original)]
        public Fog FogVersion { get; set; } = Fog.Original;

        [Category("Battles")]
        [DisplayName("Superboss Music")]
        [Description("Choose new music that plays during the superboss battle.\n\n" +
            "- Persona 3: Plays the original version of \"Aqua Invitation\".\n" +
            "- Persona 3 Reload: Plays \"Aqua Invitation\" from Persona 3 Reload.\n" +
            "- Default P4G: Plays I'll Face Myself -Battle- as in the original game.")]
        [DefaultValue(Aqua.Original)]
        public Aqua AquaVersion { get; set; } = Aqua.Original;

        [Category("Locations")]
        [DisplayName("\"Backside of the TV\" version")]
        [Description("Plays inside the TV World when not in a dungeon or the Velvet Room.\n\n" +
            "- Original: Plays the original version of \"Backside of the TV\".\n" +
            "- Lotus Juice Remix: Plays \"Backside Of The TV (Lotus Juice Remix)\" from Persona 4\nDancing.")]
        [DefaultValue(Backside.Original)]
        public Backside BacksideVersion { get; set; } = Backside.Original;

        [Category("Locations")]
        [DisplayName("\"Poem for Everyone's Souls\" version")]
        [Description("Plays in the Velvet Room.\n\n" +
            "- Original: Plays the original version of \"Poem for Everyone's Souls\".\n" +
            "- Reload: Plays \"Poem for Everyone's Souls -Reload-\" from Persona 3 Reload.")]
        [DefaultValue(Aria.Original)]
        public Aria AriaVersion { get; set; } = Aria.Original;

        [Category("Events")]
        [DisplayName("\"Jika Net Tanaka\" version")]
        [Description("Plays on Tanaka's shopping channel.\n\n" +
            "- Original: Plays the original version of \"Jika Net Tanaka\".\n" +
            "- Reload: Plays \"Jika Net Tanaka -Reload-\" from Persona 3 Reload.")]
        [DefaultValue(Tanaka.Original)]
        public Tanaka TanakaVersion { get; set; } = Tanaka.Original;

        [Category("Events")]
        [DisplayName("\"Joy\" version")]
        [Description("Plays during the school trip.\n\n" +
            "- Original: Plays the original version of \"Joy\".\n" +
            "- Reload: Plays \"Joy -Reload-\" from Persona 3 Reload.")]
        [DefaultValue(Joy.Original)]
        public Joy JoyVersion { get; set; } = Joy.Original;

        [Category("Events")]
        [DisplayName("Club Escapade Music")]
        [Description("Plays during the school trip.\n\n" +
            "- Original: Plays the original music used in Persona 4 (\"P3 fes\").\n" +
            "- Persona Dancing mix: Plays a mix of several tracks from Persona 3 Dancing and Persona 5 Dancing.\n" +
            "- Reload: Plays the club music from Persona 3 Reload, \"Everyone loves 1989\".")]
        [DefaultValue(Escapade.PersonaDancing)]
        public Escapade EscapadeVersion { get; set; } = Escapade.PersonaDancing;
    }

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}
