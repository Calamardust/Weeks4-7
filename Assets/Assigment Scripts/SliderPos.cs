
using UnityEngine;

public class SliderPos : MonoBehaviour
{
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Fuction to change the X Pos with the slider
    public void EndPos(float newX)
    {
        //Changes X position of "End" based on slider value
        Vector2 currentPosition = transform.position;
        currentPosition.x = newX;
        transform.position = currentPosition;

    }
}
