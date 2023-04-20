using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class RectEventListenerPeriodic : RectEventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(Rect rect) => FireEventPeriodically(rect);

        private async void FireEventPeriodically(Rect rect)
        {
            for (int i = 0; i < periods; i++)
            {
                unityEvent?.Invoke(rect);
                await Task.Delay((int)(delay * 1000f));
            }
        }
    }
}