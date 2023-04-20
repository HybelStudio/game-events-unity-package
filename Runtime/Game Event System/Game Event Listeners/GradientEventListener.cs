using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class GradientEventListener : MonoBehaviour, IGameEventListener<Gradient>
    {
        [SerializeField] protected GameEvent<Gradient> gameEvent;
        [SerializeField] protected UnityEvent<Gradient> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void RaiseEvent(Gradient gradient) => unityEvent?.Invoke(gradient);
    }
}