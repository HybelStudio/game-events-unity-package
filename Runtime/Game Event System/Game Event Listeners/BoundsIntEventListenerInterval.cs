using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class BoundsIntEventListenerInterval : BoundsIntEventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent<BoundsInt> delayedEvent;

        public override void RaiseEvent(BoundsInt bounds)
        {
            unityEvent?.Invoke(bounds);
            DelayEvent(bounds);
        }

        private async void DelayEvent(BoundsInt bounds)
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
