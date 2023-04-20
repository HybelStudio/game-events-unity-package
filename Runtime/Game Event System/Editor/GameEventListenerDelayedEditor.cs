using UnityEditor;

using static UnityEditor.EditorGUILayout;

namespace Hybel.GameEvents.Editor
{
    [CustomEditor(typeof(GameEventListenerDelayed))]
    public class GameEventListenerDelayedEditor : UnityEditor.Editor
    {
        private SerializedObject _so;
        private SerializedProperty _propGameEvent;
        private SerializedProperty _propDelay;
        private SerializedProperty _propUnityEvent;

        private void OnEnable()
        {
            _so = serializedObject;
            _propGameEvent = _so.FindProperty("gameEvent");
            _propDelay = _so.FindProperty("delay");
            _propUnityEvent = _so.FindProperty("unityEvent");
        }

        public override void OnInspectorGUI()
        {
            _so.Update();
            PropertyField(_propGameEvent);
            PropertyField(_propDelay);
            PropertyField(_propUnityEvent);
            _so.ApplyModifiedProperties();
        }
    }

    [CustomEditor(typeof(BooleanEventListenerDelayed))]
    public class BooleanEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(BoundsEventListenerDelayed))]
    public class BoundsEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(BoundsIntEventListenerDelayed))]
    public class BoundsIntEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(ColorEventListenerDelayed))]
    public class ColorEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(CurveEventListenerDelayed))]
    public class CurveEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(DoubleEventListenerDelayed))]
    public class DoubleEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(FloatEventListenerDelayed))]
    public class FloatEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(GameObjectEventListenerDelayed))]
    public class GameObjectEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(GradientEventListenerDelayed))]
    public class GradientEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(IntEventListenerDelayed))]
    public class IntEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(LayerMaskEventListenerDelayed))]
    public class LayerMaskEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(LongEventListenerDelayed))]
    public class LongEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(RectEventListenerDelayed))]
    public class RectEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(RectIntEventListenerDelayed))]
    public class RectIntEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(StringEventListenerDelayed))]
    public class StringEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(Vector2EventListenerDelayed))]
    public class Vector2EventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(Vector3EventListenerDelayed))]
    public class Vector3EventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(Vector4EventListenerDelayed))]
    public class Vector4EventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(Vector2IntEventListenerDelayed))]
    public class Vector2IntEventListenerDelayedEditor : GameEventListenerDelayedEditor { }

    [CustomEditor(typeof(Vector3IntEventListenerDelayed))]
    public class Vector3IntEventListenerDelayedEditor : GameEventListenerDelayedEditor { }
}
