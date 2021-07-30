using UnityEngine;

public class SampahMuncul : MonoBehaviour
{
    public float jeda = 0.8f;
    float timer;
    public GameObject[] obyekSampah;

    void Update()
    {
        // Start timer spawn
        timer += Time.deltaTime;

        // If timer is up
        if (timer > jeda)
        {
            // Set random trash type and instantiate
            int random = Random.Range(0, obyekSampah.Length);
            Instantiate(obyekSampah[random], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
