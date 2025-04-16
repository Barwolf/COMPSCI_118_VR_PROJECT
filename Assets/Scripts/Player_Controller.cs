using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float moveSpeed;

    public float mouseSensitivity = 200f;
    public Camera playerCam;

    private float xRotation = 0;

    private bool started;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveSpeed = 10f;
        Cursor.lockState = CursorLockMode.Locked;
        started = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            started = true;
        } else
        {
            //ROTATION
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            //rotate up down
            xRotation -= mouseY;

            //so player can only look up/down 45 degrees
            xRotation = Mathf.Clamp(xRotation, -45f, 45f);
            playerCam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

            //rotate left right
            transform.Rotate(Vector3.up * mouseX);
        }


        //MOVEMENT
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(-Vector3.left * moveSpeed * Time.deltaTime);
        }

    }


}
