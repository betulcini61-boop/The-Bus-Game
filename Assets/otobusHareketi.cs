using UnityEngine;

public class OtobusKontrolGelismis : MonoBehaviour
{
    [Header("Hareket Ayarlarý")]
    public float normalHiz = 5f;
    public float boostHizi = 8f;
    public float yumusakHareket = 5f;

    [Header("Sýnýrlar")]
    public float ustSinir = 4.5f;
    public float altSinir = -4.5f;

    private Rigidbody2D rb;
    private float mevcutHiz;
    private Vector2 hedefHiz;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.gravityScale = 0;
            rb.freezeRotation = true;
        }

        mevcutHiz = normalHiz;
    }

    void Update()
    {
        // Shift tuþu ile hýz artýþý
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            mevcutHiz = boostHizi;
        }
        else
        {
            mevcutHiz = normalHiz;
        }

        // Giriþleri al
        float yEkseni = Input.GetAxis("Vertical");

        // Hedef hýzý belirle
        hedefHiz = new Vector2(0f, yEkseni * mevcutHiz);
    }

    void FixedUpdate()
    {
        if (rb != null)
        {
            // Yumuþak hareket için Lineer Interpolation
            rb.velocity = Vector2.Lerp(rb.velocity, hedefHiz, yumusakHareket * Time.fixedDeltaTime);

            // Ekran sýnýrlarýný kontrol et
            SinirlariKontrolEt();
        }
    }

    void SinirlariKontrolEt()
    {
        Vector2 pozisyon = transform.position;

        // Y pozisyonunu sýnýrla
        pozisyon.y = Mathf.Clamp(pozisyon.y, altSinir, ustSinir);

        transform.position = pozisyon;
    }
}
