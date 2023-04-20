using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class RectIntEventListenerPeriodic : RectIntEventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(RectInt rect) => FireEventPeriodically(rect);

        private async void FireEventPeriodically(RectInt rect)
        {
            for (int i = 0; i < periods; i++)
            {
                unityEvent?.Invoke(rect);
                await Task.Delay((int)(delay * 1000f));
            }
        }
    }
}