using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class q1Scriot : MonoBehaviour
{
    public GameObject option1Q1;
    public GameObject option2Q1;
    public GameObject option3Q1;
    public GameObject option4Q1;
    public GameObject q15050Button;
    //public GameObject q25050Button;
    //public GameObject q35050Button;
    //public GameObject q45050Button;
    public GameObject quitButton;
    public GameObject quitYesButtonq1;
    public GameObject quitNoButtonq1;
    public GameObject quitTextq1;

    // Start is called before the first frame update
    void Start()
    {
        option1Q1.SetActive(true);
        option4Q1.SetActive(true);
    }

    //correct answer chosen in q1
    public void question2MenuActive()
    {
        //setting q2 menu scene active after clicking correct button
        SceneManager.LoadScene("question2MenuScene");
    }
    //display wrong menu1 after incorrect button was selected or quit option was chosen
    public void wrongMenu1Active()
    {
        //setting wrong menu scene active after wrong option was selected or yes quit button selected
        SceneManager.LoadScene("wrongMenu1Scene");
    }
    //50/50 button clicked in q1
    public void q15050ButtonClicked()
    {
        //setting other 50/50 buttons in other panels off 
        //q25050Button.SetActive(false);
        //q35050Button.SetActive(false);
        //q45050Button.SetActive(false);

        //setting two buttons off after 50/50 button clicked
        option1Q1.SetActive(false);
        option4Q1.SetActive(false);
    }
    //setting quit yes and no button active and text
    public void quitButtonClicked()
    {
        quitYesButtonq1.SetActive(true);
        quitNoButtonq1.SetActive(true);
        quitTextq1.GetComponent<Text>().text = "Are you sure you want to quit";
    }
    //setting buttons to false if user doesn't want to quit
    public void quitNoButtonClicked()
    {
        quitYesButtonq1.SetActive(false);
        quitNoButtonq1.SetActive(false);
        quitTextq1.GetComponent<Text>().text = "";
    }
}
