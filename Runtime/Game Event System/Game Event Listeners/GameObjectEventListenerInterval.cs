using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class GameObjectEventListenerInterval : GameObjectEventListener
    {
        [SerializeField, Min(0f)] protected float timeBetweenEvents;
        [SerializeField] protected UnityEvent<GameObject> delayedEvent;

        public override void RaiseEvent(GameObject gameObject)
        {
            unityEvent?.Invoke(gameObject);
            DelayEvent(gameObject);
        }

        private async void DelayEvent(GameObject gameObject)
        {
            await Task.Delay((int)(timeBetweenEvents * 1000f));
            delayedEvent?.Invoke(gameObject);
        }

        private void OnValidate()
        {
            if (timeBetweenEvents < 0f)
                timeBetweenEvents = 0f;
        }
    }
}
