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
    private GameObject newcoin;
    public Transform holder;
    public Transform player;

    [Header("Scripts")]
    public CoinDetector coinDetector;
    
    public void TailFunc(){
        for (int i = 0; i < tailLength; i++)
        {
            newcoin = Instantiate(coinPreb,holder.transform.position +  new Vector3(0,+coinDetector.coin,0), holder.transform.localRotation);
            newcoin.transform.SetParent(holder);
        }
    }

    public void InstantiateRandomCoin(){
        Instantiate(coinPreb,RandomSpawn(),Quaternion.identity);
    }
    public Vector3 RandomSpawn(){
        yRange = Random.Range(-5.5f,5.5f);
        xRange = Random.Range(-13f,13f);
        coinPos = new Vector3(xRange,yRange,0);
        return coinPos;
    }
}
