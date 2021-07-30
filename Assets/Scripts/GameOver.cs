using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    float timer = 0;

    // Update is called once per frame
    void Update()
    {
        // Start timer after game over
        timer += Time.deltaTime;
        if (timer > 2)
        {
            Data.score = 0;
            // Move to Gameplay Scene
            SceneManager.LoadScene("Gameplay");
        }
    }
}
