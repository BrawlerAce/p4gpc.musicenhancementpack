using p4gpc.musicenhancementpack.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;
using System.ComponentModel;

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
            Original,
            Reincarnation,
        }
        public enum Fog
        {
            Original,
            ATLUSKonishiRemix,
        }
        public enum Aqua
        {
            Original,
            Reload,
        }
        public enum Backside
        {
            Original,
            LotusJuiceRemix,
        }
        public enum Aria
        {
            Original,
            Reload,
        }
        public enum Tanaka
        {
            Original,
            Reload,
        }
        public enum Joy
        {
            Original,
            Reload,
        }
        public enum Escapade
        {
            Original,
            PersonaDancing,
            Reload,
        }

        [Category("Battles")]
        [DisplayName("\"Reach Out To The Truth\" version")]
        [Description("Plays during normal battles.\n\nOriginal: Plays the original version of \"Reach Out To The Truth\".\nReincarnation: Plays the Reincarnation version of \"Reach Out To The Truth\".")]
        [DefaultValue(ROTTT.Reincarnation)]
        public ROTTT ROTTTVersion { get; set; } = ROTTT.Reincarnation;

        [Category("Battles")]
        [DisplayName("\"The Fog\" version")]
        [Description("Plays during the final boss battle.\n\nOriginal: Plays the original version of \"The Fog\".\nATLUSKonishiRemix: Plays \"The Fog (ATLUS Konishi Remix)\" from Persona 4 Dancing.")]
        [DefaultValue(Fog.Original)]
        public Fog FogVersion { get; set; } = Fog.Original;

        [Category("Battles")]
        [DisplayName("\"Aqua Invitation\" version")]
        [Description("Plays during the superboss battle.\n\nOriginal: Plays the original version of \"Aqua Invitation\".\nReload: Plays \"Aqua Invitation\" from Persona 3 Reload.")]
        [DefaultValue(Aqua.Original)]
        public Aqua AquaVersion { get; set; } = Aqua.Original;

        [Category("Locations")]
        [DisplayName("\"Backside of the TV\" version")]
        [Description("Plays inside the TV World when not in a dungeon or the Velvet Room.\n\nOriginal: Plays the original version of \"Backside of the TV\".\nLotusJuiceRemix: Plays \"Backside Of The TV (Lotus Juice Remix)\" from Persona 4 Dancing.")]
        [DefaultValue(Backside.Original)]
        public Backside BacksideVersion { get; set; } = Backside.Original;

        [Category("Locations")]
        [DisplayName("\"Poem for Everyone's Souls\" version")]
        [Description("Plays in the Velvet Room.\n\nOriginal: Plays the original version of \"Poem for Everyone's Souls\".\nReload: Plays \"Poem for Everyone's Souls -Reload-\" from Persona 3 Reload.")]
        [DefaultValue(Aria.Original)]
        public Aria AriaVersion { get; set; } = Aria.Original;

        [Category("Events")]
        [DisplayName("\"Jika Net Tanaka\" version")]
        [Description("Plays on Tanaka's shopping channel.\n\nOriginal: Plays the original version of \"Jika Net Tanaka\".\nReload: Plays \"Jika Net Tanaka -Reload-\" from Persona 3 Reload.")]
        [DefaultValue(Tanaka.Original)]
        public Tanaka TanakaVersion { get; set; } = Tanaka.Original;

        [Category("Events")]
        [DisplayName("\"Joy\" version")]
        [Description("Plays during the school trip.\n\nOriginal: Plays the original version of \"Joy\".\nReload: Plays \"Joy -Reload-\" from Persona 3 Reload.")]
        [DefaultValue(Joy.Original)]
        public Joy JoyVersion { get; set; } = Joy.Original;

        [Category("Events")]
        [DisplayName("Club Escapade Music")]
        [Description("Plays during the school trip.\n\nOriginal: Plays the original music used in Persona 4 (\"P3 fes\").\nPersonaDancing: Plays a mix of several tracks from Persona 3 Dancing and Persona 5 Dancing.\nReload: Plays the club music from Persona 3 Reload, \"Everyone loves 1989\".")]
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
