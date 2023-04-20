using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class Vector2IntEventListenerDelayed : Vector2IntEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(Vector2Int vector) => DelayEvent(vector);

        private async void DelayEvent(Vector2Int vector)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(vector);
        }
    }
}