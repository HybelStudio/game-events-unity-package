using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class BoundsEventListenerInterval : BoundsEventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent<Bounds> delayedEvent;

        public override void EventRaised(Bounds bounds)
        {
            unityEvent?.Invoke(bounds);
            DelayEvent(bounds);
        }

        private async void DelayEvent(Bounds bounds)
        {
            await Task.Delay((int)(timeBetweenEvents * 1000f));
            delayedEvent?.Invoke(bounds);
        }

        private void OnValidate()
        {
            if (timeBetweenEvents < 0f)
                timeBetweenEvents = 0f;
        }
    }
}
