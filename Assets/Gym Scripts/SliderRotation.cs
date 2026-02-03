using UnityEngine;
using UnityEngine.UI;

public class SliderRotation : MonoBehaviour
{
    public Slider slider;
    public float rotationValue = 0;
    public float rotationMaxValue = 360;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      slider.maxValue = rotationMaxValue;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += slider.value;
        transform.eulerAngles = newRotation;
    }
}
