using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class BooleanEventListenerDelayed : BooleanEventListener
    {
        [SerializeField] protected float delay;

        public override void EventRaised(bool value) => DelayEvent(value);

        private async void DelayEvent(bool value)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(value);
        }

        private void OnValidate()
        {
            if (delay < 0f)
                delay = 0f;
        }
    }
}