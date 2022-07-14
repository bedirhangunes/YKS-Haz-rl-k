using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answerButton : MonoBehaviour
{
    public GameObject answerA, answerB, answerC, answerD, answerE;
    public GameObject answerAblue, answerAGreen, answerARed, answerBblue, answerBgreen, answerBRed, answerCBlue,  answerCgreen, answerCRed, answerDblue,  answerDGreen, answerDRed, answerEblue, answerEGreen, answerERed, score,scoreF;
    public int scoreTruue,scoreFaalse;
    public void AnswerA()
    {
        if (questionOfMaths.trueAnswer == "A")
        {
            answerAGreen.SetActive(true);
            answerAblue.SetActive(false);
            scoreTruue += 1;
        }
        else
        {
            answerARed.SetActive(true);
            answerAblue.SetActive(false);
            scoreFaalse += 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        answerE.GetComponent<Button>().enabled = false;
        StartCoroutine(newQuestion());

    }
    public void AnswerB()
    {
        if (questionOfMaths.trueAnswer == "B")
        {
            answerBgreen.SetActive(true);
            answerBblue.SetActive(false);
            scoreTruue += 1;
        }
        else
        {
            answerBRed.SetActive(true);
            answerBblue.SetActive(false);
            scoreFaalse += 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        answerE.GetComponent<Button>().enabled = false;
        StartCoroutine(newQuestion());
    }
    public void AnswerC()
    {
        if (questionOfMaths.trueAnswer == "C")
        {
            answerCgreen.SetActive(true);
            answerCBlue.SetActive(false);
            scoreTruue += 1;
        }
        else
        {
            answerCRed.SetActive(true);
            answerCBlue.SetActive(false);
            scoreFaalse += 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        answerE.GetComponent<Button>().enabled = false;
        StartCoroutine(newQuestion());
    }
    public void AnswerD()
    {
        if (questionOfMaths.trueAnswer == "D")
        {
            answerDGreen.SetActive(true);
            answerDblue.SetActive(false);
            scoreTruue += 1;
        }
        else
        {
            answerDRed.SetActive(true);
            answerDblue.SetActive(false);
            scoreFaalse += 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        answerE.GetComponent<Button>().enabled = false;
        StartCoroutine(newQuestion());
    }
    public void AnswerE()
    {
        if (questionOfMaths.trueAnswer == "E")
        {
            answerEGreen.SetActive(true);
            answerEblue.SetActive(false);
            scoreTruue += 1;
        }
        else
        {
            answerERed.SetActive(true);
            answerEblue.SetActive(false);
            scoreFaalse += 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        answerE.GetComponent<Button>().enabled = false;
        StartCoroutine(newQuestion());
    }
   
    void Update()
    {
        score.GetComponent<Text>().text = "DOÐRU: "+scoreTruue;
        scoreF.GetComponent<Text>().text = "YANLIÞ: " + scoreFaalse;
    }
    IEnumerator newQuestion()
    {
        yield return new WaitForSeconds(2);
        answerAblue.SetActive(true);
        answerBblue.SetActive(true);
        answerCBlue.SetActive(true);
        answerDblue.SetActive(true);
        answerEblue.SetActive(true);
        answerAGreen.SetActive(false);
        answerBgreen.SetActive(false);
        answerCgreen.SetActive(false);
        answerDGreen.SetActive(false);
        answerEGreen.SetActive(false);
        answerARed.SetActive(false);
        answerBRed.SetActive(false);
        answerCRed.SetActive(false);
        answerDRed.SetActive(false);
        answerERed.SetActive(false);
        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;
        answerE.GetComponent<Button>().enabled = true;
        questionOfMaths.displayQue = false;
    }
}
