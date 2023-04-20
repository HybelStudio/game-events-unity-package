using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class Vector2EventListenerDelayed : Vector2EventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(Vector2 vector) => DelayEvent(vector);

        private async void DelayEvent(Vector2 vector)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(vector);
        }
    }
}