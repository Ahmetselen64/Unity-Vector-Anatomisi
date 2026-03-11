using UnityEngine;

public class OyuncuHareketi : MonoBehaviour
{
    // Hýzý Unity ekranýndan (Inspector) kolayca deðiþtirebilmen için public yaptýk
    public float hiz = 5f;

    void Update()
    {
        // WASD veya Yön Tuþlarýndan gelen komutlarý alýyoruz (-1 ile 1 arasý deðer verir)
        // W/S tuþlarý dikey, A/D tuþlarý yatay ekseni kontrol eder.
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        // Y eksenini (yukarý/aþaðý) 0 yapýyoruz çünkü uçmak istemiyoruz, sadece yerde yürüyeceðiz.
        Vector3 hareketVektoru = new Vector3(yatay, 0f, dikey);

        // transform.Translate objeyi hareket ettirir. 
        // Time.deltaTime bilgisayarýn kasma/hýzlanma durumundan baðýmsýz, sabit hýzda yürümeyi saðlar.
        transform.Translate(hareketVektoru * hiz * Time.deltaTime);
    }
}