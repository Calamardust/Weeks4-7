using UnityEngine;
using UnityEngine.UI;


public class Ball : MonoBehaviour
{
    //Slider that changes over time to represent "distance"
    public Slider distSlider;

    // Vectors for the start and end positions of the ball
    public Vector2 start;
    public Vector2 end;

    // Time value for lerp
    public float t = 0;

    // Vectors for the inital and final scale of the ball
    public Vector2 initialScale = new Vector2 (1.5f, 1.5f);
    public Vector2 finalScale = new Vector2(0.1f, 0.1f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Destroys the football object after 1 second
        Destroy(gameObject, 1.0f);
    }

    // Update is called once per fram
    void Update()
    {
        t += Time.deltaTime;

        if (t > 1)
        {
            t = 0;
        }
        //Linear interpolation between points for the ball
        transform.position = Vector2.Lerp(start, end, t);

        //Linear interpolation for the change in scale of the ball
        transform.localScale = Vector2.Lerp(initialScale, finalScale, t);

        //Changes the value of the slider to the t value (changes over time)
        distSlider.value = t;

        //continous rotation
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += 0.8f + Time.deltaTime;
        transform.eulerAngles = newRotation;

        
    }

}
