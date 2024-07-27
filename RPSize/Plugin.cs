using System;
using System.Collections.Generic;
using Exiled.API.Features;
using MEC;
using UnityEngine;
using PlayerRoles;
using Exiled.Events.EventArgs.Map;
using Exiled.Events.EventArgs.Server;
using Exiled.Events.Features;

namespace RPSize
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "RPSize";
        public override string Author => "Liginda";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 9, 5);

        public static Plugin Instance;
        public EventHandlers eventHandlers;

        public override void OnEnabled()
        {
            Instance = this;
            this.eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Player.Spawned += new CustomEventHandler<Exiled.Events.EventArgs.Player.SpawnedEventArgs>(eventHandlers.OnPlayerSpawned);

            Log.Info("Random Player Size enabled.");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            this.eventHandlers = null;
            Exiled.Events.Handlers.Player.Spawned -= new CustomEventHandler<Exiled.Events.EventArgs.Player.SpawnedEventArgs>(eventHandlers.OnPlayerSpawned);

            Log.Info("Random Player Size disabled.");
            base.OnDisabled();
        }
    }
}
