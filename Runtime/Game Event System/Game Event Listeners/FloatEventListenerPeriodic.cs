using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class FloatEventListenerPeriodic : FloatEventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(float value) => FireEventPeriodically(value);

        private async void FireEventPeriodically(float value)
        {
            for (int i = 0; i < periods; i++)
            {
                unityEvent?.Invoke(value);
                await Task.Delay((int)(delay * 1000f));
            }
        }
    }
}