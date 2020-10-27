/*
Source File Name: FrogScript.cs
Author: Ramin Amiri
Date Last Modified: 2020-10-27 12:53PM

Program Description: This script gives functionality the the player.

Revision Histroy: Initial.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrogScript : MonoBehaviour
{
    public Vector3 frogPos;
    public int lives = 30;
    public int points = 0;
    public AudioSource hitSound;
    public AudioSource pickupSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Move(Vector3 newPos)
    {
        frogPos = newPos;
        transform.position = frogPos;
        CheckBounds();
    }

    public void CheckBounds()
    {
        if (transform.position.x <= -2f)
        {
            transform.position = new Vector3(-2.132999f, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= 2f)
        {
            transform.position = new Vector3(2.133001f, transform.position.y, transform.position.z);
        }
        if (transform.position.y <= -5.25f)
        {
            transform.position = new Vector3(transform.position.x, -4.75f, transform.position.z);
        }
        if (transform.position.y >= 4.55f)
        {
            SceneManager.LoadScene("End");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "pickup")
        {
            points++;
            pickupSound.Play();
            Destroy(other.gameObject);
        }
        else
        {
            lives--;
            hitSound.Play();
        }

        if (lives <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}
