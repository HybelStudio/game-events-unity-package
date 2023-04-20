using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class GameEventListenerDelayed : GameEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised() => DelayEvent();

        private async void DelayEvent()
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke();
        }
    }
}