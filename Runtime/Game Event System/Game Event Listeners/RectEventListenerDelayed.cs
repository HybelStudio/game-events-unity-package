using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class RectEventListenerDelayed : RectEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(Rect rect) => DelayEvent(rect);

        private async void DelayEvent(Rect rect)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(rect);
        }
    }
}