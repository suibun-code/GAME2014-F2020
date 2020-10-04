using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class SafeAreaFitter : MonoBehaviour
{    
    Rect LastSafeArea = new Rect(0, 0, 0, 0);
    RectTransform Panel;

    // Start is called before the first frame update
    void Start()
    {
        Panel = GetComponent<RectTransform> ();
        Refresh ();
    }

    // Update is called once per frame
    void Update()
    {
        switch (Screen.orientation)
        {
            case ScreenOrientation.Portrait:
                Refresh();
                break;
            case ScreenOrientation.LandscapeLeft:
                Refresh();
                break;
            case ScreenOrientation.LandscapeRight:
                Refresh();
                break;
            case ScreenOrientation.Unknown:
                Refresh();
                break;
            default:
                Refresh();
                break;
        }
    }

        void Refresh()
    {
        Rect safeArea = GetSafeArea();

        if (safeArea != LastSafeArea)
        {
            ApplySafeArea(safeArea);
        }
    }

    public Rect GetSafeArea()
    {
        return Screen.safeArea;
    }

    public void ApplySafeArea(Rect r)
    {
        LastSafeArea = r;

            // Convert safe area rectangle from absolute pixels to normalised anchor coordinates
            Vector2 anchorMin = r.position;
            Vector2 anchorMax = r.position + r.size;
            anchorMin.x /= Screen.width;
            anchorMin.y /= Screen.height;
            anchorMax.x /= Screen.width;
            anchorMax.y /= Screen.height;
            Panel.anchorMin = anchorMin;
            Panel.anchorMax = anchorMax;
    }
}
