using System.ComponentModel;
using Exiled.API.Interfaces;

namespace RPSize
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Are debug messages displayed?")]
        public bool Debug { get; set; } = false;
        
        [Description("Minimum size of the player.")]
        public float MinSize { get; set; } = .8f;
        
        [Description("Maximum size of the player.")]
        public float MaxSize { get; set; } = 1.2f;
    }
}
