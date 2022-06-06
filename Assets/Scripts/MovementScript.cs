using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Transform leftHandle;
    public Transform rightHandle;
    public float handleSpeed = 0.8f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            leftHandle.Translate(Vector3.up * Time.deltaTime * handleSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            leftHandle.Translate(Vector3.down * Time.deltaTime * handleSpeed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rightHandle.Translate(Vector3.up * Time.deltaTime * handleSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rightHandle.Translate(Vector3.down * Time.deltaTime * handleSpeed);
        }
    }
}
