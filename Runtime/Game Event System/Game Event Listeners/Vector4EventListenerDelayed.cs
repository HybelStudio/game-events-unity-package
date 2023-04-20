using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class Vector4EventListenerDelayed : Vector4EventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(Vector4 vector) => DelayEvent(vector);

        private async void DelayEvent(Vector4 vector)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(vector);
        }
    }
}