using UnityEngine;

public class Ball : MonoBehaviour
{
    public float v;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += v + Time.deltaTime;
        transform.eulerAngles = newRotation;
    }
}
