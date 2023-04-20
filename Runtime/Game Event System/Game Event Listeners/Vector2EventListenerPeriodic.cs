using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class Vector2EventListenerPeriodic : Vector2EventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(Vector2 vector) => FireEventPeriodically(vector);

        private async void FireEventPeriodically(Vector2 vector)
        {
            for (int i = 0; i < periods; i++)
            {
                unityEvent?.Invoke(vector);
                await Task.Delay((int)(delay * 1000f));
            }
        }
    }
}