/*
Source File Name: SafeAreaFitter.cs
Author: Ramin Amiri
Date Last Modified: 2020-10-04 11:12AM

Program Description: This script makes sure all elements which need to stay within the safe area of the device,
stay within that area and are positioned accordingly.

Revision Histroy: Initial.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeAreaFitter : MonoBehaviour
{
    Rect TheSafeArea = new Rect(0, 0, 0, 0); //The last safe area that is not updated.
    RectTransform ObjectTransform; //The RectTransform representing the component from the appropriate GameObject.

    // Start is called before the first frame update
    void Start()
    {
        //Get the RectTransform component from the appropriate GameObject.
        ObjectTransform = GetComponent<RectTransform>();
        SetSafeArea();
    }

    // Update is called once per frame. 
    void Update()
    {
        //If the screen orientation is changed, refresh. This is done to not refresh the safe area on non-occurences.
        switch (Screen.orientation)
        {
            case ScreenOrientation.Portrait:
                SetSafeArea();
                break;
            case ScreenOrientation.LandscapeLeft:
                SetSafeArea();
                break;
            case ScreenOrientation.LandscapeRight:
                SetSafeArea();
                break;
            case ScreenOrientation.Unknown:
                break;
            default:
                break;
        }
    }

    void SetSafeArea()
    {
        //Assign a new safe area.
        Rect rect = Screen.safeArea;

        //If the safe area ia new, re-assign it.
        if (rect != TheSafeArea)
        {
        //Assign the new safe area as the last safe area; updating it.
        TheSafeArea = rect;

        //Convert safe area rectangle from absolute pixels to normalised anchor coordinates.
        Vector2 anchorMin = rect.position;
        Vector2 anchorMax = rect.position + rect.size;

        anchorMin.x /= Screen.width;
        anchorMin.y /= Screen.height;

        anchorMax.x /= Screen.width;
        anchorMax.y /= Screen.height;
        
        ObjectTransform.anchorMin = anchorMin;
        ObjectTransform.anchorMax = anchorMax;
        }
    }
}
