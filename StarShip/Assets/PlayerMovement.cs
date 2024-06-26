using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2;
    public float speed = 5;
    public float ha;
    public float va;
    public RectTransform pos;
    public float puan;
    public TextMeshProUGUI puanText;
    public GameOverScreen GameOverScreen;
     
    public bool death;
     
    public void GameOver()
    {
        GameOverScreen.setup(puan); //�ld�g�mde puan�m� g�nder
        death = true; 
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "goktas") //Collision = �arpt���m obje nin tag� gokstas ise hem beni hemde gokstas� yok et
        {
            GameOver();

            Destroy(collision.gameObject);
            gameObject.SetActive(false);
        }

    }

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        puanText.text = "Skor= " + puan.ToString(); //puan textimdeki skora eri� string t�r�ne �evir

        ha = Input.GetAxis("Horizontal");// yatay dikey giri� tuslar�
        va = Input.GetAxis("Vertical");
        
      
       rb2.MovePosition(transform.position + (transform.right * ha + transform.up * va) * speed); //   hareket ettigim y�n� h�z�mla �arp�p yerimi g�nceller
        
         if (pos.anchoredPosition.x > 300)
            pos.anchoredPosition = new Vector2(299,pos.anchoredPosition.y);

         if (pos.anchoredPosition.x < -300)
            pos.anchoredPosition = new Vector2(-299, pos.anchoredPosition.y);  //karakterimin haraket edebilecegi yerlerin s�n�r�

        if (pos.anchoredPosition.y > 400)
            pos.anchoredPosition = new Vector2(pos.anchoredPosition.x,399);

        if (pos.anchoredPosition.y < 100)
            pos.anchoredPosition = new Vector2(pos.anchoredPosition.x,101);




    }
}
