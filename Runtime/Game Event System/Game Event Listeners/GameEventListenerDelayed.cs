using System.Threading.Tasks;
using UnityEngine;
#if HYBEL_VARIABLES
using Hybel.Variables;
#endif

namespace Hybel.GameEvents
{
    public class GameEventListenerDelayed : GameEventListener
    {
#if HYBEL_VARIABLES
        [SerializeField, MinValue(0f)] protected FloatRef delay;
#else
        [SerializeField, Min(0f)] protected float delay;
#endif

        public override void EventRaised() => DelayEvent();

        private async void DelayEvent()
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke();
        }
    }
}