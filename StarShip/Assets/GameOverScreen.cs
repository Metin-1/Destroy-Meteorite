using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public Text PuanText;
    public Text BestScoreText;
    
    public void Bscore(float score)
    {
        PlayerPrefs.SetFloat("BestScore", score); //float türündeki Bestscore deðiþkenimi score verisi olarak kaydetmeye yarar
        BestScoreText.text = "BestScore : " + PlayerPrefs.GetFloat("BestScore"); // bestscoru bestcore textine yazdýr
    }
    
    public void restart() {
        SceneManager.LoadScene(0);// sahneler arasý geçiþ yapmaca (öldügümde restara basýp baþtan baslatýr)
    }
    public void setup(float score)
    {
        gameObject.SetActive(true); // oyun sonu best scoru gösterir 
        PuanText.text = "POÝNTS: " + score.ToString(); // puan textime puanýmý yazdýr
        if(score > PlayerPrefs.GetFloat("BestScore")) // eger scorum best scordan büyükse
        {
            Bscore(score);// yeni bestcorum scor
        }
        else
        {
            BestScoreText.text = "BestScore : " + PlayerPrefs.GetFloat("BestScore");// best scordan devam
        }

    }


}
