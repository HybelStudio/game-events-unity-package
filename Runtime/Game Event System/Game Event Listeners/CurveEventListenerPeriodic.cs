using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class CurveEventListenerPeriodic : CurveEventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(AnimationCurve curve) => FireEventPeriodically(curve);

        private async void FireEventPeriodically(AnimationCurve curve)
        {
            for (int i = 0; i < periods; i++)
            {
                unityEvent?.Invoke(curve);
                await Task.Delay((int)(delay * 1000f));
            }
        }
    }
}