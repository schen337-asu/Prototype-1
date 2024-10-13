using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 3.0f;
    private float liftSpeed = 5.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {
        // We get the player input -- can be updated in the "Edit" menu under "Project Settings" -> "Input Manager"
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // Movet the vehicle left and right based on horizontal input
        transform.Rotate(Vector3.right, Time.deltaTime * liftSpeed * forwardInput);

        // note - tint on the editor for playmode can be updated in the "Edit" menu under "Preferences" -> "Colors"
    }
}
