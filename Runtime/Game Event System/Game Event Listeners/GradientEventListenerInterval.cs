using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class GradientEventListenerInterval : GradientEventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent<Gradient> delayedEvent;

        public override void RaiseEvent(Gradient gradient)
        {
            unityEvent?.Invoke(gradient);
            DelayEvent(gradient);
        }

        private async void DelayEvent(Gradient gradient)
        {
            await Task.Delay((int)(timeBetweenEvents * 1000f));
            delayedEvent?.Invoke(gradient);
        }

        private void OnValidate()
        {
            if (timeBetweenEvents < 0f)
                timeBetweenEvents = 0f;
        }
    }
}
