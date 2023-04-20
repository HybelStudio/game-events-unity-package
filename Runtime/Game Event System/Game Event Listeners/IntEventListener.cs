using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class IntEventListener : MonoBehaviour, IGameEventListener<int>
    {
        [SerializeField] protected GameEvent<int> gameEvent;
        [SerializeField] protected UnityEvent<int> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void EventRaised(int value) => unityEvent?.Invoke(value);
    }
}