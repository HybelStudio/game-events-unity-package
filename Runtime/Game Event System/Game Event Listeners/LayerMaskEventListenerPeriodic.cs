using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class LayerMaskEventListenerPeriodic : LayerMaskEventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(LayerMask layerMask) => FireEventPeriodically(layerMask);

        private async void FireEventPeriodically(LayerMask layerMask)
        {
            for (int i = 0; i < periods; i++)
            {
                unityEvent?.Invoke(layerMask);
                await Task.Delay((int)(delay * 1000f));
            }
        }
    }
}