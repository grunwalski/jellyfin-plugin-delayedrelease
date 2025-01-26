#!/bin/bash

# Build the plugin
dotnet build

# Create output directory if it doesn't exist
mkdir -p Jellyfin.Plugin.DelayedRelease/bin/Debug/net8.0

# Generate meta.json from build.yaml values
cat > Jellyfin.Plugin.DelayedRelease/bin/Debug/net8.0/meta.json << EOF
{
  "category": "General",
  "changelog": "### Initial Release ###\n- Basic plugin structure",
  "description": "A plugin that allows you to control when media becomes available in your library.\n",
  "guid": "b7decd4f-e20d-45f5-b16b-da6f55d456a1",
  "name": "Delayed Release",
  "overview": "A plugin for delayed release of media",
  "owner": "your-username",
  "targetAbi": "10.*",
  "timestamp": "$(date -u +"%Y-%m-%dT%H:%M:%S.0000000Z")",
  "version": "0.0.0.2",
  "status": "Active",
  "autoUpdate": false,
  "imagePath": "",
  "assemblies": []
}
EOF

echo "Build complete. meta.json has been generated."
