using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class ColorEventListenerDelayed : ColorEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void RaiseEvent(Color color) => DelayEvent(color);

        private async void DelayEvent(Color color)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(color);
        }
    }
}