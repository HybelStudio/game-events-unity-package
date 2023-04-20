using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class LongEventListenerInterval : LongEventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent<long> delayedEvent;

        public override void EventRaised(long value)
        {
            unityEvent?.Invoke(value);
            DelayEvent(value);
        }

        private async void DelayEvent(long value)
        {
            await Task.Delay((int)(timeBetweenEvents * 1000f));
            delayedEvent?.Invoke(value);
        }

        private void OnValidate()
        {
            if (timeBetweenEvents < 0f)
                timeBetweenEvents = 0f;
        }
    }
}
