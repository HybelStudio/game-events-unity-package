using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class DoubleEventListenerDelayed : DoubleEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(double value) => DelayEvent(value);

        private async void DelayEvent(double value)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(value);
        }
    }
}