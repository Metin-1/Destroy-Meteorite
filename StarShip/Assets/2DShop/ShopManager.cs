using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
 
public class ShopManager : MonoBehaviour
{
    public bool oyund = false;
    public GameObject newobject;
    public GameObject Shop;
    public Image de�i�ecek;
    public Sprite Newsprite;

    public void spritedegis()
    {
        de�i�ecek.sprite= Newsprite;
    }
    public void de�is()
    {
        Debug.Log("kde�i�im");
        gameObject.SetActive(true);
    }
    public void shopg()
    {
        Shop.SetActive(true);

    }
    public void oyunudurdur()
    {
       

        if (!oyund)
        {
            Debug.Log("Oyun durduruluyor.");
            Time.timeScale = 0f;
            oyund = true;
        }
        else
        {
            Debug.Log("Oyun devam ediyor.");
            Time.timeScale = 1f;
            oyund = false;
            if (Shop.activeSelf)
            {
                Shop.SetActive(false);
            }
        }
    }
}