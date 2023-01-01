using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float projectileForce = 10;
    public float fireRate = 0.5f;

    bool canFire = true;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && canFire)
        {
            FireProjectile();
            canFire = false;
            StartCoroutine(FireDelay());
        }
    }

    IEnumerator FireDelay()
    {
        yield return new WaitForSeconds(fireRate);
        canFire = true;
    }

    void FireProjectile()
    {
        Vector3 startPosition = firePoint.position + firePoint.up * 1;
        Quaternion startRotation = firePoint.rotation;
        GameObject projectile = Instantiate(projectilePrefab, startPosition, startRotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * projectileForce, ForceMode2D.Impulse);
    }
}
