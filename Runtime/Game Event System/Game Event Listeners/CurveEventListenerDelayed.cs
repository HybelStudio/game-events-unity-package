using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class CurveEventListenerDelayed : CurveEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(AnimationCurve curve) => DelayEvent(curve);

        private async void DelayEvent(AnimationCurve curve)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(curve);
        }
    }
}