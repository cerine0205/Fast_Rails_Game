using UnityEngine;

public class trainMovment : MonoBehaviour
{

    public float speed = 1f;
    Transform trainTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trainTransform = GetComponent<Transform>();
        Invoke(nameof(myDistroy), 20);
    }

    // Update is called once per frame
    void Update()
    {
        trainTransform.Translate(0, 0, speed * Time.deltaTime);
    }

    public void myDistroy()
    {
        Destroy(this.gameObject);
    }
}
