using UnityEngine;

public class BölümOluşturucu : MonoBehaviour
{
    public GameObject platformPrefab;
    [SerializeField] int platformSayisi = 200;
    void Start()
    {
        LevelUret();
    }

    void LevelUret()
    {
        Vector2 PlatformVektor = new Vector2();
        for(int i = 0; i < platformSayisi; i++)
        {
            GameObject tempPlatform = Instantiate(platformPrefab);
            PlatformVektor.x += Random.Range(-6.3f, 6.3f);
            PlatformVektor.y += Random.Range(3.9f, 4.5f);
            tempPlatform.transform.position = PlatformVektor;
           
        }
    }
}
