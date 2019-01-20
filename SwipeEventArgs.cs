using System;
public class SwipeEventArgs : EventArgs
{
    private Swipe_Direction _dir;
    public SwipeEventArgs(Swipe_Direction newDirection)
    {
        _dir = newDirection;
    }
    public Swipe_Direction  GetDirection{ get{ return _dir; }}
}
