using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questionDisplay : MonoBehaviour
{
    public GameObject question, answerA, answerB, answerC, answerD, answerE;
    public static string yeniSoru, newA, newB, newC, newD, newE;
    public static bool updatePirs = false;
 
    void Update()
    {
        if (updatePirs == false)
        {
            updatePirs = true;
            StartCoroutine(pushTextScreen());
        }
        
    }
    IEnumerator pushTextScreen()
    {
        yield return new WaitForSeconds(0.50f);
        question.GetComponent<Text>().text = yeniSoru;
        answerA.GetComponent<Text>().text = newA;
        answerB.GetComponent<Text>().text = newB;
        answerC.GetComponent<Text>().text = newC;
        answerD.GetComponent<Text>().text = newD;
        answerE.GetComponent<Text>().text = newE;

    }
}
