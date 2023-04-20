using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class GameObjectEventListener : MonoBehaviour, IGameEventListener<GameObject>
    {
        [SerializeField] protected GameEvent<GameObject> gameEvent;
        [SerializeField] protected UnityEvent<GameObject> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void EventRaised(GameObject gameObject) => unityEvent?.Invoke(gameObject);
    }
}