/*
Source File Name: RestartButtonBehaviour.cs
Author: Ramin Amiri
Date Last Modified: 2020-10-04 11:12AM

Program Description: This script gives functionality to the RestartButton.

Revision Histroy: Initial.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonBehaviour : MonoBehaviour
{
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
        Debug.Log("RestartButton Pressed");

        SceneManager.LoadScene("Play");
    }
}
