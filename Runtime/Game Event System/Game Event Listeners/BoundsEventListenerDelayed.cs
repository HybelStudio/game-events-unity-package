using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class BoundsEventListenerDelayed : BoundsEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(Bounds bounds) => DelayEvent(bounds);

        private async void DelayEvent(Bounds bounds)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(bounds);
        }
    }
}