using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class ColorEventListener : MonoBehaviour, IGameEventListener<Color>
    {
        [SerializeField] protected GameEvent<Color> gameEvent;
        [SerializeField] protected UnityEvent<Color> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void RaiseEvent(Color color) => unityEvent?.Invoke(color);
    }
}