using UnityEngine;

public class creatTrain : MonoBehaviour
{
    public GameObject train;
    public float[] trainPostion = { -3.8f, 0.69f, 5.14f };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(creat_Train), 0, 3);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void creat_Train()
    {
        GameObject newTrain = Instantiate(train);
        int index = Random.Range(0, 3);
        newTrain.transform.position = new Vector3(0, 0, trainPostion[index]);
    
    }

}
