using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class StringEventListener : MonoBehaviour, IGameEventListener<string>
    {
        [SerializeField] protected GameEvent<string> gameEvent;
        [SerializeField] protected UnityEvent<string> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void EventRaised(string value) => unityEvent?.Invoke(value);
    }
}