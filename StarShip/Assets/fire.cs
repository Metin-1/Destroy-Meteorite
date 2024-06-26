using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{

    public GameObject BulletPrefab;
    public Transform ShootPosition;
    public float ShootSpeed;
    public PlayerMovement PM;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // klavyeden bosluk tusuna basýnca
        {
            var bullet = Instantiate(BulletPrefab, ShootPosition.position, ShootPosition.rotation); // BulletPrefabýný ShootPositionda ve Shoot rotasyonunda spawnla

            bullet.GetComponent<Rigidbody2D>().velocity = ShootPosition.up * ShootSpeed; //Spawnlanan OBjemin Rigidbodysine eriþ ve yukarý doðru haraeket etmesi için   (ShootPosition.up) yukarý doðru etki uygula

            bullet.GetComponent<bullet>().pm = PM; //bulletimin bulleti pmye esitle diye anladým 

        }
        
    }
}
