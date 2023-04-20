using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class BoundsIntEventListenerDelayed : BoundsIntEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(BoundsInt bounds) => DelayEvent(bounds);

        private async void DelayEvent(BoundsInt bounds)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(bounds);
        }
    }
}