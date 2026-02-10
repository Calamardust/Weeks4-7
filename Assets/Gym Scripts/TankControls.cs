using UnityEngine;
using UnityEngine.InputSystem;

public class TankControls : MonoBehaviour
{
    public float Speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Keyboard.current.dKey.isPressed == true)
        {
            Vector2 newPosition = transform.position;
            newPosition.x += Speed * Time.deltaTime;
            transform.position = newPosition;
        
        }
        if (Keyboard.current.aKey.isPressed)
        {

            Vector2 newPosition = transform.position;
            newPosition.x -= Speed * Time.deltaTime;
            transform.position = newPosition;
        }
    }
}
