using UnityEngine;
using UnityEngine.SceneManagement;

public class BatasAkhirSampah : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // If object is out of bound
        Destroy(collision.gameObject);
    }
}