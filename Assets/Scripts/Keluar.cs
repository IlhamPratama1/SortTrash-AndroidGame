using UnityEngine;

public class Keluar : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Input Escape to quit game
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
