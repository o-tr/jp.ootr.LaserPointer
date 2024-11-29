using UdonSharp;
using UnityEngine;

namespace jp.ootr.LaserPointer
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.NoVariableSync)]
    public class EventPropagator : UdonSharpBehaviour
    {
        [SerializeField] private LaserPointer laserPointer;

        public override void OnPickupUseDown()
        {
            if (laserPointer == null) return;
            laserPointer.Interact();
        }
    }
}