using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class FloatEventListener : MonoBehaviour, IGameEventListener<float>
    {
        [SerializeField] protected GameEvent<float> gameEvent;
        [SerializeField] protected UnityEvent<float> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void RaiseEvent(float value) => unityEvent?.Invoke(value);
    }
}