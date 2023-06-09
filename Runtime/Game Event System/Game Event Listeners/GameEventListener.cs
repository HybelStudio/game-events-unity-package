using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class GameEventListener : MonoBehaviour, IGameEventListener
    {
        [SerializeField] protected GameEvent gameEvent;
        [SerializeField] protected UnityEvent unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void EventRaised() => unityEvent?.Invoke();
    }
}