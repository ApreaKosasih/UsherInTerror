using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCChangeTexture : MonoBehaviour
{
    private Material material;
    public Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        material = renderer.material;
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collision is with the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Bisakah?");


            // Change the shader of the material
            material.shader = Shader.Find("npc1_setan");
        }
    }

    
}
