using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class Vector3EventListenerDelayed : Vector3EventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(Vector3 vector) => DelayEvent(vector);

        private async void DelayEvent(Vector3 vector)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(vector);
        }
    }
}