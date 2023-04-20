using System;

namespace Hybel.GameEvents
{
    public interface IGameEvent
    {
        void Invoke();
        void Subscribe(Action action);
        void Subscribe(IGameEventListener listener);
        void Unsubscribe(Action action);
        void Unsubscribe(IGameEventListener listener);
    }

    public interface IGameEvent<T>
    {
        void Invoke(T arg);
        void Subscribe(Action<T> action);
        void Subscribe(IGameEventListener<T> listener);
        void Unsubscribe(Action<T> action);
        void Unsubscribe(IGameEventListener<T> listener);
    }

    public interface IGameEvent<T1, T2>
    {
        void Invoke(T1 arg1, T2 arg2);
        void Subscribe(Action<T1, T2> action);
        void Subscribe(IGameEventListener<T1, T2> listener);
        void Unsubscribe(Action<T1, T2> action);
        void Unsubscribe(IGameEventListener<T1, T2> listener);
    }

    public interface IGameEvent<T1, T2, T3>
    {
        void Invoke(T1 arg1, T2 arg2, T3 arg3);
        void Subscribe(Action<T1, T2, T3> action);
        void Subscribe(IGameEventListener<T1, T2, T3> listener);
        void Unsubscribe(Action<T1, T2, T3> action);
        void Unsubscribe(IGameEventListener<T1, T2, T3> listener);
    }

    public interface IGameEvent<T1, T2, T3, T4>
    {
        void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
        void Subscribe(Action<T1, T2, T3, T4> action);
        void Subscribe(IGameEventListener<T1, T2, T3, T4> listener);
        void Unsubscribe(Action<T1, T2, T3, T4> action);
        void Unsubscribe(IGameEventListener<T1, T2, T3, T4> listener);
    }

    public interface IGameEvent<T1, T2, T3, T4, T5>
    {
        void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
        void Subscribe(Action<T1, T2, T3, T4, T5> action);
        void Subscribe(IGameEventListener<T1, T2, T3, T4, T5> listener);
        void Unsubscribe(Action<T1, T2, T3, T4, T5> action);
        void Unsubscribe(IGameEventListener<T1, T2, T3, T4, T5> listener);
    }

    public interface IGameEvent<T1, T2, T3, T4, T5, T6>
    {
        void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
        void Subscribe(Action<T1, T2, T3, T4, T5, T6> action);
        void Subscribe(IGameEventListener<T1, T2, T3, T4, T5, T6> listener);
        void Unsubscribe(Action<T1, T2, T3, T4, T5, T6> action);
        void Unsubscribe(IGameEventListener<T1, T2, T3, T4, T5, T6> listener);
    }

    public interface IGameEvent<T1, T2, T3, T4, T5, T6, T7>
    {
        void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
        void Subscribe(Action<T1, T2, T3, T4, T5, T6, T7> action);
        void Subscribe(IGameEventListener<T1, T2, T3, T4, T5, T6, T7> listener);
        void Unsubscribe(Action<T1, T2, T3, T4, T5, T6, T7> action);
        void Unsubscribe(IGameEventListener<T1, T2, T3, T4, T5, T6, T7> listener);
    }

    public interface IGameEvent<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
        void Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8> action);
        void Subscribe(IGameEventListener<T1, T2, T3, T4, T5, T6, T7, T8> listener);
        void Unsubscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8> action);
        void Unsubscribe(IGameEventListener<T1, T2, T3, T4, T5, T6, T7, T8> listener);
    }
}
