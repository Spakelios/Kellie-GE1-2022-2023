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

    public float rotationSpeed;
    public Transform spawnPoint;
    private float fireRate = 1;
    public GameObject bulletPrefab;


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
        Debug.Log("I see u");
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);

    }
    

    IEnumerator shoot()
    {
        yield return new WaitForSeconds(0.5f);

        Instantiate(bulletPrefab, spawnPoint.position, transform.rotation);

        yield return new WaitForSeconds(0.5f);
    }
}
