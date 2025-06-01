using System;
using Exiled.API.Features;
using Exiled.Events.Features;

namespace RPSize
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "RPSize";
        public override string Author => "Liginda";
        public override Version Version => new Version(1, 1, 0);
        public override string Prefix => "RPSize";

        public static Plugin Instance;
        public EventHandlers eventHandlers;
        public Random RNG = new Random();

        public override void OnEnabled()
        {
            Instance = this;
            this.eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Player.Spawned += new CustomEventHandler<Exiled.Events.EventArgs.Player.SpawnedEventArgs>(eventHandlers.OnPlayerSpawned);
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Spawned -= new CustomEventHandler<Exiled.Events.EventArgs.Player.SpawnedEventArgs>(eventHandlers.OnPlayerSpawned);
            Instance = null;
            this.eventHandlers = null;
            base.OnDisabled();
        }
    }
}
