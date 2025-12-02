using UnityEngine;

public class Star : MonoBehaviour
{
    public int scoreValue = 10;

    void OnTriggerEnter(Collider other)
    {
        Ship ship = other.GetComponent<Ship>();
        if (ship != null)
        {
            ship.AddScore(scoreValue);
            Destroy(gameObject); 
        }
    }
}
