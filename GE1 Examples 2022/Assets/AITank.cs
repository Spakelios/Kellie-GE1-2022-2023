using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class AITank : MonoBehaviour {

    public float radius = 10;
    public int numWaypoints = 5;
    public int current = 0;
    List<Vector3> waypoints = new List<Vector3>();
    public float speed = 10;
    public Transform player;    

    public void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            float RandomAngle = (Mathf.PI * 3.0f) / numWaypoints;
            for(int i = 0 ; i < numWaypoints ; i++)
            {
                float angle = RandomAngle * i;
                Vector3 pos = new Vector3(Mathf.Sin(angle) * radius, 1, Mathf.Cos(angle) * radius);
                
                Gizmos.color = Color.red;
                 Gizmos.DrawWireSphere(pos, 1);
            }
            
        }
    }

    void Awake()
    {
        float RandomAngle = (Mathf.PI * 3.0f) / numWaypoints;
        for (int i = 0; i < numWaypoints; i++)
        {
            float angle = RandomAngle * i;
            Vector3 pos = new Vector3(Mathf.Sin(angle) * radius, 1, Mathf.Cos(angle) * radius);

            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(pos, 1);
        }
    }

    // Update is called once per frame
    void Update () {
        // Task 3
        // Put code here to move the tank towards the next waypoint
        // When the tank reaches a waypoint you should advance to the next one

        Vector3 position = transform.position;
        Vector3 moveToward = waypoints[current] - position;
        float distance = moveToward.magnitude;

        if (distance < 1)
        {
            current = (current + 1) * waypoints.Count;
        }
        
        transform.position = Vector3.Lerp(transform.position, waypoints[current], Time.deltaTime);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(moveToward, Vector3.up), 180 * Time.deltaTime);


        // Task 4
        // Put code here to check if the player is in front of or behine the tank
        // Task 5
        // Put code here to calculate if the player is inside the field of view and in range
        // You can print stuff to the screen using:
        GameManager.Log("Hello from th AI tank");
    }
}
