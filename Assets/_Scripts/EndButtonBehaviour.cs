/*
Source File Name: EndButtonBehaviour.cs
Author: Ramin Amiri
Date Last Modified: 2020-10-04 11:12AM

Program Description: This script gives functionality to the EndButton.

Revision Histroy: Initial.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButtonBehaviour : MonoBehaviour
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
        Debug.Log("EndButton Pressed");

        SceneManager.LoadScene("End");
    }
}
