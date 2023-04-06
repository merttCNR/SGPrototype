using UnityEngine;

public class TailManager : MonoBehaviour
{
    [Header("Int")]
    int tailLength = 1;
    
    [Header("GameObjects")]
    public GameObject coinPreb;
    public GameObject collector;
    public Transform holder;

    public void TailFunc(){
        for (int i = 0; i < tailLength; i++)
        {
            Destroy(coinPreb);
            GameObject newcoin = Instantiate(coinPreb,collector.transform.position + Vector3.up,Quaternion.identity);
            newcoin.transform.SetParent(holder);
            collector.transform.position += Vector3.down;
        }
    }
}
