using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class Vector2EventListener : MonoBehaviour, IGameEventListener<Vector2>
    {
        [SerializeField] protected GameEvent<Vector2> gameEvent;
        [SerializeField] protected UnityEvent<Vector2> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void RaiseEvent(Vector2 vector) => unityEvent?.Invoke(vector);
    }
}