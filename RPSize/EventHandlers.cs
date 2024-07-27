using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

namespace RPSize
{
    public class EventHandlers
    {
        public void OnPlayerSpawned(SpawnedEventArgs ev)
        {
            float psize;
            psize = UnityEngine.Random.Range(0.8f, 1.2f);
            ev.Player.Scale = new UnityEngine.Vector3(psize, psize, psize);
        }
    }
}
