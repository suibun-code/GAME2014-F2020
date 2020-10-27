using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float mHorizontalSpeed;
    public float mHorizontalBoundary;
    public float direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    private void Move()
    {
        transform.position += new Vector3(mHorizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
    }

    private void CheckBounds()
    {
        if (transform.position.x <= -mHorizontalBoundary)
            direction = 1.0f;

        if (transform.position.x >= mHorizontalBoundary)
            direction = -1.0f;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        direction *= -1;
    }
}
