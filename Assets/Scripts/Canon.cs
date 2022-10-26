using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public Transform bulletSpawnPoint;
   
        public GameObject bulletPrefab;
    public float speed;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {   
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().isKinematic = false;
            bullet.GetComponent<Rigidbody>().AddForce(transform.right * speed);
        }
    }
}