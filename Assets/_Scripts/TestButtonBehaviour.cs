/*
Source File Name: TestButtonBehaviour.cs
Author: Ramin Amiri
Date Last Modified: 2020-10-04 11:12AM

Program Description: This script gives functionality to the TestButton.

Revision Histroy: Initial.
*/

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestButtonBehaviour : MonoBehaviour
{
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //What happens when this button is pressed.
    public void OnPressedButton()
    {
        Debug.Log("StartButton Pressed");
        LivesLabel.rectTransform.anchoredPosition = new Vector2(370.0f, -83.0f);
        ScoreLabel.rectTransform.anchoredPosition = new Vector2(-353.0f, -83.0f);
    }
}
