using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class GameEventListenerPeriodic : GameEventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent() => FireEventPeriodically();

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