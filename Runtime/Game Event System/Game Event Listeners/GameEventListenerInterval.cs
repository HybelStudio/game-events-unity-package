using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class GameEventListenerInterval : GameEventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent delayedEvent;

        public override void RaiseEvent()
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
