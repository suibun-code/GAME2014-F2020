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
                target.GetComponent<FrogScript>().Move(new Vector3(target.transform.position.x - 0.5f, target.transform.position.y, target.transform.position.z));
                Debug.Log("CLICKED LEFT");
                break;

            case Direction.RIGHT:
                target.GetComponent<FrogScript>().Move(new Vector3(target.transform.position.x + 0.5f, target.transform.position.y, target.transform.position.z));
                Debug.Log("CLICKED RIGHT");
                break;

            default:
                break;
        }
    }
}
