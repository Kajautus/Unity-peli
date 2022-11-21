using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
<<<<<<< Updated upstream
    void Start()
=======
    public LayerMask whatIsPlayer, whatIsGround;

    public AudioSource enemyShoot;

    //Patrolling
    public Transform[] waypoints;
    int WaypointIndex;
    Vector3 target;
    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public GameObject projectile;

    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    private void Awake()
    {
        Player = GameObject.Find("FPS_Player").transform;
        enemy = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    void UpdateDestination()
    {
        target = waypoints[WaypointIndex].position;
        enemy.SetDestination(target);
    }
    void IterateWaypointIndex()
>>>>>>> Stashed changes
    {
        
<<<<<<< Updated upstream
    }
=======
        if (!alreadyAttacked)
        {
            Rigidbody rb = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            enemyShoot.Play();
            rb.AddForce(transform.forward * 50f, ForceMode.Impulse);
            rb.AddForce(transform.up * 4f, ForceMode.Impulse);


            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }
    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    

>>>>>>> Stashed changes

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
    }
}
