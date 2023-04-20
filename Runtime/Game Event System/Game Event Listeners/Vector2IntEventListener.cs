using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class Vector2IntEventListener : MonoBehaviour, IGameEventListener<Vector2Int>
    {
        [SerializeField] protected GameEvent<Vector2Int> gameEvent;
        [SerializeField] protected UnityEvent<Vector2Int> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void RaiseEvent(Vector2Int vector) => unityEvent?.Invoke(vector);
    }
}