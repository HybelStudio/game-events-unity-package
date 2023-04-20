using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class BooleanEventListener : MonoBehaviour, IGameEventListener<bool>
    {
        [SerializeField] protected GameEvent<bool> gameEvent;
        [SerializeField] protected UnityEvent<bool> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void RaiseEvent(bool arg) => unityEvent?.Invoke(arg);
    }
}