using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float life = 3;
    public PlayerMovement pm;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "goktas") // e�er �arpt�g�m objen�n tah� goktas ise puan�m� bir artt�r ve iki objeyide yok et
        {
             pm.puan += 1;
             Destroy(collision.gameObject);
             Destroy(gameObject);
        }
        
    }

    private void Awake() // start ama daha �nce �al��an hali
    {
        Destroy(gameObject, 20); //gameobjeyi ve can�n� yok et gibi bisey san�r�m g�t�ne koyim anlmad�m buray� 
    }
    private void OnCollisionEnter2D(Collision2D collision) // gameobjem (mermi) ba�ka bir nesneye �arp�nca  yok et
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
