using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Countdown : MonoBehaviour
{
    Text timerText;
    float currentTime = GameVariables.currentTime;
    GameObject canvasObj;
    Transform child;
    void Start()
    {
        canvasObj = GameObject.Find("Canvas");
        child = canvasObj.transform.Find("lblTime");
        timerText = child.GetComponent<Text>();
        //StartCoroutine(TimerTick());
    }

    
    private void Update()
    {
        // delaTime => différence de temps entre chaque image 
        GameVariables.currentTime -= Time.deltaTime;
        timerText.text = "Time :" + GameVariables.currentTime.ToString("00");
        if (GameVariables.currentTime <= 0)
        {
            SceneManager.LoadScene("Scene1Exterieur");
        }
    }
    /*
    IEnumerator TimerTick()
    {
        //currentTime = GameVariables.currentTime;
        while (GameVariables.currentTime > 0)
        {
            //attendre 1 seconde
            yield return new WaitForSeconds(1.0f);
            GameVariables.currentTime--;
            timerText.text = "Time :" + GameVariables.currentTime.ToString("00"); 
        }
        // game over and restart
        SceneManager.LoadScene("Scene1Exterieur");
    }*/
}