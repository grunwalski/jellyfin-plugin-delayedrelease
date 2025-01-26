using System;
using System.Collections.Generic;
using Jellyfin.Plugin.DelayedRelease.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.DelayedRelease
{
    /// <summary>
    /// Plugin that allows delayed release of media items.
    /// </summary>
    public class DelayedReleasePlugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        private const string PluginName = "DelayedRelease";

        /// <summary>
        /// Initializes a new instance of the <see cref="DelayedReleasePlugin"/> class.
        /// </summary>
        /// <param name="applicationPaths">Instance of the <see cref="IApplicationPaths"/> interface.</param>
        /// <param name="xmlSerializer">Instance of the <see cref="IXmlSerializer"/> interface.</param>
        public DelayedReleasePlugin(
            IApplicationPaths applicationPaths,
            IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        /// <inheritdoc />
        public override string Name => PluginName;

        /// <inheritdoc />
        public override string Description => "This plugin allows you to manage delayed releases for movies and series.";

        /// <inheritdoc />
        public override Guid Id => Guid.Parse("b7decd4f-e20d-45f5-b16b-da6f55d456a1");

        /// <summary>
        /// Gets the current plugin instance.
        /// </summary>
        public static DelayedReleasePlugin? Instance { get; private set; }

        /// <inheritdoc />
        public IEnumerable<PluginPageInfo> GetPages()
        {
            yield return new PluginPageInfo
            {
                Name = Name,
                EmbeddedResourcePath = $"{GetType().Namespace}.Configuration.config.html"
            };
        }
    }
}
