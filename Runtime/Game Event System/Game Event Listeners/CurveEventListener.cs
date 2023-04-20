using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class CurveEventListener : MonoBehaviour, IGameEventListener<AnimationCurve>
    {
        [SerializeField] protected GameEvent<AnimationCurve> gameEvent;
        [SerializeField] protected UnityEvent<AnimationCurve> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void EventRaised(AnimationCurve curve) => unityEvent?.Invoke(curve);
    }
}