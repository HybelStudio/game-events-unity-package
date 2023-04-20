using UnityEditor;

using static UnityEditor.EditorGUILayout;

namespace Hybel.GameEvents.Editor
{
    [CustomEditor(typeof(GameEventListenerPeriodic))]
    public class GameEventListenerPeriodicEditor : UnityEditor.Editor
    {
        private SerializedObject _so;
        private SerializedProperty _propGameEvent;
        private SerializedProperty _propDelay;
        private SerializedProperty _propPeriods;
        private SerializedProperty _propUnityEvent;

        private void OnEnable()
        {
            _so = serializedObject;
            _propGameEvent = _so.FindProperty("gameEvent");
            _propDelay = _so.FindProperty("delay");
            _propPeriods = _so.FindProperty("periods");
            _propUnityEvent = _so.FindProperty("unityEvent");
        }

        public override void OnInspectorGUI()
        {
            _so.Update();
            PropertyField(_propGameEvent);
            PropertyField(_propDelay);
            PropertyField(_propPeriods);
            PropertyField(_propUnityEvent);
            _so.ApplyModifiedProperties();
        }
    }

    [CustomEditor(typeof(BooleanEventListenerPeriodic))]
    public class BooleanEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(BoundsEventListenerPeriodic))]
    public class BoundsEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(BoundsIntEventListenerPeriodic))]
    public class BoundsIntEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(ColorEventListenerPeriodic))]
    public class ColorEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(CurveEventListenerPeriodic))]
    public class CurveEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(DoubleEventListenerPeriodic))]
    public class DoubleEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(FloatEventListenerPeriodic))]
    public class FloatEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(GameObjectEventListenerPeriodic))]
    public class GameObjectEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(GradientEventListenerPeriodic))]
    public class GradientEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(IntEventListenerPeriodic))]
    public class IntEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(LayerMaskEventListenerPeriodic))]
    public class LayerMaskEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(LongEventListenerPeriodic))]
    public class LongEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(RectEventListenerPeriodic))]
    public class RectEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(RectIntEventListenerPeriodic))]
    public class RectIntEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(StringEventListenerPeriodic))]
    public class StringEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(Vector2EventListenerPeriodic))]
    public class Vector2EventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(Vector3EventListenerPeriodic))]
    public class Vector3EventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(Vector4EventListenerPeriodic))]
    public class Vector4EventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(Vector2IntEventListenerPeriodic))]
    public class Vector2IntEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }

    [CustomEditor(typeof(Vector3IntEventListenerPeriodic))]
    public class Vector3IntEventListenerPeriodicEditor : GameEventListenerPeriodicEditor { }
}
