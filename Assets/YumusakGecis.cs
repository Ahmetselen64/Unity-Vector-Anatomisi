using UnityEngine;

public class YumusakGecis : MonoBehaviour
{
    public Transform nokta1; // Baþlangýç (Nokta1 boþ objesi)
    public Transform nokta2; // Bitiþ (Nokta2 boþ objesi)
    public float hiz = 1f;

    void Update()
    {
        // ÖDEVÝN KONUSU: Lerp için 0 ile 1 arasýnda deðiþen bir 't' deðeri gerekir.
        // PingPong fonksiyonu zamaný kullanarak 0'dan 1'e, sonra 1'den 0'a sürekli bir döngü kurar.
        float zaman = Mathf.PingPong(Time.time * hiz, 1f);

        // Vector3.Lerp(A, B, t) -> A ve B noktalarý arasýnda t oranýnda yumuþak geçiþ yapar.
        // t = 0 ise A'dadýr, t = 1 ise B'dedir, t = 0.5 ise tam ortadadýr.
        transform.position = Vector3.Lerp(nokta1.position, nokta2.position, zaman);
    }
}