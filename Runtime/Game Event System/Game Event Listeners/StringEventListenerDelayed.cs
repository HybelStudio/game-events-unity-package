using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class StringEventListenerDelayed : StringEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(string value) => DelayEvent(value);

        private async void DelayEvent(string value)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(value);
        }
    }
}