using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class Vector2IntEventListenerInterval : Vector2IntEventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent<Vector2Int> delayedEvent;

        public override void EventRaised(Vector2Int vector)
        {
            unityEvent?.Invoke(vector);
            DelayEvent(vector);
        }

        private async void DelayEvent(Vector2Int vector)
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
