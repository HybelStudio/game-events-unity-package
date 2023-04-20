using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class RectEventListenerInterval : RectEventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent<Rect> delayedEvent;

        public override void RaiseEvent(Rect rect)
        {
            unityEvent?.Invoke(rect);
            DelayEvent(rect);
        }

        private async void DelayEvent(Rect rect)
        {
            await Task.Delay((int)(timeBetweenEvents * 1000f));
            delayedEvent?.Invoke(rect);
        }

        private void OnValidate()
        {
            if (timeBetweenEvents < 0f)
                timeBetweenEvents = 0f;
        }
    }
}
