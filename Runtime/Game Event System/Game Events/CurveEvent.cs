using UnityEngine;

namespace Hybel.GameEvents
{
    [CreateAssetMenu(fileName = "New Curve Event", menuName = "Game Events/Curve Event", order = -108)]
    public class CurveEvent : GameEvent<AnimationCurve> { }
}
