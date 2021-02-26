using UnityEngine;

namespace AutoMapPins
{
    class PinnedObject: MonoBehaviour
    {
        public Minimap.PinData pin;

        public void Init(string aName)
        {
            pin = Minimap.instance.AddPin(transform.position, Minimap.PinType.Icon3, aName, false, false);
            Mod.Log.LogInfo(string.Format("Tracking: {0} at {1} {2} {3}", aName, transform.position.x, transform.position.y, transform.position.z));
        }

        void OnDestroy()
        {
            if (pin != null && Minimap.instance != null)
            {
                Minimap.instance.RemovePin(pin);
                Mod.Log.LogInfo(string.Format("Removing: {0} at {1} {2} {3}", pin.m_name, transform.position.x, transform.position.y, transform.position.z));
            }
        }
    }
}
