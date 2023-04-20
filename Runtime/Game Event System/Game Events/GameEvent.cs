using System.Collections.Generic;
using System;
using UnityEngine;

namespace Hybel.GameEvents
{
    [CreateAssetMenu(fileName = "New Game Event", menuName = "Game Events/Game Event", order = -111)]
    public class GameEvent : ScriptableObject, IGameEvent
    {
        protected HashSet<IGameEventListener> _gameEventListeners = new();
        protected HashSet<Action> _actionListeners = new();

        public virtual void Invoke()
        {
            foreach (IGameEventListener listener in _gameEventListeners)
                listener.RaiseEvent();

            foreach (Action actionListener in _actionListeners)
                actionListener?.Invoke();
        }

        public virtual void Subscribe(IGameEventListener listener) => _gameEventListeners.Add(listener);
        public virtual void Subscribe(Action action) => _actionListeners.Add(action);

        public virtual void Unsubscribe(IGameEventListener listener) => _gameEventListeners.Remove(listener);
        public virtual void Unsubscribe(Action action) => _actionListeners.Remove(action);

        public static GameEvent operator +(GameEvent gameEvent, IGameEventListener listener)
        {
            gameEvent.Subscribe(listener);
            return gameEvent;
        }

        public static GameEvent operator +(GameEvent gameEvent, Action action)
        {
            gameEvent.Subscribe(action);
            return gameEvent;
        }

        public static GameEvent operator -(GameEvent gameEvent, IGameEventListener listener)
        {
            gameEvent.Unsubscribe(listener);
            return gameEvent;
        }

        public static GameEvent operator -(GameEvent gameEvent, Action action)
        {
            gameEvent.Unsubscribe(action);
            return gameEvent;
        }
    }
}
