using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Rigidbody leftHandle;
    public Rigidbody rightHandle;
    public Rigidbody ball;
    public float handleSpeed = 0.8f;
    public float forceMultiplier = 100f;
    public float maxSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ball.AddForce(Vector3.forward * forceMultiplier);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            leftHandle.AddForce(Vector3.up * handleSpeed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rightHandle.AddForce(Vector3.up * handleSpeed);
        }

        leftHandle.velocity = Vector3.ClampMagnitude(leftHandle.velocity, maxSpeed);
        rightHandle.velocity = Vector3.ClampMagnitude(rightHandle.velocity, maxSpeed);
    }
}
