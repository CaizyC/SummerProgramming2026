using UnityEngine;

public class SpriteChanger : MonoBehaviour

{
    public SpriteRenderer theRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // declaor a variable for a custom color
    public Color customColor;
    void Start()
    {
        theRenderer = GetComponent<SpriteRenderer>();
        if (theRenderer != null)
        {   
        
        }
       // Access the color property of the sprite renderer component toand change value to green 
       theRenderer.color = customColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
