using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class takeCoin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private int coinNum = 0;
    public TextMeshProUGUI pointText;
    public AudioSource coinSound;
     public GameObject winScene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coins")
        {
            coinNum++;
            pointText.text = "coins = " + coinNum;
            coinSound.Play();
            Destroy(other.gameObject);

        }

       // if (coinNum >= 100)
           // SceneManager.LoadScene("win");       

    }

}
