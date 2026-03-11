using UnityEngine;

public class TrambolinKodu : MonoBehaviour
{
    public float ziplatmaGucu = 10f;

    // Bu fonksiyon, tramboline bir þey çarptýðý anda çalýþýr
    void OnCollisionEnter(Collision temas)
    {
        // Çarpan objenin fizik motorunu (Rigidbody) yakalýyoruz
        Rigidbody rb = temas.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            // ÖDEVÝN KONUSU: (0, 1, 0) yazmak yerine Vector3.up kullanýyoruz.
            // Impulse modu, anlýk bir patlama/zýplama etkisi yaratýr.
            rb.AddForce(Vector3.up * ziplatmaGucu, ForceMode.Impulse);
        }
    }
}