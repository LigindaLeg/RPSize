using Exiled.Events.EventArgs.Player;
using UnityEngine;

namespace RPSize
{
    public class EventHandlers
    {
        public void OnPlayerSpawned(SpawnedEventArgs ev)
        {
            if (ev.Player.Role.Team != PlayerRoles.Team.SCPs)
            {
                float psize = Random.Range(Plugin.Instance.Config.MinSize, Plugin.Instance.Config.MaxSize);
                ev.Player.Scale = new Vector3(psize, psize, psize);
            }
            
        }
    }
}