using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Overlay : MonoBehaviour
{
    
    public SpriteRenderer spriteRenderer;
    public GameObject Info;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

       
        
            Info.SetActive(spriteRenderer.bounds.Contains(mousePos));
        
    }
}
