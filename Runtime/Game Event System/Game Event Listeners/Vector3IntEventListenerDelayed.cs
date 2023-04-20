using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class Vector3IntEventListenerDelayed : Vector3IntEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(Vector3Int vector) => DelayEvent(vector);

        private async void DelayEvent(Vector3Int vector)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(vector);
        }
    }
}