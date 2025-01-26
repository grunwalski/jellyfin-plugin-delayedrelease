using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Model.Tasks;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.DelayedRelease.ScheduledTasks
{
    /// <summary>
    /// Task to handle delayed releases.
    /// </summary>
    public class DelayedReleaseTask : IScheduledTask
    {
        private readonly ILogger<DelayedReleaseTask> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="DelayedReleaseTask"/> class.
        /// </summary>
        /// <param name="logger">Instance of the <see cref="ILogger"/> interface.</param>
        public DelayedReleaseTask(ILogger<DelayedReleaseTask> logger)
        {
            _logger = logger;
        }

        /// <inheritdoc/>
        public string Name => "Process delayed releases";

        /// <inheritdoc/>
        public string Key => "DelayedReleaseTask";

        /// <inheritdoc/>
        public string Description => "Processes media files based on their delayed release settings.";

        /// <inheritdoc/>
        public string Category => "DelayedRelease";

        /// <inheritdoc/>
        public async Task ExecuteAsync(IProgress<double> progress, CancellationToken cancellationToken)
        {
            _logger.LogInformation("=== HELLO WORLD: DelayedReleaseTask started ===");
            progress.Report(0);

            try
            {
                // Hier kommt später die eigentliche Implementierung
                await Task.Delay(1000, cancellationToken).ConfigureAwait(false);
                _logger.LogWarning("=== HELLO WORLD: DelayedReleaseTask is running ===");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "=== HELLO WORLD: Error in DelayedReleaseTask ===");
                throw;
            }

            _logger.LogInformation("=== HELLO WORLD: DelayedReleaseTask completed ===");
            progress.Report(100);
        }

        /// <inheritdoc/>
        public IEnumerable<TaskTriggerInfo> GetDefaultTriggers()
        {
            // Standardmäßig alle 24 Stunden ausführen
            yield return new TaskTriggerInfo
            {
                Type = TaskTriggerInfo.TriggerInterval,
                IntervalTicks = TimeSpan.FromHours(24).Ticks
            };
        }
    }
}
