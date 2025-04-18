using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // https://www.youtube.com/watch?v=aN11LnlF89I
        // if escape key is pressed, make the main menu active
        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.SetActive(true);
        }
    }
}
