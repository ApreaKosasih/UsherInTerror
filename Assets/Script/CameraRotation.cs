using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed = 5f; // Kecepatan rotasi kamera
    public float maxRotationAngle = 45f; // Batas rotasi maksimum dalam derajat

    private float rotationY = 0f;

    private void Update()
    {
        // Mendapatkan input mouse horizontal
        float mouseX = Input.GetAxis("Mouse X");

        // Menghitung rotasi baru pada sumbu Y
        rotationY += mouseX * rotationSpeed;

        // Mengkunci rotasi dalam batasan maksimum
        rotationY = Mathf.Clamp(rotationY, 0f, maxRotationAngle);

        // Menentukan rotasi pada sumbu Y
        Quaternion newRotation = Quaternion.Euler(0f, rotationY, 0f);

        // Mengatur rotasi kamera
        transform.localRotation = newRotation;
    }
}
