![Total downloads](https://img.shields.io/github/downloads/LigindaLeg/RPSize/total)

# RPSize
RPSize is an EXILED plugin for SCP: Secret Laboratory that randomly scales every player's size.

## Installation
1. Download the [latest release](https://github.com/LigindaLeg/RPSize/releases/latest) of the plugin from the GitHub repository.
2. Place the `RPSize.dll` file in your `EXILED/Plugins` directory.
3. Restart your SCP: Secret Laboratory server.

## Configuration
RPSize can be configured via the EXILED config file at `EXILED/Configs/{port}-config.yml`.

### Default Configuration
```yaml
r_p_size:
  # Is the plugin enabled?
  s_enabled: true
  # Are debug messages displayed?
  debug: false
  # Minimum size of the player.
  min_size: 0.800000012
  # Maximum size of the player.
  max_size: 1.20000005
```