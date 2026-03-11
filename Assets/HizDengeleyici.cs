using UnityEngine;

public class HizDengeleyici : MonoBehaviour
{
    public bool normalizeEt = false; // Mavi kürede bunu iþaretleyeceðiz
    public float hiz = 5f;

    void Update()
    {
        // Hem ileri (Z:1) hem saða (X:1) gitmek istiyoruz (Çapraz hareket)
        Vector3 yon = new Vector3(1, 0, 1);

        if (normalizeEt)
        {
            // ÖDEVÝN KONUSU: Normalize, yönü bozmadan vektörün uzunluðunu 1 birime sabitler.
            // Böylece çapraz giderken hýzýmýz hala 'hiz' deðiþkenine eþit olur.
            transform.Translate(yon.normalized * hiz * Time.deltaTime);
        }
        else
        {
            // Normalize edilmezse: Hipotenüs kuralý gereði hýzýmýz 1.41 katýna çýkar!
            // Yani bu küre daha hýzlý koþar.
            transform.Translate(yon * hiz * Time.deltaTime);
        }
    }
}