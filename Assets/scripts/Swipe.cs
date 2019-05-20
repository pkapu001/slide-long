using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    public bool tap, swipeUp, swipeDown, swipeLeft, swipeRight;
    public Vector2 startTouch, swipeDelta;

    // Update is called once per frame
    void Update()
    {
        tap = swipeDown = swipeLeft = swipeRight = swipeUp;
        if (Input.touches.Length > 0)
        {
            tap = true;
           startTouch = Input.touches[0].position ;
        }else if(Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
        {
            reset();
        }
        #region touchinput


        #endregion


        #region Standalone input


        if (Input.GetMouseButtonDown(0))
        {
            tap = true;
            startTouch = Input.mousePosition;

        }else if (Input.GetMouseButtonUp(0))
        {
            reset();
        }
        #endregion
    }

    private void reset()
    {
        startTouch = swipeDelta = Vector2.zero;
    }

}