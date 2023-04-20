using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class Vector3IntEventListener : MonoBehaviour, IGameEventListener<Vector3Int>
    {
        [SerializeField] protected GameEvent<Vector3Int> gameEvent;
        [SerializeField] protected UnityEvent<Vector3Int> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void RaiseEvent(Vector3Int vector) => unityEvent?.Invoke(vector);
    }
}