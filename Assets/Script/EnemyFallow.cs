using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFallow : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    public float stopRange = 3f;
    public float activeRange = 10f;



    private Rigidbody enemyRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (player != null && enemyRigidbody != null)
        {

            Vector3 direction = player.position - transform.position;
            direction.Normalize();

            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            if (distanceToPlayer <= activeRange)
            {

                if (distanceToPlayer > stopRange)
                {

                    enemyRigidbody.MovePosition(transform.position + direction * moveSpeed * Time.deltaTime);
                      Quaternion lookRotation = Quaternion.LookRotation(direction);
                    enemyRigidbody.MoveRotation(lookRotation);


                }


            }


        }


    }
}
