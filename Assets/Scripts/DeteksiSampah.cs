using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeteksiSampah : MonoBehaviour
{
    public string nameTag;
    public AudioClip audioBenar;
    public AudioClip audioSalah;
    private AudioSource MediaPlayerBenar;
    private AudioSource MediaPlayerSalah;
    public Text textScore;

    // Use this for initialization
    void Start()
    {
        // Find audio component
        MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
        MediaPlayerBenar.clip = audioBenar;    
        MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
        MediaPlayerSalah.clip = audioSalah;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // If collision tag is same to trash type
        if (collision.tag.Equals(nameTag))
        {
            // Add score
            Data.score += 10;
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerBenar.Play();
        }

        // If tag not same
        else
        {
            // Decrese Score
            Data.score -= 15;
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerSalah.Play();

            // If score is 0 or under
            if(Data.score <= 0)
            {
                // Go to GameOver scene
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
