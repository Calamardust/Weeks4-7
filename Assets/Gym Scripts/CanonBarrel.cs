using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class CanonBarrel : MonoBehaviour
{
    public float minZ;
    public float maxZ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        Vector2 direction = (Vector2)transform.position - mousePos;

        //Mathf.Atan2(direction.y, direction.x);

        float angle = Mathf.Atan2(direction.y, direction.x);

        if(angle < minZ)
        {
            angle = minZ;
        }
        else if(angle > maxZ)
        {
            angle = maxZ;
        }

        transform.eulerAngles = new Vector3(0, 0, angle * Mathf.Rad2Deg);

        //transform.right = direction;

        //Vector3 rot = transform.eulerAngles;



        //rot.z = Mathf.Clamp(rot.z, minZ, maxZ);

        //transform.eulerAngles = rot;
    }
   

}