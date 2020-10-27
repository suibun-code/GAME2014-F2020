/*
Source File Name: PlayerControls.cs
Author: Ramin Amiri
Date Last Modified: 2020-10-27 12:53PM

Program Description: This script updates the position of the player with the relevant button is clicked.

Revision Histroy: Initial.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public GameObject target;
    [SerializeField]
    Direction direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        switch (direction)
        {
            case Direction.UP:
                target.GetComponent<FrogScript>().Move(new Vector3(target.transform.position.x, target.transform.position.y + 0.5f, target.transform.position.z));
                Debug.Log("CLICKED UP");
                break;

            case Direction.DOWN:
                target.GetComponent<FrogScript>().Move(new Vector3(target.transform.position.x, target.transform.position.y - 0.5f, target.transform.position.z));
                Debug.Log("CLICKED DOWN");
                break;

            case Direction.LEFT:
                target.GetComponent<FrogScript>().Move(new Vector3(target.transform.position.x - 0.474f, target.transform.position.y, target.transform.position.z));
                Debug.Log("CLICKED LEFT");
                break;

            case Direction.RIGHT:
                target.GetComponent<FrogScript>().Move(new Vector3(target.transform.position.x + 0.474f, target.transform.position.y, target.transform.position.z));
                Debug.Log("CLICKED RIGHT");
                break;

            default:
                break;
        }
    }
}
