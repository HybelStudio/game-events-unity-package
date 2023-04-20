using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class FloatEventListenerDelayed : FloatEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(float value) => DelayEvent(value);

        private async void DelayEvent(float value)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(value);
        }
    }
}