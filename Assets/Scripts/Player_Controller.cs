using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float rotSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
        }
    }
}
