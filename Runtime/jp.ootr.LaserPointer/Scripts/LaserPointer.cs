using jp.ootr.common;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

namespace jp.ootr.LaserPointer
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
    public class LaserPointer : BaseClass
    {
        [SerializeField] private GameObject toggleTargetParticle;
        
        [UdonSynced] private bool _isLaserOn;
        
        public override void Interact()
        {
            _isLaserOn = !_isLaserOn;
            Sync();
        }

        public override void OnPlayerJoined(VRCPlayerApi player)
        {
            base.OnPlayerJoined(player);
            if (!Networking.IsOwner(gameObject)) return;
            Sync();
        }

        public override void _OnDeserialization()
        {
            base._OnDeserialization();
            toggleTargetParticle.SetActive(_isLaserOn);
        }
    }
}