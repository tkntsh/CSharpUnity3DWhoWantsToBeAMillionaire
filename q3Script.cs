using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class q3Script : MonoBehaviour
{
    public GameObject option1Q3;
    public GameObject option2Q3;
    public GameObject option3Q3;
    public GameObject option4Q3;
    public GameObject q35050Button;
    //public GameObject q25050Button;
    //public GameObject q35050Button;
    //public GameObject q45050Button;
    public GameObject quitButtonq3;
    public GameObject quitYesButtonq3;
    public GameObject quitNoButtonq3;

    // Start is called before the first frame update
    void Start()
    {
        option2Q3.SetActive(true);
        option3Q3.SetActive(true);
    }

    //correct answer chosen in q3
    public void question4MenuActive()
    {
        //setting q4 menu scene active after clicking correct button
        SceneManager.LoadScene("question4MenuScene");
    }
    //display wrong menu3 after incorrect button was selected or quit option was chosen
    public void wrongMenu3Active()
    {
        //setting wrong menu scene active after wrong option was selected or yes quit button selected
        SceneManager.LoadScene("wrongMenu3Scene");
    }
    //50/50 button clicked in q3
    public void q35050ButtonClicked()
    {
        //setting other 50/50 buttons in other panels off 
        //q25050Button.SetActive(false);
        //q35050Button.SetActive(false);
        //q45050Button.SetActive(false);

        //setting two buttons off after 50/50 button clicked
        option2Q3.SetActive(false);
        option3Q3.SetActive(false);
    }
    //setting quit yes and no button active and text
    public void quitButtonClicked()
    {
        quitYesButtonq3.SetActive(true);
        quitNoButtonq3.SetActive(true);
    }
    //setting buttons to false so they are no longer displayed if user doesn't want to quit
    public void quitNoButtonClicked()
    {
        quitYesButtonq3.SetActive(false);
        quitNoButtonq3.SetActive(false);
    }
}
