using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInterraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Aksi yang ingin dilakukan saat pemain memasuki trigger NPC
            Debug.Log("NPC triggered by player!");

            // Contoh: Tampilkan pesan dialog atau memulai interaksi dengan NPC
            // Panggil fungsi atau metode untuk memulai dialog atau aksi yang diinginkan.
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
