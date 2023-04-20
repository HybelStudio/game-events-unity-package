using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class BoundsIntEventListenerPeriodic : BoundsIntEventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(BoundsInt bounds) => FireEventPeriodically(bounds);

        private async void FireEventPeriodically(BoundsInt bounds)
        {
            for (int i = 0; i < periods; i++)
            {
                unityEvent?.Invoke(bounds);
                await Task.Delay((int)(delay * 1000f));
            }
        }
    }
}