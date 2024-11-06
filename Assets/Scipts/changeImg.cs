using UnityEngine;

public class changeImg : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Load the texture from the Resources folder without the path and extension
        Texture2D newTexture = Resources.Load<Texture2D>("20241106-113837_screenshot");
      
        // Check if the texture was successfully loaded
        if (newTexture != null)
        {
            // Get the Renderer component attached to the quad
            Renderer renderer = GetComponent<Renderer>();

            // Assign the new texture to the material
            renderer.material.mainTexture = newTexture;

        
        }
        else
        {
            Debug.LogError("Failed to load texture at path: IMG_3527");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
