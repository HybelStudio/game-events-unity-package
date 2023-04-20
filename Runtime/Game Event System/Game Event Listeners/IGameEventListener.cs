namespace Hybel.GameEvents
{
    public interface IGameEventListener
    {
        void RaiseEvent();
    }

    public interface IGameEventListener<T>
    {
        void RaiseEvent(T arg);
    }

    public interface IGameEventListener<T1, T2>
    {
        void RaiseEvent(T1 arg1, T2 arg2);
    }

    public interface IGameEventListener<T1, T2, T3>
    {
        void RaiseEvent(T1 arg1, T2 arg2, T3 arg3);
    }

    public interface IGameEventListener<T1, T2, T3, T4>
    {
        void RaiseEvent(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
    }

    public interface IGameEventListener<T1, T2, T3, T4, T5>
    {
        void RaiseEvent(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
    }

    public interface IGameEventListener<T1, T2, T3, T4, T5, T6>
    {
        void RaiseEvent(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
    }

    public interface IGameEventListener<T1, T2, T3, T4, T5, T6, T7>
    {
        void RaiseEvent(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
    }

    public interface IGameEventListener<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        void RaiseEvent(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
    }
}