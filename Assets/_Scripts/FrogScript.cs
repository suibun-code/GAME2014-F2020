using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrogScript : MonoBehaviour
{
    public Vector3 frogPos;
    public int lives = 3;

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
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        lives--;

        if (lives <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}
