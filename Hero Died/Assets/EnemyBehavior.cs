using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    public Transform patrolRoute;
    public List<Transform> locations;
    private int locationIndex = 0;
    // 3
    private NavMeshAgent agent;
    public Transform player;
    private int _lives = 3;
    public int EnemyLives
    {
        // 2
        get { return _lives; }
        // 3
        private set
        {
            _lives = value;
            // 4
            if (_lives <= 0)
            {
                Destroy(this.gameObject);
                Debug.Log("Enemy down.");
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player").transform;
        InitializePatrolRoute();
        MoveToNextPatrolLocation();

    }

    // Update is called once per frame
    void Update()
    {
        // 1
        if (agent.remainingDistance < 0.2f && !agent.pathPending)
        {
            // 2
            MoveToNextPatrolLocation();
        }

    }
    void InitializePatrolRoute()
    {
        // 5
        foreach (Transform child in patrolRoute)
        {
            // 6
            locations.Add(child);
        }
    }
    void MoveToNextPatrolLocation()
    {
        if (locations.Count == 0)
            return;
        // 6
        agent.destination = locations[locationIndex].position;
        locationIndex = (locationIndex + 1) % locations.Count;
    }

    void OnCollisionEnter(Collision collision)
    {
        // 5
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            // 6
            EnemyLives -= 1;
            Debug.Log("Critical hit!");
        }
    }


    void OnTriggerEnter(Collider other)
    {
        //2
        if (other.name == "Player")
        {
            agent.destination = player.position;

            Debug.Log("Player detected - attack!");
        }
    }
    // 3
    void OnTriggerExit(Collider other)
    {
        // 4
        if (other.name == "Player")
        {
            Debug.Log("Player out of range, resume patrol");
        }
    }

}
