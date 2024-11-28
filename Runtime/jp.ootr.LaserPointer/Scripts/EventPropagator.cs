using UdonSharp;
using UnityEngine;
using VRC.Udon.Common;

namespace jp.ootr.LaserPointer
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.NoVariableSync)]
    public class EventPropagator : UdonSharpBehaviour
    {
        [SerializeField] private LaserPointer laserPointer;

        public override void InputUse(bool value, UdonInputEventArgs args)
        {
            base.InputUse(value, args);
            if (value)
            {
                laserPointer.Interact();
            }
        }
    }
}