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
    /// Delayed Release Plugin.
    /// </summary>
    public class DelayedReleasePlugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DelayedReleasePlugin"/> class.
        /// </summary>
        /// <param name="applicationPaths">Instance of the <see cref="IApplicationPaths"/> interface.</param>
        /// <param name="xmlSerializer">Instance of the <see cref="IXmlSerializer"/> interface.</param>
        public DelayedReleasePlugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        /// <summary>
        /// Gets current plugin instance.
        /// </summary>
        public static DelayedReleasePlugin Instance { get; private set; }

        /// <inheritdoc />
        public override string Name => "Delayed Release";

        /// <inheritdoc />
        public override Guid Id => Guid.Parse("b7decd4f-e20d-45f5-b16b-da6f55d456a1");

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
