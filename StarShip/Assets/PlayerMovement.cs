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
        GameOverScreen.setup(puan); //öldügümde puanýmý gönder
        death = true; 
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "goktas") //Collision = Çarptýðým obje nin tagý gokstas ise hem beni hemde gokstasý yok et
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
        puanText.text = "Skor= " + puan.ToString(); //puan textimdeki skora eriþ string türüne çevir

        ha = Input.GetAxis("Horizontal");// yatay dikey giriþ tuslarý
        va = Input.GetAxis("Vertical");
        
      
       rb2.MovePosition(transform.position + (transform.right * ha + transform.up * va) * speed); //   hareket ettigim yönü hýzýmla çarpýp yerimi günceller
        
         if (pos.anchoredPosition.x > 300)
            pos.anchoredPosition = new Vector2(299,pos.anchoredPosition.y);

         if (pos.anchoredPosition.x < -300)
            pos.anchoredPosition = new Vector2(-299, pos.anchoredPosition.y);  //karakterimin haraket edebilecegi yerlerin sýnýrý

        if (pos.anchoredPosition.y > 400)
            pos.anchoredPosition = new Vector2(pos.anchoredPosition.x,399);

        if (pos.anchoredPosition.y < 100)
            pos.anchoredPosition = new Vector2(pos.anchoredPosition.x,101);




    }
}
