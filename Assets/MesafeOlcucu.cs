using UnityEngine;
using TMPro; // Yazý ekraný için bu þart

public class MesafeOlcucu : MonoBehaviour
{
    public Transform oyuncu;
    public TextMeshPro mesafeYazisi;
    private Renderer objeRengi;

    void Start()
    {
        // Kürenin rengini deðiþtirebilmek için renderer'ý alýyoruz
        objeRengi = GetComponent<Renderer>();
    }

    void Update()
    {
        // ÖDEVÝN KONUSU: Ýki nokta arasýndaki mesafeyi ölçüyoruz
        float mesafe = Vector3.Distance(transform.position, oyuncu.position);

        // Ekrana yazdýrýyoruz
        mesafeYazisi.text = "Mesafe: " + mesafe.ToString("F1") + "m";

        // Yakýnlaþýnca uyarý rengi (Kýrmýzý) yapýyoruz
        if (mesafe < 3f)
            objeRengi.material.color = Color.red;
        else
            objeRengi.material.color = Color.green;
    }
}
