using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Spawn : MonoBehaviour
{
    // Prefab to spawn
    public GameObject SpawnFootball;

    // Ui text to keep track of how many times the kick button was pressed
    public TextMeshProUGUI counterText;

    // starts at 0
    int kicksCount = 0;

    //Slider that changes on time
    public Slider sceneSlider;

    // final end position
    public Transform endObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBall()
    {  
        // Instantiate/spawns the ball
        GameObject ballInstantiate = Instantiate(SpawnFootball, transform.position, transform.rotation);

        // sums 1 everytime the button is pressed
        kicksCount++;

        //changes the counter on the UI
        counterText.text = "kicks " + kicksCount.ToString();

        //Get Component from "Ball" start end and t
        Ball moveBall = ballInstantiate.GetComponent<Ball>();

   
            // Start and End positions for the prefab
            moveBall.start = transform.position;   
            moveBall.end = endObject.position;

            //Makes the distance slider change with the time of tha last spawned prefab
            moveBall.distSlider = sceneSlider;

            // Restart t value
            moveBall.t = 0; 
        }
 
}
