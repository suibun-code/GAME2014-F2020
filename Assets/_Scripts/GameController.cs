using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (Input.deviceOrientation)
        {
            case DeviceOrientation.Portrait:
                Debug.Log("Portrait");
                break;
            case DeviceOrientation.LandscapeLeft:
                Debug.Log("LandscapeLeft");
                break;
            case DeviceOrientation.LandscapeRight:
                Debug.Log("LandscapeRight");
                break;
            case DeviceOrientation.Unknown:
                Debug.Log("Unknown");
                break;
            default:
                Debug.Log("Some other orientation");
                break;
        }
    }
}
