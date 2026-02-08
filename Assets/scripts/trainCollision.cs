using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class trainCollision : MonoBehaviour
{

    public AudioSource crashSound;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trains"))
        {

            crashSound.Play();
            SceneManager.LoadScene("lose");
          




        }
    }
}
