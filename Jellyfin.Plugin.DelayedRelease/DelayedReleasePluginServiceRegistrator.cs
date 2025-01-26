using Jellyfin.Plugin.DelayedRelease.ScheduledTasks;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Controller;
using MediaBrowser.Controller.Library;
using MediaBrowser.Controller.Plugins;
using Microsoft.Extensions.DependencyInjection;

namespace Jellyfin.Plugin.DelayedRelease
{
    /// <summary>
    /// Service registrator for the DelayedRelease plugin.
    /// </summary>
    public class DelayedReleasePluginServiceRegistrator : IPluginServiceRegistrator
    {
        /// <inheritdoc />
        public void RegisterServices(IServiceCollection serviceCollection, IServerApplicationHost applicationHost)
        {
            // Keine explizite Registrierung nötig - Jellyfin findet IScheduledTask-Implementierungen automatisch
        }
    }
}
