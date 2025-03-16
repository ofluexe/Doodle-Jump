using UnityEngine;

public class Karakter : MonoBehaviour
{
    [SerializeField] private float hiz, ziplamaGucu;
    private Rigidbody2D rb;
    private bool yerdeMi;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true; // ⬅ Dönmeyi tamamen engeller ✅
    }


    void Update()
    {
        rb.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * hiz, rb.linearVelocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && yerdeMi) Ziplat();
    }

    public void Ziplat() // ⬅ Burası `public` oldu, artık erişilebilir! ✅
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, ziplamaGucu);
        yerdeMi = false;
    }

    void OnCollisionEnter2D(Collision2D c) => yerdeMi = true;
}
