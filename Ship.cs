using UnityEngine;

public class Ship : MonoBehaviour
{
    public float speed = 10f;         
    public int collisionCount = 0;    
    public int score = 0;             
    public float fuel = 100f;         

    void Update()
    {
        
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(moveX, 0f, 0f, Space.World);
    }

   
    void OnTriggerEnter(Collider other)
    {
        collisionCount++;
        Debug.Log("Collided with " + other.gameObject.name + " Total collisions: " + collisionCount);
    }

    
    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }

    
    public void Refuel(float amount)
    {
        fuel += amount;
        Debug.Log("Fuel: " + fuel);
    }
}
