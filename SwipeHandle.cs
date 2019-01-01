using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeHandle : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       this.GetComponent<SwipeDetection>().NewSwipe += SwipeHandle_NewSwipe;
    }

    private void SwipeHandle_NewSwipe(object sender, SwipeEventArgs e)
    {
        Debug.Log(e.GetDirection.ToString());
    }
}
