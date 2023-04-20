using UnityEngine;

namespace Hybel.GameEvents
{
    [CreateAssetMenu(fileName = "New GameObject Event", menuName = "Game Events/GameObject Event", order = -105)]
    public class GameObjectEvent : GameEvent<GameObject> { }
}
