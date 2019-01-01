using UnityEngine;


static public class Swipe
{
    static Vector3 _firstPos;
    static Vector3 _lastPos;

    static bool detected = false;
    static bool ended = true;
    public static bool Detected { get {return detected; } }
    public static void Detection()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began &&  ended)
            {
                _firstPos =
                Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                              
            }
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                _lastPos =
                Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                detected = true;
                ended = false;
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                ended = true;
            }
        }
    }
    public static Direction GetDirection()
    {
        if (detected == false)
            return Direction.ZERO;
        //if (_firstPos == null || _lastPos == null)
        //    throw new NullReferenceException("first use a Swipe.Detection() Method");
        detected = false;
        
        Vector3 result = new Vector3(_lastPos.x - _firstPos.x, _lastPos.y - _firstPos.y, 0);
        float angle = Vector3.Angle(result, new Vector3(10, 0, 0));
        if (result.y < 0)
            angle = 360 - angle;
        if (angle < 45  && angle > 0 ||  angle > 315 && angle < 360)
            return Direction.RIGHT;
        if (angle < 135 && angle > 45)
            return Direction.UP;
        if (angle < 225 && angle > 135)
            return Direction.LEFT;
        if (angle < 315 && angle > 225)
            return Direction.DOWN;

        return Direction.ZERO;
    }

}
