using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float life = 3;
    public PlayerMovement pm;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "goktas") // eðer çarptýgým objenýn tahý goktas ise puanýmý bir arttýr ve iki objeyide yok et
        {
             pm.puan += 1;
             Destroy(collision.gameObject);
             Destroy(gameObject);
        }
        
    }

    private void Awake() // start ama daha önce çalþýan hali
    {
        Destroy(gameObject, 20); //gameobjeyi ve canýný yok et gibi bisey sanýrým götüne koyim anlmadým burayý 
    }
    private void OnCollisionEnter2D(Collision2D collision) // gameobjem (mermi) baþka bir nesneye çarpýnca  yok et
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
