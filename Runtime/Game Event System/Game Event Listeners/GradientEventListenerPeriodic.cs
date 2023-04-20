using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class GradientEventListenerPeriodic : GradientEventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(Gradient gradient) => FireEventPeriodically(gradient);

        private async void FireEventPeriodically(Gradient gradient)
        {
            for (int i = 0; i < periods; i++)
            {
                unityEvent?.Invoke(gradient);
                await Task.Delay((int)(delay * 1000f));
            }
        }
    }
}