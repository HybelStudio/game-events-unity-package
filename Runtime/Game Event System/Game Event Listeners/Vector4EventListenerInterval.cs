using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class Vector4EventListenerInterval : Vector4EventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent<Vector4> delayedEvent;

        public override void EventRaised(Vector4 vector)
        {
            unityEvent?.Invoke(vector);
            DelayEvent(vector);
        }

        private async void DelayEvent(Vector4 vector)
        {
            await Task.Delay((int)(timeBetweenEvents * 1000f));
            delayedEvent?.Invoke(vector);
        }

        private void OnValidate()
        {
            if (timeBetweenEvents < 0f)
                timeBetweenEvents = 0f;
        }
    }
}
