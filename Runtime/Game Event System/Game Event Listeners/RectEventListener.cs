using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class RectEventListener : MonoBehaviour, IGameEventListener<Rect>
    {
        [SerializeField] protected GameEvent<Rect> gameEvent;
        [SerializeField] protected UnityEvent<Rect> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void EventRaised(Rect rect) => unityEvent?.Invoke(rect);
    }
}