using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class CurveEventListenerInterval : CurveEventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent<AnimationCurve> delayedEvent;

        public override void RaiseEvent(AnimationCurve curve)
        {
            unityEvent?.Invoke(curve);
            DelayEvent(curve);
        }

        private async void DelayEvent(AnimationCurve curve)
        {
            await Task.Delay((int)(timeBetweenEvents * 1000f));
            delayedEvent?.Invoke(curve);
        }

        private void OnValidate()
        {
            if (timeBetweenEvents < 0f)
                timeBetweenEvents = 0f;
        }
    }
}
