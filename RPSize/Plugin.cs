using System;
using Exiled.API.Features;
using Exiled.Events.Features;

namespace RPSize
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "RPSize";
        public override string Author => "Liginda";
        public override Version Version => new Version(1, 0, 1);
        public override Version RequiredExiledVersion => new Version(8, 9, 5);

        public static Plugin Instance;
        public EventHandlers eventHandlers;
        public Random RNG = new Random();

        public override void OnEnabled()
        {
            Instance = this;
            this.eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Player.Spawned += new CustomEventHandler<Exiled.Events.EventArgs.Player.SpawnedEventArgs>(eventHandlers.OnPlayerSpawned);

            Log.Debug("Random Player Size enabled.");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Spawned -= new CustomEventHandler<Exiled.Events.EventArgs.Player.SpawnedEventArgs>(eventHandlers.OnPlayerSpawned);
            Instance = null;
            this.eventHandlers = null;

            Log.Debug("Random Player Size disabled.");
            base.OnDisabled();
        }
    }
}
