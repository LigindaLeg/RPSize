using Exiled.Events.EventArgs.Player;
using UnityEngine;

namespace RPSize
{
    public class EventHandlers
    {
        public void OnPlayerSpawned(SpawnedEventArgs ev)
        {
            float psize = (float) (Plugin.Instance.RNG.NextDouble() * (Plugin.Instance.Config.MaxSize - Plugin.Instance.Config.MinSize) + Plugin.Instance.Config.MinSize);
            ev.Player.Scale = new Vector3(psize, psize, psize);
        }
    }
}