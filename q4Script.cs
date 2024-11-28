using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class q4Script : MonoBehaviour
{
    public GameObject option1Q4;
    public GameObject option2Q4;
    public GameObject option3Q4;
    public GameObject option4Q4;
    public GameObject q45050Button;
    //public GameObject q25050Button;
    //public GameObject q35050Button;
    //public GameObject q45050Button;
    public GameObject quitButtonq4;
    public GameObject quitYesButtonq4;
    public GameObject quitNoButtonq4;

    // Start is called before the first frame update
    void Start()
    {
        option3Q4.SetActive(true);
        option4Q4.SetActive(true);
    }

    //correct answer chosen in q4
    public void winnerMenuActive()
    {
        //setting winner menu scene active after clicking correct button
        SceneManager.LoadScene("winnerMenuScene");
    }
    //display wrong menu4 after incorrect button was selected or quit option was chosen
    public void wrongMenu4Active()
    {
        //setting wrong menu scene active after wrong option was selected or yes quit button selected
        SceneManager.LoadScene("wrongMenu4Scene");
    }
    //50/50 button clicked in q4
    public void q45050ButtonClicked()
    {
        //setting other 50/50 buttons in other panels off 
        //q25050Button.SetActive(false);
        //q35050Button.SetActive(false);
        //q45050Button.SetActive(false);

        //setting two buttons off after 50/50 button clicked
        option3Q4.SetActive(false);
        option4Q4.SetActive(false);
    }
    //setting quit yes and no button active and text
    public void quitButtonClicked()
    {
        quitYesButtonq4.SetActive(true);
        quitNoButtonq4.SetActive(true);
    }
    //setting buttons to false so they are no longer displayed if user doesn't want to quit
    public void quitNoButtonClicked()
    {
        quitYesButtonq4.SetActive(false);
        quitNoButtonq4.SetActive(false);
    }
}
