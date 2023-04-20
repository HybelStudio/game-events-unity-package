using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class Vector3EventListener : MonoBehaviour, IGameEventListener<Vector3>
    {
        [SerializeField] protected GameEvent<Vector3> gameEvent;
        [SerializeField] protected UnityEvent<Vector3> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void EventRaised(Vector3 vector) => unityEvent?.Invoke(vector);
    }
}