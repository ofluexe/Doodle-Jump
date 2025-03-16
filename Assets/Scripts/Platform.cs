using UnityEngine;

public class Platform : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("Karakter"))
        {
            if(c.relativeVelocity.y <= 0f)
            {
                c.gameObject.GetComponent<Karakter>()?.Ziplat(); // ⬅ Artık `Ziplat()` metoduna erişebilir! ✅
            }
            
        }
            
    }
}
