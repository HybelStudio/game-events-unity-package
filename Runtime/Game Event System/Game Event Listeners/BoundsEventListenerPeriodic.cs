using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class BoundsEventListenerPeriodic : BoundsEventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(Bounds bounds) => FireEventPeriodically(bounds);

        private async void FireEventPeriodically(Bounds bounds)
        {
            for (int i = 0; i < periods; i++)
            {
                unityEvent?.Invoke(bounds);
                await Task.Delay((int)(delay * 1000f));
            }
        }
    }
}