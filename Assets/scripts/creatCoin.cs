using UnityEngine;
using UnityEngine.UIElements;

public class creatCoin : MonoBehaviour
{
    public GameObject coin;

    public Transform player;
    public float[] coinPostion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(creat_Train), 0, 1);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void creat_Train()
    {
        GameObject newTrain = Instantiate(coin);
        int index = Random.Range(0, 3);
        newTrain.transform.position = new Vector3(player.position.x - 40, player.position.y+1, coinPostion[index]);
    
    }

}
