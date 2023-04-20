using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class Vector2IntEventListenerPeriodic : Vector2IntEventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(Vector2Int vector) => FireEventPeriodically(vector);

        private async void FireEventPeriodically(Vector2Int vector)
        {
            for (int i = 0; i < periods; i++)
            {
                unityEvent?.Invoke(vector);
                await Task.Delay((int)(delay * 1000f));
            }
        }
    }
}