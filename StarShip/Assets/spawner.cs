using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
    
{
     
    public int spawner1;
    public GameObject goktasý;
    public List<RectTransform> spawnpost = new List<RectTransform>();
    public GameObject parent;
     public PlayerMovement player;
    public IEnumerator goktasýspawner()
    {
        if(player.death == true)
        {
            yield break;// eðer ölürsem dengeyi kýr yani spawnlanma durur oyun biter meto ahmeti götten siker
        }
        //if(ShopManager.isPause == true) bekle
        spawner1 = Random.Range(0, spawnpost.Count);// spawnpost listesinin elaman sayýsý kadar rastgele birini seç 
        GameObject klonlananobje  = Instantiate(goktasý, parent.transform); // Klonlanama kodu amk

        klonlananobje.GetComponent<RectTransform>().anchoredPosition = spawnpost[spawner1].anchoredPosition;// klonlanan objeyi hedef spawnlanma yerinden spawnla
       
        yield return new  WaitForSeconds(1);

        StartCoroutine(goktasýspawner()); // en basa donup donguyu tekrar et 
    }
    void Start()
    {
        StartCoroutine(goktasýspawner()); // oyun basladýgýnda dongüyü calýstýrýr
        
    }

     
    void Update()
    {
        
    }
}
