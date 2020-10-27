/*
Source File Name: ScoreLabel.cs
Author: Ramin Amiri
Date Last Modified: 2020-10-27 12:53PM

Program Description: This script updates the score text with relevant information.

Revision Histroy: Initial.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreLabel : MonoBehaviour
{
    public GameObject player;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Points: " + player.GetComponent<FrogScript>().points.ToString();
    }
}
