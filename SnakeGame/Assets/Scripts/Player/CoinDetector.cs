using UnityEngine;

public class CoinDetector : MonoBehaviour
{
   public TailManager tailManager;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Coin")){
            Debug.Log("çalışıyor!!!");
            Destroy(other.gameObject);
            tailManager.TailFunc();
            tailManager.InstantiateCoin();
        }
    } 
}
