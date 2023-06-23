using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInterraction : MonoBehaviour
{
    public Transform carSeat;
    private Renderer npcRenderer;
    private Renderer npcRenderer_inside;
    private UnityEngine.AI.NavMeshAgent itemNavMeshAgent;

    public GameObject objNpcInside;

    public Material npc_form_normal;

    private void Start()

    {
        npcRenderer = GetComponent<Renderer>();
        npcRenderer_inside = objNpcInside.GetComponent<Renderer>();
        itemNavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        
        npcRenderer_inside.material = null;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Aksi yang ingin dilakukan saat pemain memasuki trigger NPC
            Debug.Log("NPC triggered by player!");

            // Contoh: Tampilkan pesan dialog atau memulai interaksi dengan NPC
            // Panggil fungsi atau metode untuk memulai dialog atau aksi yang diinginkan.

            // Disable the item's renderer
            npcRenderer.enabled = false;
            itemNavMeshAgent.enabled = false;

            // Parent the item to the player's hand
            // transform.SetParent(carSeat);

            // Adjust the item's position and rotation as needed
            // transform.localPosition = Vector3.zero;
            // transform.localRotation = Quaternion.identity;
            
            // npcRenderer_inside.material.SetTexture("_MainTex", texture);

            npcRenderer_inside.material = npc_form_normal;

            // Add the item to the player's inventory or perform any other logic

            // Optionally, enable the renderer of the player's hand-held item if applicable

            // Disable the item's collider to prevent multiple pickups
            GetComponent<Collider>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Aksi yang ingin dilakukan saat pemain keluar dari trigger NPC
            Debug.Log("Player exited NPC trigger!");

            // Contoh: Hentikan dialog atau interaksi dengan NPC
            // Panggil fungsi atau metode untuk menghentikan dialog atau aksi yang sedang berlangsung.
        }
    }
}
