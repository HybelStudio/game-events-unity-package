using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class GameObjectEventListenerDelayed : GameObjectEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(GameObject gameObject) => DelayEvent(gameObject);

        private async void DelayEvent(GameObject gameObject)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(gameObject);
        }
    }
}