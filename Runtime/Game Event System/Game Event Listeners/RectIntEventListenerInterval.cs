using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class RectIntEventListenerInterval : RectIntEventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent<RectInt> delayedEvent;

        public override void EventRaised(RectInt rect)
        {
            unityEvent?.Invoke(rect);
            DelayEvent(rect);
        }

        private async void DelayEvent(RectInt rect)
        {
            await Task.Delay((int)(timeBetweenEvents * 1000f));
            delayedEvent?.Invoke(rect);
        }

        private void OnValidate()
        {
            if (timeBetweenEvents < 0f)
                timeBetweenEvents = 0f;
        }
    }
}
