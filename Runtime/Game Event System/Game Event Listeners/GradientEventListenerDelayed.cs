using System.Threading.Tasks;
using UnityEngine;

namespace Hybel.GameEvents
{
    public class GradientEventListenerDelayed : GradientEventListener
    {
        [SerializeField, Min(0f)] protected float delay;

        public override void EventRaised(Gradient gradient) => DelayEvent(gradient);

        private async void DelayEvent(Gradient gradient)
        {
            await Task.Delay((int)(delay * 1000f));
            unityEvent?.Invoke(gradient);
        }
    }
}