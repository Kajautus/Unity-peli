using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    public LayerMask whatIsPlayer, whatIsGround;

    public float health;
    public ParticleSystem particles;
    public AudioClip destroySound;
    public AudioSource damageSound;

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
    {
        WaypointIndex++;
        if (WaypointIndex >= waypoints.Length)
        {
            WaypointIndex = 0;
        }
    }
   

    private void ChasePlayer ()
    {
        enemy.SetDestination(Player.position);
    }

    private void AttackPlayer()
    {
        //Make sure enemy doesn't move
        enemy.SetDestination(transform.position);

        transform.LookAt(Player);
        
        if (!alreadyAttacked)
        {
            Rigidbody rb = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            
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

    public void TakeDamage (int damage)
    {
        damageSound.Play();
        health -= damage;

        if (health <= 0) Invoke(nameof(DestroyEnemy), 5f);
    }
    private void DestroyEnemy()
    {
        AudioSource.PlayClipAtPoint(destroySound, transform.position, 2f);
        Instantiate(particles, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 5)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
        //Check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange) UpdateDestination();
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        if (playerInSightRange && playerInAttackRange) AttackPlayer();
       


    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
}
