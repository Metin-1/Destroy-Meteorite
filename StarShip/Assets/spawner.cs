using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
    
{
     
    public int spawner1;
    public GameObject goktas�;
    public List<RectTransform> spawnpost = new List<RectTransform>();
    public GameObject parent;
     public PlayerMovement player;
    public IEnumerator goktas�spawner()
    {
        if(player.death == true)
        {
            yield break;// e�er �l�rsem dengeyi k�r yani spawnlanma durur oyun biter meto ahmeti g�tten siker
        }
        //if(ShopManager.isPause == true) bekle
        spawner1 = Random.Range(0, spawnpost.Count);// spawnpost listesinin elaman say�s� kadar rastgele birini se� 
        GameObject klonlananobje  = Instantiate(goktas�, parent.transform); // Klonlanama kodu amk

        klonlananobje.GetComponent<RectTransform>().anchoredPosition = spawnpost[spawner1].anchoredPosition;// klonlanan objeyi hedef spawnlanma yerinden spawnla
       
        yield return new  WaitForSeconds(1);

        StartCoroutine(goktas�spawner()); // en basa donup donguyu tekrar et 
    }
    void Start()
    {
        StartCoroutine(goktas�spawner()); // oyun baslad�g�nda dong�y� cal�st�r�r
        
    }

     
    void Update()
    {
        
    }
}
