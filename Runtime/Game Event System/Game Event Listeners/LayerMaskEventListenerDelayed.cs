using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class LayerMaskEventListenerDelayed : LayerMaskEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(LayerMask layerMask) => DelayEvent(layerMask);

        private async void DelayEvent(LayerMask layerMask)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(layerMask);
        }
    }
}