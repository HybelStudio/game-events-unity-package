using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class IntEventListenerDelayed : IntEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(int value) => DelayEvent(value);

        private async void DelayEvent(int value)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(value);
        }
    }
}