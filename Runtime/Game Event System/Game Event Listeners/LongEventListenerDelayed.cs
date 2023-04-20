using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class LongEventListenerDelayed : LongEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(long value) => DelayEvent(value);

        private async void DelayEvent(long value)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(value);
        }
    }
}