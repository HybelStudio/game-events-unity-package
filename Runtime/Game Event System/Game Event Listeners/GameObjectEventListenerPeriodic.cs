using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class GameObjectEventListenerPeriodic : GameObjectEventListener
    {
        [Tooltip("Number of times the event will be fired. The first event is fired immediately.")]
        [SerializeField] protected int periods;
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(GameObject gameObject) => FireEventPeriodically(gameObject);

        private async void FireEventPeriodically(GameObject gameObject)
        {
            for (int i = 0; i < periods; i++)
            {
                unityEvent?.Invoke(gameObject);
                await Task.Delay((int)(delay * 1000f));
            }
        }
    }
}