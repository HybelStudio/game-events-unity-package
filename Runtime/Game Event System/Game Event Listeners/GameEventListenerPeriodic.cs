using System.Threading.Tasks;
using UnityEngine;
#if HYBEL_VARIABLES
using Hybel.Variables;
#endif

namespace Hybel.GameEvents
{
    public class GameEventListenerPeriodic : GameEventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
#if HYBEL_VARIABLES
        [SerializeField] protected IntRef periods;
        [SerializeField, MinValue(0f)] protected FloatRef delay;
#else
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;
#endif

        public override void EventRaised() => FireEventPeriodically();

        private async void FireEventPeriodically()
        {
            for (int i = 0; i < periods; i++)
            {
                unityEvent?.Invoke();
                await Task.Delay((int)(delay * 1000f));
            }
        }
    }
}