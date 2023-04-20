using UnityEngine;
using UnityEngine.Events;

namespace Hybel.GameEvents
{
    public class LayerMaskEventListener : MonoBehaviour, IGameEventListener<LayerMask>
    {
        [SerializeField] protected GameEvent<LayerMask> gameEvent;
        [SerializeField] protected UnityEvent<LayerMask> unityEvent;

        private void Awake() => gameEvent += this;

        private void OnDestroy() => gameEvent -= this;

        public virtual void RaiseEvent(LayerMask layerMask) => unityEvent?.Invoke(layerMask);
    }
}