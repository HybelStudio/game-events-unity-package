using UnityEditor;

using static UnityEditor.EditorGUILayout;

namespace Hybel.GameEvents.Editor
{
	[CustomEditor(typeof(GameEventListenerInterval))]
	public class GameEventListenerIntervalEditor : UnityEditor.Editor
	{
		private SerializedObject _so;
		private SerializedProperty _propGameEvent;
		private SerializedProperty _propTimeBetweenEvents;
		private SerializedProperty _propUnityEvent;
		private SerializedProperty _propDelayedEvent;

		private void OnEnable()
		{
			_so = serializedObject;
			_propGameEvent = _so.FindProperty("gameEvent");
			_propTimeBetweenEvents = _so.FindProperty("timeBetweenEvents");
			_propUnityEvent = _so.FindProperty("unityEvent");
			_propDelayedEvent = _so.FindProperty("delayedEvent");
		}

		public override void OnInspectorGUI()
		{
			_so.Update();
			PropertyField(_propGameEvent);
			PropertyField(_propTimeBetweenEvents);
			PropertyField(_propUnityEvent);
			PropertyField(_propDelayedEvent);
			_so.ApplyModifiedProperties();
		}
	}

	[CustomEditor(typeof(BooleanEventListenerInterval))]
	public class BooleanEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(BoundsEventListenerInterval))]
	public class BoundsEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(BoundsIntEventListenerInterval))]
	public class BoundsIntEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(ColorEventListenerInterval))]
	public class ColorEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(CurveEventListenerInterval))]
	public class CurveEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(DoubleEventListenerInterval))]
	public class DoubleEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(FloatEventListenerInterval))]
	public class FloatEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(GameObjectEventListenerInterval))]
	public class GameObjectEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(GradientEventListenerInterval))]
	public class GradientEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(IntEventListenerInterval))]
	public class IntEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(LayerMaskEventListenerInterval))]
	public class LayerMaskEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(LongEventListenerInterval))]
	public class LongEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(RectEventListenerInterval))]
	public class RectEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(RectIntEventListenerInterval))]
	public class RectIntEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(StringEventListenerInterval))]
	public class StringEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(Vector2EventListenerInterval))]
	public class Vector2EventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(Vector3EventListenerInterval))]
	public class Vector3EventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(Vector4EventListenerInterval))]
	public class Vector4EventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(Vector2IntEventListenerInterval))]
	public class Vector2IntEventListenerIntervalEditor : GameEventListenerIntervalEditor { }

	[CustomEditor(typeof(Vector3IntEventListenerInterval))]
	public class Vector3IntEventListenerIntervalEditor : GameEventListenerIntervalEditor { }
}