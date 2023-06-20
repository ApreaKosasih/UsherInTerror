using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBillboard : MonoBehaviour
{
    private void LateUpdate()
    {
        Vector3 cameraPosition = Camera.main.transform.position;
        cameraPosition.y = transform.position.y; // Agar NPC hanya melihat ke arah horizontal

        transform.LookAt(cameraPosition);
        transform.Rotate(0, 180, 0); // Putar 180 derajat agar tekstur menghadap kamera
    }
}