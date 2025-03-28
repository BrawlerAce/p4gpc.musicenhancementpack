﻿using p4gpc.musicenhancementpack.Configuration;
using p4gpc.musicenhancementpack.Template;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using BGME.Framework.Interfaces;
using CriFs.V2.Hook;
using CriFs.V2.Hook.Interfaces;

namespace p4gpc.musicenhancementpack
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public class Mod : ModBase // <= Do not Remove.
    {
        /// <summary>
        /// Provides access to the mod loader API.
        /// </summary>
        private readonly IModLoader _modLoader;

        /// <summary>
        /// Provides access to the Reloaded.Hooks API.
        /// </summary>
        /// <remarks>This is null if you remove dependency on Reloaded.SharedLib.Hooks in your mod.</remarks>
        private readonly IReloadedHooks? _hooks;

        /// <summary>
        /// Provides access to the Reloaded logger.
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Entry point into the mod, instance that created this class.
        /// </summary>
        private readonly IMod _owner;

        /// <summary>
        /// Provides access to this mod's configuration.
        /// </summary>
        private Config _configuration;

        /// <summary>
        /// The configuration of the currently executing mod.
        /// </summary>
        private readonly IModConfig _modConfig;

        public Mod(ModContext context)
        {
            _modLoader = context.ModLoader;
            _hooks = context.Hooks;
            _logger = context.Logger;
            _owner = context.Owner;
            _configuration = context.Configuration;
            _modConfig = context.ModConfig;


            // For more information about this template, please see
            // https://reloaded-project.github.io/Reloaded-II/ModTemplate/

            // If you want to implement e.g. unload support in your mod,
            // and some other neat features, override the methods in ModBase.

            // TODO: Implement some mod logic

            var criFsController = _modLoader.GetController<ICriFsRedirectorApi>();
            if (criFsController == null || !criFsController.TryGetTarget(out var criFsApi))
            {
                _logger.WriteLine($"criFsController returned as null! p4gpc.musicenhancementpack will not work properly!", System.Drawing.Color.Red);
                return;
            }

            var BGMEController = _modLoader.GetController<IBgmeApi>().TryGetTarget(out var bgmeApi);

            var modDir = _modLoader.GetDirectoryForModId(_modConfig.ModId);

            if (_configuration.ROTTTVersion == Config.ROTTT.Original)
            {
                bgmeApi.AddPath(Path.Combine(modDir, "BGME_Config", "ROTTT_Base"));
            }

            if (_configuration.ROTTTVersion == Config.ROTTT.Reincarnation)
            {
                bgmeApi.AddPath(Path.Combine(modDir, "BGME_Config", "ROTTT_NM"));
            }

            if (_configuration.FogVersion == Config.Fog.ATLUSKonishiRemix)
            {
                bgmeApi.AddPath(Path.Combine(modDir, "BGME_Config", "Fog_Konishi"));
            }

            if (_configuration.AquaVersion == Config.Aqua.Original)
            {
                bgmeApi.AddPath(Path.Combine(modDir, "BGME_Config", "Aqua_Original"));
            }

            if (_configuration.AquaVersion == Config.Aqua.Reload)
            {
                bgmeApi.AddPath(Path.Combine(modDir, "BGME_Config", "Aqua_Reload"));
            }

            if (_configuration.BacksideVersion == Config.Backside.Original)
            {
            }

            if (_configuration.BacksideVersion == Config.Backside.LotusJuiceRemix)
            {
                bgmeApi.AddPath(Path.Combine(modDir, "BGME_Config", "Backside_LJ"));
            }

            if (_configuration.AriaVersion == Config.Aria.Original)
            {
            }

            if (_configuration.AriaVersion == Config.Aria.Reload)
            {
                bgmeApi.AddPath(Path.Combine(modDir, "BGME_Config", "Aria_Reload"));
            }

            if (_configuration.TanakaVersion == Config.Tanaka.Original)
            {
            }

            if (_configuration.TanakaVersion == Config.Tanaka.Reload)
            {
                bgmeApi.AddPath(Path.Combine(modDir, "BGME_Config", "Tanaka_Reload"));
            }

            if (_configuration.JoyVersion == Config.Joy.Original)
            {
            }

            if (_configuration.JoyVersion == Config.Joy.Reload)
            {
                bgmeApi.AddPath(Path.Combine(modDir, "BGME_Config", "Joy_Reload"));
            }

            if (_configuration.EscapadeVersion == Config.Escapade.Original)
            {
            }

            if (_configuration.EscapadeVersion == Config.Escapade.PersonaDancing)
            {
                bgmeApi.AddPath(Path.Combine(modDir, "BGME_Config", "Escapade_PersonaDancing"));
            }

            if (_configuration.EscapadeVersion == Config.Escapade.Reload)
            {
                bgmeApi.AddPath(Path.Combine(modDir, "BGME_Config", "Escapade_Reload"));
            }

            bgmeApi.AddPath(Path.Combine(modDir, "BGME"));

            // check for Anime Music Expansion
            var allMods = this._modLoader.GetActiveMods();
            if (allMods.Any(x => x.Generic.ModId == "p4gpc.animemusicexpansion") == false)
            {
                // add modified events
                criFsApi.AddProbingPath("Events");

            }

            else
            {
                this._logger.WriteLine("p4gpc.animemusicexpansion detected. Enabling compatibility mode for p4gpc.musicenhancementpack.", System.Drawing.Color.Green);
            }
        }

        #region Standard Overrides
        public override void ConfigurationUpdated(Config configuration)
        {
            // Apply settings from configuration.
            // ... your code here.
            _configuration = configuration;
            _logger.WriteLine($"[{_modConfig.ModId}] Config Updated: Applying");
        }
        #endregion

        #region For Exports, Serialization etc.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Mod() { }
#pragma warning restore CS8618
        #endregion
    }
}