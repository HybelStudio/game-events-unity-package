using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class BoundsIntEventListener : MonoBehaviour, IGameEventListener<BoundsInt>
    {
        [SerializeField] protected GameEvent<BoundsInt> gameEvent;
        [SerializeField] protected UnityEvent<BoundsInt> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void EventRaised(BoundsInt bounds) => unityEvent?.Invoke(bounds);
    }
}