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
        PlayerPrefs.SetFloat("BestScore", score); //float t�r�ndeki Bestscore de�i�kenimi score verisi olarak kaydetmeye yarar
        BestScoreText.text = "BestScore : " + PlayerPrefs.GetFloat("BestScore"); // bestscoru bestcore textine yazd�r
    }
    
    public void restart() {
        SceneManager.LoadScene(0);// sahneler aras� ge�i� yapmaca (�ld�g�mde restara bas�p ba�tan baslat�r)
    }
    public void setup(float score)
    {
        gameObject.SetActive(true); // oyun sonu best scoru g�sterir 
        PuanText.text = "PO�NTS: " + score.ToString(); // puan textime puan�m� yazd�r
        if(score > PlayerPrefs.GetFloat("BestScore")) // eger scorum best scordan b�y�kse
        {
            Bscore(score);// yeni bestcorum scor
        }
        else
        {
            BestScoreText.text = "BestScore : " + PlayerPrefs.GetFloat("BestScore");// best scordan devam
        }

    }


}
