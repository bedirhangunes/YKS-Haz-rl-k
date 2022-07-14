using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class butonisBersivan : MonoBehaviour
{
    public GameObject bersivAblue, bersivAGreen, bersivARed, bersivBblue, bersivBGreen, bersivBRed, bersivCblue, bersivCGreen, bersivCRed, bersivDblue, bersivDGreen, bersivDRed, bersivEblue, bersivEGreen, bersivERed;
    public GameObject answerA, answerB, answerC, answerD, answerE,scoreC,scoreF;
    public int scoreValue,scoreFalse;
    public void AnswerA()
    {
        if (questionGenerate.trueAnswer == "A")
        {
            bersivAGreen.SetActive(true);
            bersivAblue.SetActive(false);
            scoreValue += 1;
        }
        else
        {
            bersivARed.SetActive(true);
            bersivAblue.SetActive(false);
            scoreFalse += 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        answerE.GetComponent<Button>().enabled = false;
        StartCoroutine(nextQuest());
    }
    public void AnswerB()
    {
        if (questionGenerate.trueAnswer == "B")
        {
            bersivBGreen.SetActive(true);
            bersivBblue.SetActive(false);
            scoreValue += 1;
        }
        else
        {
            bersivBRed.SetActive(true);
            bersivBblue.SetActive(false);
            scoreFalse += 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        answerE.GetComponent<Button>().enabled = false;
        StartCoroutine(nextQuest());
    }
    public void AnswerC()
    {
        if (questionGenerate.trueAnswer == "C")
        {
            bersivCGreen.SetActive(true);
            bersivCblue.SetActive(false);
            scoreValue += 1;
        }
        else
        {
            bersivCRed.SetActive(true);
            bersivCblue.SetActive(false);
            scoreFalse += 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        answerE.GetComponent<Button>().enabled = false;
        StartCoroutine(nextQuest());
    }
    public void AnswerD()
    {
        if (questionGenerate.trueAnswer == "D")
        {
            bersivDGreen.SetActive(true);
            bersivDblue.SetActive(false);
            scoreValue += 1;
        }
        else
        {
            bersivDRed.SetActive(true);
            bersivDblue.SetActive(false);
            scoreFalse += 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        answerE.GetComponent<Button>().enabled = false;
        StartCoroutine(nextQuest());
    }
    public void AnswerE()
    {
        if (questionGenerate.trueAnswer == "E")
        {
            bersivEGreen.SetActive(true);
            bersivEblue.SetActive(false);
            scoreValue += 1;
        }
        else
        {
            bersivERed.SetActive(true);
            bersivEblue.SetActive(false);
            scoreFalse += 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        answerE.GetComponent<Button>().enabled = false;
        StartCoroutine(nextQuest());
    }
     void Update()
    {
        scoreC.GetComponent<Text>().text = "DOÐRU: " + scoreValue;
        scoreF.GetComponent<Text>().text = "YANLIÞ: " + scoreFalse;
    }
    IEnumerator nextQuest()
    {
        yield return new WaitForSeconds(2);
        bersivAblue.SetActive(true);
        bersivBblue.SetActive(true);
        bersivCblue.SetActive(true);
        bersivDblue.SetActive(true);
        bersivEblue.SetActive(true);
        bersivAGreen.SetActive(false);
        bersivBGreen.SetActive(false);
        bersivCGreen.SetActive(false);
        bersivDGreen.SetActive(false);
        bersivEGreen.SetActive(false);
        bersivARed.SetActive(false);
        bersivBRed.SetActive(false);
        bersivCRed.SetActive(false);
        bersivDRed.SetActive(false);
        bersivERed.SetActive(false);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;
        answerE.GetComponent<Button>().enabled = true;
        questionGenerate.displayingQuest = false;
    }

}
