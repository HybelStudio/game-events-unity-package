using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class LongEventListener : MonoBehaviour, IGameEventListener<long>
    {
        [SerializeField] protected GameEvent<long> gameEvent;
        [SerializeField] protected UnityEvent<long> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void EventRaised(long value) => unityEvent?.Invoke(value);
    }
}