using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class q2Script : MonoBehaviour
{
    public GameObject option1Q2;
    public GameObject option2Q2;
    public GameObject option3Q2;
    public GameObject option4Q2;
    public GameObject q25050Button;
    //public GameObject q25050Button;
    //public GameObject q35050Button;
    //public GameObject q45050Button;
    public GameObject quitButtonq2;
    public GameObject quitYesButtonq2;
    public GameObject quitNoButtonq2;

    // Start is called before the first frame update
    void Start()
    {
        option2Q2.SetActive(true);
        option4Q2.SetActive(true);
    }

    //correct answer chosen in q2
    public void question3MenuActive()
    {
        //setting q3 menu scene active after clicking correct button
        SceneManager.LoadScene("question3MenuScene");
    }
    //display wrong menu2 after incorrect button was selected or quit option was chosen
    public void wrongMenu2Active()
    {
        //setting wrong menu scene active after wrong option was selected or yes quit button selected
        SceneManager.LoadScene("wrongMenu2Scene");
    }
    //50/50 button clicked in q2
    public void q25050ButtonClicked()
    {
        //setting other 50/50 buttons in other panels off 
        //q25050Button.SetActive(false);
        //q35050Button.SetActive(false);
        //q45050Button.SetActive(false);

        //setting two buttons off after 50/50 button clicked
        option2Q2.SetActive(false);
        option4Q2.SetActive(false);
    }
    //setting quit yes and no button active and text
    public void quitButtonClicked()
    {
        quitYesButtonq2.SetActive(true);
        quitNoButtonq2.SetActive(true);
    }
    //setting buttons to false so they are no longer displayed if user doesn't want to quit
    public void quitNoButtonClicked()
    {
        quitYesButtonq2.SetActive(false);
        quitNoButtonq2.SetActive(false);
    }
}
