using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class RectIntEventListener : MonoBehaviour, IGameEventListener<RectInt>
    {
        [SerializeField] protected GameEvent<RectInt> gameEvent;
        [SerializeField] protected UnityEvent<RectInt> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void RaiseEvent(RectInt rect) => unityEvent?.Invoke(rect);
    }
}