using System;
public class SwipeEventArgs : EventArgs
{
    private Direction _dir;
    public SwipeEventArgs(Direction newDirection)
    {
        _dir = newDirection;
    }
    public Direction  GetDirection{ get{ return _dir; }}
}
