using System;

using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    Swipe_Direction direction;
    public event EventHandler<SwipeEventArgs> NewSwipe;
    void Update()
    {
        Swipe.Detection();
        if(Swipe.Detected == true)
        {            
            direction = Swipe.GetDirection();           
            OnSwipe(new SwipeEventArgs(direction));
        }
    }
    protected virtual void OnSwipe(SwipeEventArgs e)
    {
        EventHandler<SwipeEventArgs> temp = NewSwipe;
        if (temp != null)
            temp(this, e);
    }
}
