using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int totalCoins;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<BirdController>() != null)
        {
            totalCoins++;

            Debug.Log("Coins: " + totalCoins);

            Destroy(gameObject);
        }
    }
}