using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class DoubleEventListener : MonoBehaviour, IGameEventListener<double>
    {
        [SerializeField] protected GameEvent<double> gameEvent;
        [SerializeField] protected UnityEvent<double> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void RaiseEvent(double value) => unityEvent?.Invoke(value);
    }
}