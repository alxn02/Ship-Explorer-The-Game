using UnityEngine;

public class FuelCanister : MonoBehaviour
{
    public float fuelValue = 20f;

    void OnTriggerEnter(Collider other)
    {
        Ship ship = other.GetComponent<Ship>();
        if (ship != null)
        {
            ship.Refuel(fuelValue);
            Destroy(gameObject); 
        }
    }
}
