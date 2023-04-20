using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class Vector3EventListenerInterval : Vector3EventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent<Vector3> delayedEvent;

        public override void RaiseEvent(Vector3 vector)
        {
            unityEvent?.Invoke(vector);
            DelayEvent(vector);
        }

        private async void DelayEvent(Vector3 vector)
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
