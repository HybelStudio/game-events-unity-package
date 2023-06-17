using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
#if HYBEL_VARIABLES
using Hybel.Variables;
#endif

namespace Hybel.GameEvents
{
    public class GameEventListenerInterval : GameEventListener
    {
#if HYBEL_VARIABLES
        [SerializeField, MinValue(0f)] protected FloatRef timeBetweenEvents;
#else
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
#endif
        [SerializeField] protected UnityEvent delayedEvent;

        public override void EventRaised()
        {
            unityEvent?.Invoke();
            DelayEvent();
        }

        private async void DelayEvent()
        {
            await Task.Delay((int)(timeBetweenEvents * 1000f));
            delayedEvent?.Invoke();
        }
    }
}
