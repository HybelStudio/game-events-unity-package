using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class RectIntEventListenerDelayed : RectIntEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(RectInt rect) => DelayEvent(rect);

        private async void DelayEvent(RectInt rect)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(rect);
        }
    }
}