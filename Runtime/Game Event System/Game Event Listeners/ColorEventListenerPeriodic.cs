using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class ColorEventListenerPeriodic : ColorEventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(Color color) => FireEventPeriodically(color);

        private async void FireEventPeriodically(Color color)
        {
            for (int i = 0; i < periods; i++)
            {
                unityEvent?.Invoke(color);
                await Task.Delay((int)(delay * 1000f));
            }
        }
    }
}