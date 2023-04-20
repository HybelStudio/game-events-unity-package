using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class BoundsEventListener : MonoBehaviour, IGameEventListener<Bounds>
    {
        [SerializeField] protected GameEvent<Bounds> gameEvent;
        [SerializeField] protected UnityEvent<Bounds> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void RaiseEvent(Bounds bounds) => unityEvent?.Invoke(bounds);
    }
}