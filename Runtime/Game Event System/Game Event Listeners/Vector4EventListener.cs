using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class Vector4EventListener : MonoBehaviour, IGameEventListener<Vector4>
    {
        [SerializeField] protected GameEvent<Vector4> gameEvent;
        [SerializeField] protected UnityEvent<Vector4> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void RaiseEvent(Vector4 vector) => unityEvent?.Invoke(vector);
    }
}