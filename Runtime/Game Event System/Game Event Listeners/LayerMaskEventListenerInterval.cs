using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class LayerMaskEventListenerInterval : LayerMaskEventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent<LayerMask> delayedEvent;

        public override void RaiseEvent(LayerMask layerMask)
        {
            unityEvent?.Invoke(layerMask);
            DelayEvent(layerMask);
        }

        private async void DelayEvent(LayerMask layerMask)
        {
            await Task.Delay((int)(timeBetweenEvents * 1000f));
            delayedEvent?.Invoke(layerMask);
        }

        private void OnValidate()
        {
            if (timeBetweenEvents < 0f)
                timeBetweenEvents = 0f;
        }
    }
}
