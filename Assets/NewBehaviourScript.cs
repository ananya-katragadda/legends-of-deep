using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float turnSpeed = 10f;
    public float movementSpeed = 5f;  // Add a public variable for movement speed

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Apply movement speed to translation
        float moveDistance = movementSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * verticalInput * moveDistance);

        // Apply turn speed to rotation
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);
    }

}