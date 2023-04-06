using UnityEngine;

public class TailManager : MonoBehaviour
{
    [Header("Int&Float")]
    float xRange;
    float yRange;
    int tailLength = 1;

    [Header("Vector3")]
    Vector3 coinPos;

    [Header("GameObjects")]
    public GameObject coinPreb;
    public GameObject collector;
    public Transform holder;

    public void TailFunc(){
        for (int i = 0; i < tailLength; i++)
        {
            GameObject newcoin = Instantiate(coinPreb,collector.transform.position + Vector3.up,Quaternion.identity);
            newcoin.transform.SetParent(holder);
            collector.transform.position += Vector3.down;
        }
    }
    public void InstantiateCoin(){
        Instantiate(coinPreb,RandomSpawn(),Quaternion.identity);
    }
    public Vector3 RandomSpawn(){
        yRange = Random.Range(-5.5f,5.5f);
        xRange = Random.Range(-13f,13f);
        coinPos = new Vector3(xRange,yRange,0);
        return coinPos;
    }
}
