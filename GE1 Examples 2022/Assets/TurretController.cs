using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class TurretController : MonoBehaviour
{
    public Transform player;
    public float sightRange;
    public bool playerInSightRange;
    public LayerMask whatIsPlayer;

    public Transform spawnPoint;
    public GameObject bulletPrefab;
    private float fireRate = 2f;


    public void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

        if (playerInSightRange)
        {
            LookAtPlayer();
            StartCoroutine(shoot());
        }
    }
    
    
    private void LookAtPlayer()
    {
        transform.LookAt(player);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);

    }

    IEnumerator shoot()
    {
        // yield return new WaitForSeconds(5);
        
        GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab);
        bullet.transform.rotation = transform.rotation;
        bullet.transform.position = spawnPoint.position;
        yield return new WaitForSeconds(10 / (float)fireRate);
        
        
    }
}
