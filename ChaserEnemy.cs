using UnityEngine;

public class ChaserEnemy : Enemy
{
    public Transform target;

    public override void Move()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                target.position,
                2f * Time.deltaTime
            );
        }
    }

    void Update()
    {
        Move();
    }
}
