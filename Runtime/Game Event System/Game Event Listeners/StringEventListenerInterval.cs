using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class StringEventListenerInterval : StringEventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent<string> delayedEvent;

        public override void EventRaised(string value)
        {
            unityEvent?.Invoke(value);
            DelayEvent(value);
        }

        private async void DelayEvent(string value)
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
