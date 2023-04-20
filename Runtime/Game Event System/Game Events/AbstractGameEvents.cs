using System;
using System.Collections.Generic;
using UnityEngine;

namespace Hybel.GameEvents
{
    public abstract class GameEvent<T> : ScriptableObject, IGameEvent<T>
    {
        protected HashSet<IGameEventListener<T>> _gameEventListeners = new();
        protected HashSet<Action<T>> _actionListeners = new();

        public virtual void Invoke(T arg)
        {
            foreach (IGameEventListener<T> listener in _gameEventListeners)
                listener.RaiseEvent(arg);

            foreach (Action<T> actionListener in _actionListeners)
                actionListener?.Invoke(arg);
        }

        public virtual void Subscribe(IGameEventListener<T> listener) => _gameEventListeners.Add(listener);
        public virtual void Subscribe(Action<T> action) => _actionListeners.Add(action);

        public virtual void Unsubscribe(IGameEventListener<T> listener) => _gameEventListeners.Remove(listener);
        public virtual void Unsubscribe(Action<T> action) => _actionListeners.Remove(action);

        public static GameEvent<T> operator +(GameEvent<T> gameEvent, IGameEventListener<T> listener)
        {
            gameEvent.Subscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T> operator +(GameEvent<T> gameEvent, Action<T> action)
        {
            gameEvent.Subscribe(action);
            return gameEvent;
        }

        public static GameEvent<T> operator -(GameEvent<T> gameEvent, IGameEventListener<T> listener)
        {
            gameEvent.Unsubscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T> operator -(GameEvent<T> gameEvent, Action<T> action)
        {
            gameEvent.Unsubscribe(action);
            return gameEvent;
        }
    }

    public abstract class GameEvent<T1, T2> : ScriptableObject, IGameEvent<T1, T2>
    {
        protected HashSet<IGameEventListener<T1, T2>> _gameEventListeners = new();
        protected HashSet<Action<T1, T2>> _actionListeners = new();

        public virtual void Invoke(T1 arg1, T2 arg2)
        {
            foreach (IGameEventListener<T1, T2> listener in _gameEventListeners)
                listener.RaiseEvent(arg1, arg2);

            foreach (Action<T1, T2> actionListener in _actionListeners)
                actionListener?.Invoke(arg1, arg2);
        }

        public virtual void Subscribe(IGameEventListener<T1, T2> listener) => _gameEventListeners.Add(listener);
        public virtual void Subscribe(Action<T1, T2> action) => _actionListeners.Add(action);

        public virtual void Unsubscribe(IGameEventListener<T1, T2> listener) => _gameEventListeners.Remove(listener);
        public virtual void Unsubscribe(Action<T1, T2> action) => _actionListeners.Remove(action);

        public static GameEvent<T1, T2> operator +(GameEvent<T1, T2> gameEvent, IGameEventListener<T1, T2> listener)
        {
            gameEvent.Subscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2> operator +(GameEvent<T1, T2> gameEvent, Action<T1, T2> action)
        {
            gameEvent.Subscribe(action);
            return gameEvent;
        }

        public static GameEvent<T1, T2> operator -(GameEvent<T1, T2> gameEvent, IGameEventListener<T1, T2> listener)
        {
            gameEvent.Unsubscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2> operator -(GameEvent<T1, T2> gameEvent, Action<T1, T2> action)
        {
            gameEvent.Unsubscribe(action);
            return gameEvent;
        }
    }

    public abstract class GameEvent<T1, T2, T3> : ScriptableObject, IGameEvent<T1, T2, T3>
    {
        protected HashSet<IGameEventListener<T1, T2, T3>> _gameEventListeners = new();
        protected HashSet<Action<T1, T2, T3>> _actionListeners = new();

        public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3)
        {
            foreach (IGameEventListener<T1, T2, T3> listener in _gameEventListeners)
                listener.RaiseEvent(arg1, arg2, arg3);

            foreach (Action<T1, T2, T3> actionListener in _actionListeners)
                actionListener?.Invoke(arg1, arg2, arg3);
        }

        public virtual void Subscribe(IGameEventListener<T1, T2, T3> listener) => _gameEventListeners.Add(listener);
        public virtual void Subscribe(Action<T1, T2, T3> action) => _actionListeners.Add(action);

        public virtual void Unsubscribe(IGameEventListener<T1, T2, T3> listener) => _gameEventListeners.Remove(listener);
        public virtual void Unsubscribe(Action<T1, T2, T3> action) => _actionListeners.Remove(action);

        public static GameEvent<T1, T2, T3> operator +(GameEvent<T1, T2, T3> gameEvent, IGameEventListener<T1, T2, T3> listener)
        {
            gameEvent.Subscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3> operator +(GameEvent<T1, T2, T3> gameEvent, Action<T1, T2, T3> action)
        {
            gameEvent.Subscribe(action);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3> operator -(GameEvent<T1, T2, T3> gameEvent, IGameEventListener<T1, T2, T3> listener)
        {
            gameEvent.Unsubscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3> operator -(GameEvent<T1, T2, T3> gameEvent, Action<T1, T2, T3> action)
        {
            gameEvent.Unsubscribe(action);
            return gameEvent;
        }
    }

    public abstract class GameEvent<T1, T2, T3, T4> : ScriptableObject, IGameEvent<T1, T2, T3, T4>
    {
        protected HashSet<IGameEventListener<T1, T2, T3, T4>> _gameEventListeners = new();
        protected HashSet<Action<T1, T2, T3, T4>> _actionListeners = new();

        public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            foreach (IGameEventListener<T1, T2, T3, T4> listener in _gameEventListeners)
                listener.RaiseEvent(arg1, arg2, arg3, arg4);

            foreach (Action<T1, T2, T3, T4> actionListener in _actionListeners)
                actionListener?.Invoke(arg1, arg2, arg3, arg4);
        }

        public virtual void Subscribe(IGameEventListener<T1, T2, T3, T4> listener) => _gameEventListeners.Add(listener);
        public virtual void Subscribe(Action<T1, T2, T3, T4> action) => _actionListeners.Add(action);

        public virtual void Unsubscribe(IGameEventListener<T1, T2, T3, T4> listener) => _gameEventListeners.Remove(listener);
        public virtual void Unsubscribe(Action<T1, T2, T3, T4> action) => _actionListeners.Remove(action);

        public static GameEvent<T1, T2, T3, T4> operator +(GameEvent<T1, T2, T3, T4> gameEvent, IGameEventListener<T1, T2, T3, T4> listener)
        {
            gameEvent.Subscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4> operator +(GameEvent<T1, T2, T3, T4> gameEvent, Action<T1, T2, T3, T4> action)
        {
            gameEvent.Subscribe(action);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4> operator -(GameEvent<T1, T2, T3, T4> gameEvent, IGameEventListener<T1, T2, T3, T4> listener)
        {
            gameEvent.Unsubscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4> operator -(GameEvent<T1, T2, T3, T4> gameEvent, Action<T1, T2, T3, T4> action)
        {
            gameEvent.Unsubscribe(action);
            return gameEvent;
        }
    }

    public abstract class GameEvent<T1, T2, T3, T4, T5> : ScriptableObject, IGameEvent<T1, T2, T3, T4, T5>
    {
        protected HashSet<IGameEventListener<T1, T2, T3, T4, T5>> _gameEventListeners = new();
        protected HashSet<Action<T1, T2, T3, T4, T5>> _actionListeners = new();

        public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            foreach (IGameEventListener<T1, T2, T3, T4, T5> listener in _gameEventListeners)
                listener.RaiseEvent(arg1, arg2, arg3, arg4, arg5);

            foreach (Action<T1, T2, T3, T4, T5> actionListener in _actionListeners)
                actionListener?.Invoke(arg1, arg2, arg3, arg4, arg5);
        }

        public virtual void Subscribe(IGameEventListener<T1, T2, T3, T4, T5> listener) => _gameEventListeners.Add(listener);
        public virtual void Subscribe(Action<T1, T2, T3, T4, T5> action) => _actionListeners.Add(action);

        public virtual void Unsubscribe(IGameEventListener<T1, T2, T3, T4, T5> listener) => _gameEventListeners.Remove(listener);
        public virtual void Unsubscribe(Action<T1, T2, T3, T4, T5> action) => _actionListeners.Remove(action);

        public static GameEvent<T1, T2, T3, T4, T5> operator +(GameEvent<T1, T2, T3, T4, T5> gameEvent, IGameEventListener<T1, T2, T3, T4, T5> listener)
        {
            gameEvent.Subscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4, T5> operator +(GameEvent<T1, T2, T3, T4, T5> gameEvent, Action<T1, T2, T3, T4, T5> action)
        {
            gameEvent.Subscribe(action);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4, T5> operator -(GameEvent<T1, T2, T3, T4, T5> gameEvent, IGameEventListener<T1, T2, T3, T4, T5> listener)
        {
            gameEvent.Unsubscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4, T5> operator -(GameEvent<T1, T2, T3, T4, T5> gameEvent, Action<T1, T2, T3, T4, T5> action)
        {
            gameEvent.Unsubscribe(action);
            return gameEvent;
        }
    }

    public abstract class GameEvent<T1, T2, T3, T4, T5, T6> : ScriptableObject, IGameEvent<T1, T2, T3, T4, T5, T6>
    {
        protected HashSet<IGameEventListener<T1, T2, T3, T4, T5, T6>> _gameEventListeners = new();
        protected HashSet<Action<T1, T2, T3, T4, T5, T6>> _actionListeners = new();

        public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            foreach (IGameEventListener<T1, T2, T3, T4, T5, T6> listener in _gameEventListeners)
                listener.RaiseEvent(arg1, arg2, arg3, arg4, arg5, arg6);

            foreach (Action<T1, T2, T3, T4, T5, T6> actionListener in _actionListeners)
                actionListener?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public virtual void Subscribe(IGameEventListener<T1, T2, T3, T4, T5, T6> listener) => _gameEventListeners.Add(listener);
        public virtual void Subscribe(Action<T1, T2, T3, T4, T5, T6> action) => _actionListeners.Add(action);

        public virtual void Unsubscribe(IGameEventListener<T1, T2, T3, T4, T5, T6> listener) => _gameEventListeners.Remove(listener);
        public virtual void Unsubscribe(Action<T1, T2, T3, T4, T5, T6> action) => _actionListeners.Remove(action);

        public static GameEvent<T1, T2, T3, T4, T5, T6> operator +(GameEvent<T1, T2, T3, T4, T5, T6> gameEvent, IGameEventListener<T1, T2, T3, T4, T5, T6> listener)
        {
            gameEvent.Subscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4, T5, T6> operator +(GameEvent<T1, T2, T3, T4, T5, T6> gameEvent, Action<T1, T2, T3, T4, T5, T6> action)
        {
            gameEvent.Subscribe(action);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4, T5, T6> operator -(GameEvent<T1, T2, T3, T4, T5, T6> gameEvent, IGameEventListener<T1, T2, T3, T4, T5, T6> listener)
        {
            gameEvent.Unsubscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4, T5, T6> operator -(GameEvent<T1, T2, T3, T4, T5, T6> gameEvent, Action<T1, T2, T3, T4, T5, T6> action)
        {
            gameEvent.Unsubscribe(action);
            return gameEvent;
        }
    }

    public abstract class GameEvent<T1, T2, T3, T4, T5, T6, T7> : ScriptableObject, IGameEvent<T1, T2, T3, T4, T5, T6, T7>
    {
        protected HashSet<IGameEventListener<T1, T2, T3, T4, T5, T6, T7>> _gameEventListeners = new();
        protected HashSet<Action<T1, T2, T3, T4, T5, T6, T7>> _actionListeners = new();

        public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            foreach (IGameEventListener<T1, T2, T3, T4, T5, T6, T7> listener in _gameEventListeners)
                listener.RaiseEvent(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

            foreach (Action<T1, T2, T3, T4, T5, T6, T7> actionListener in _actionListeners)
                actionListener?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public virtual void Subscribe(IGameEventListener<T1, T2, T3, T4, T5, T6, T7> listener) => _gameEventListeners.Add(listener);
        public virtual void Subscribe(Action<T1, T2, T3, T4, T5, T6, T7> action) => _actionListeners.Add(action);

        public virtual void Unsubscribe(IGameEventListener<T1, T2, T3, T4, T5, T6, T7> listener) => _gameEventListeners.Remove(listener);
        public virtual void Unsubscribe(Action<T1, T2, T3, T4, T5, T6, T7> action) => _actionListeners.Remove(action);

        public static GameEvent<T1, T2, T3, T4, T5, T6, T7> operator +(GameEvent<T1, T2, T3, T4, T5, T6, T7> gameEvent, IGameEventListener<T1, T2, T3, T4, T5, T6, T7> listener)
        {
            gameEvent.Subscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4, T5, T6, T7> operator +(GameEvent<T1, T2, T3, T4, T5, T6, T7> gameEvent, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            gameEvent.Subscribe(action);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4, T5, T6, T7> operator -(GameEvent<T1, T2, T3, T4, T5, T6, T7> gameEvent, IGameEventListener<T1, T2, T3, T4, T5, T6, T7> listener)
        {
            gameEvent.Unsubscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4, T5, T6, T7> operator -(GameEvent<T1, T2, T3, T4, T5, T6, T7> gameEvent, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            gameEvent.Unsubscribe(action);
            return gameEvent;
        }
    }

    public abstract class GameEvent<T1, T2, T3, T4, T5, T6, T7, T8> : ScriptableObject, IGameEvent<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        protected HashSet<IGameEventListener<T1, T2, T3, T4, T5, T6, T7, T8>> _gameEventListeners = new();
        protected HashSet<Action<T1, T2, T3, T4, T5, T6, T7, T8>> _actionListeners = new();

        public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            foreach (IGameEventListener<T1, T2, T3, T4, T5, T6, T7, T8> listener in _gameEventListeners)
                listener.RaiseEvent(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

            foreach (Action<T1, T2, T3, T4, T5, T6, T7, T8> actionListener in _actionListeners)
                actionListener?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public virtual void Subscribe(IGameEventListener<T1, T2, T3, T4, T5, T6, T7, T8> listener) => _gameEventListeners.Add(listener);
        public virtual void Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8> action) => _actionListeners.Add(action);

        public virtual void Unsubscribe(IGameEventListener<T1, T2, T3, T4, T5, T6, T7, T8> listener) => _gameEventListeners.Remove(listener);
        public virtual void Unsubscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8> action) => _actionListeners.Remove(action);

        public static GameEvent<T1, T2, T3, T4, T5, T6, T7, T8> operator +(GameEvent<T1, T2, T3, T4, T5, T6, T7, T8> gameEvent, IGameEventListener<T1, T2, T3, T4, T5, T6, T7, T8> listener)
        {
            gameEvent.Subscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4, T5, T6, T7, T8> operator +(GameEvent<T1, T2, T3, T4, T5, T6, T7, T8> gameEvent, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            gameEvent.Subscribe(action);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4, T5, T6, T7, T8> operator -(GameEvent<T1, T2, T3, T4, T5, T6, T7, T8> gameEvent, IGameEventListener<T1, T2, T3, T4, T5, T6, T7, T8> listener)
        {
            gameEvent.Unsubscribe(listener);
            return gameEvent;
        }

        public static GameEvent<T1, T2, T3, T4, T5, T6, T7, T8> operator -(GameEvent<T1, T2, T3, T4, T5, T6, T7, T8> gameEvent, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            gameEvent.Unsubscribe(action);
            return gameEvent;
        }
    }
}