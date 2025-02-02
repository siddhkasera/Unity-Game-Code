// using UnityEngine;

// public class AutomaticMove : MonoBehaviour
// {
//     [SerializeField]
//     private Transform[] waypoints;

//     [SerializeField]
//     private float moveSpeed = 2f;

//     private int waypointIndex = 0;
//     private int direction = 1; // 1 for forward, -1 for backward

//     private void Start()
//     {
//         if (waypoints.Length == 0)
//         {
//             Debug.LogError("No waypoints assigned!");
//             return;
//         }
        
//         // Start at the first waypoint
//         transform.position = waypoints[waypointIndex].transform.position;
//     }

//     private void Update()
//     {
//         Move();
//     }

//     private void Move()
//     {
//         if (waypoints.Length == 0) return;

//         // Move the object toward the current waypoint
//         transform.position = Vector2.MoveTowards(
//             transform.position,
//             waypoints[waypointIndex].position,
//             moveSpeed * Time.deltaTime
//         );

//         // Check if we reached the waypoint
//         if (Vector2.Distance(transform.position, waypoints[waypointIndex].position) < 0.1f)
//         {
//             // Update index based on direction
//             waypointIndex += direction;

//             // Reverse direction if at the last or first waypoint
//             if (waypointIndex == waypoints.Length - 1 || waypointIndex == 0)
//             {
//                 direction *= -1; // Reverse direction
//             }
//         }
//     }
// }
//

//

using UnityEngine;

public class AutomaticMove : MonoBehaviour
{
    [SerializeField] private Transform[] forwardWaypoints;  // First path (going forward)
    [SerializeField] private Transform[] backwardWaypoints; // Second path (returning)
    [SerializeField] private float moveSpeed = 2f;

    private Transform[] currentWaypoints; 
    private int waypointIndex = 0;
    private bool isReturning = false; 
    private bool isMoving = true; // Controls movement

    private void Start()
    {
        if (forwardWaypoints.Length == 0 || backwardWaypoints.Length == 0)
        {
            Debug.LogError("Waypoints are missing! Assign them in the Inspector.");
            return;
        }

        // Start with the forward path
        currentWaypoints = forwardWaypoints;
        transform.position = currentWaypoints[waypointIndex].position;
    }

    private void Update()
    {
        if (isMoving)
        {
            Move();
        }
    }

    private void Move()
    {
        if (currentWaypoints.Length == 0) return;

        // Move towards the current waypoint
        transform.position = Vector3.MoveTowards(
            transform.position,
            currentWaypoints[waypointIndex].position,
            moveSpeed * Time.deltaTime
        );

        // Check if the object reached the waypoint
        if (Vector3.Distance(transform.position, currentWaypoints[waypointIndex].position) < 0.1f)
        {
            waypointIndex++;

            // Check if we've reached the end of the current path
            if (waypointIndex >= currentWaypoints.Length)
            {
                if (!isReturning)
                {
                    // Switch to return path
                    isReturning = true;
                    currentWaypoints = backwardWaypoints;
                    waypointIndex = 0; // Reset for backward path
                }
                else
                {
                    // Stop moving completely
                    isMoving = false; // Prevents Update() from calling Move()
                }
            }
        }
    }
}
