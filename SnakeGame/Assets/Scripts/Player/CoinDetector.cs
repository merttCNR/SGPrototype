using UnityEngine;

public class CoinDetector : MonoBehaviour
{
   public TailManager tailManager;
   public int coin = 0;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Coin")){
            Destroy(other.gameObject);
            tailManager.TailFunc();
            tailManager.InstantiateRandomCoin();
            coin++;
        }
    } 
}
