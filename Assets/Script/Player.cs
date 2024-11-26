using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float mouseSensitivity = 2.0f;

    private float verticalRotation = 0;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        RotationInputM();
        WASD();
    }
    void RotationInputM()
    {
        float HORIZONTALrOTATION = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, HORIZONTALrOTATION, 0);
        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
    }
    void WASD()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical) * movementSpeed * Time.deltaTime;
        movement = transform.TransformDirection(movement);
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

    }


}
