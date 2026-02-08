using UnityEngine;

public class moveCoin : MonoBehaviour
{

    public float speed = 1f;
    Transform coinTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinTransform = GetComponent<Transform>();
        Invoke(nameof(myDistroy), 20);
    }

    // Update is called once per frame
    void Update()
    {
        coinTransform.Translate(speed * Time.deltaTime, 0, 0);
    }

    public void myDistroy()
    {
        Destroy(this.gameObject);
    }
}
