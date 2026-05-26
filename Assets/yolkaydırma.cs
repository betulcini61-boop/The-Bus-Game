using UnityEngine;

public class InfiniteRoad : MonoBehaviour
{
    public float speed = 2f;          // Kayma hýzý
    private float width;              // Yol görselinin geniþliði
    private Vector3 startPos;         // Ýlk konumu

    void Start()
    {
        startPos = transform.position;
        width = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        // Yolu sola kaydýr
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Yol tamamen sola çýkýnca saða taþý
        if (transform.position.x <= startPos.x - width)
        {
            transform.position = new Vector3(transform.position.x + 2 * width, transform.position.y, transform.position.z);
        }
    }
}
