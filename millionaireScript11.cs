using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class millionaireScript : MonoBehaviour
{
    //game objects to be used during execution of code 
    public string sceneOne = "userInterfaceScene";
    public string sceneTwo = "rulesMenuScene";
    public string sceneThree = "question1SceneMenu";
    public string sceneFour = "question2SceneMenu";
    public string sceneFive = "question3SceneMenu";
    public string sceneSix = "question4SceneMenu";
    public string sceneSeven = "wrongMenu1Scene";
    public string sceneEight = "wrongMenu2Scene";
    public string sceneNine = "wrongMenu3Scene";
    public string sceneTen = "wrongMenu4Scene";
    public string sceneEleven = "winnerMenuScene";

    public GameObject userInterface;
    public GameObject rulesMenu;
    public GameObject question1Menu;
    public GameObject question2Menu;
    public GameObject question3Menu;
    public GameObject question4Menu;
    public GameObject wrongMenu1;
    public GameObject wrongMenu2;
    public GameObject wrongMenu3;
    public GameObject wrongMenu4;
    public GameObject winnerMenu;
    public GameObject q15050Button;
    public GameObject q25050Button;
    public GameObject q35050Button;
    public GameObject q45050Button;
    public GameObject option1Q1;
    public GameObject option2Q1;
    public GameObject option3Q1;
    public GameObject option4Q1;
    public GameObject option1Q2;
    public GameObject option2Q2;
    public GameObject option3Q2;
    public GameObject option4Q2;
    public GameObject option1Q3;
    public GameObject option2Q3;
    public GameObject option3Q3;
    public GameObject option4Q3;
    public GameObject option1Q4;
    public GameObject option2Q4;
    public GameObject option3Q4;
    public GameObject option4Q4;
    public GameObject quitButton;
    public GameObject quitButton2;
    public GameObject quitButton3;
    public GameObject quitButton4;
    public GameObject continueButton;
    public GameObject backToMenuButton1;
    public GameObject backToMenuButton2;
    public GameObject backToMenuButton3;
    public GameObject backToMenuButton4;
    public GameObject backToMenuButtonW;

    // Start is called before the first frame update
    void Start()
    {
        //first panel is active and all other panels are off when application is run
        SceneManager.LoadScene(sceneOne);
    }
    //if a quit button on any menu is clicked this code will run below to bring the user back to the main menu
    public void startAgain()
    {
        //first panel is active and others are not active and 50/50 buttons are active again and other hidden buttons are visible
        SceneManager.LoadScene(sceneOne);
        /*userInterface.SetActive(true);
        rulesMenu.SetActive(false);
        question1Menu.SetActive(false);
        question2Menu.SetActive(false);
        question3Menu.SetActive(false);
        question4Menu.SetActive(false);
        wrongMenu1.SetActive(false);
        wrongMenu2.SetActive(false);
        wrongMenu3.SetActive(false);
        wrongMenu4.SetActive(false);
        winnerMenu.SetActive(false);
        q25050Button.SetActive(true);
        q35050Button.SetActive(true);
        q45050Button.SetActive(true);
        option1Q1.SetActive(true);
        option4Q1.SetActive(true);
        option3Q2.SetActive(true);
        option4Q2.SetActive(true);
        option2Q3.SetActive(true);
        option3Q3.SetActive(true);
        option2Q4.SetActive(true);
        option4Q4.SetActive(true);*/
    }
    //start button function
    public void rulesMenuActive()
    {
        //setting rules menu active and turning first panel off once button is clicked
        SceneManager.LoadScene(sceneTwo);
        /*userInterface.SetActive(false);
        rulesMenu.SetActive(true);*/
    }
    //continue button function
    public void question1MenuActive()
    {
        //setting q1 menu active after clicking continue button
        SceneManager.LoadScene(sceneThree);
        /*rulesMenu.SetActive(false);
        question1Menu.SetActive(true);*/
    }
    //correct answer chosen in q1
    public void question2MenuActive()
    {
        //setting q2 menu active after clicking correct button
        SceneManager.LoadScene(sceneFour);
        /*question1Menu.SetActive(false);
        question2Menu.SetActive(true);*/
    }
    //correct answer chosen in q2
    public void question3MenuActive()
    {
        //setting q3 menu active after clicking correct button
        SceneManager.LoadScene(sceneFive);
        /*question2Menu.SetActive(false);
        question3Menu.SetActive(true);*/
    }
    //correct answer chosen in q3
    public void question4MenuActive()
    {
        //setting q4 menu active after clicking correct button
        SceneManager.LoadScene(sceneSix);
        /*question3Menu.SetActive(false);
        question4Menu.SetActive(true);*/
    }
    //correc answer chosen in q4
    public void winnerMenuActive()
    {
        //setting winner menu active after clicking correct button
        SceneManager.LoadScene(sceneEleven);
        /*question4Menu.SetActive(false);
        winnerMenu.SetActive(true);*/
    }
    
    //50/50 button clicked in q1
    public void q15050ButtonClicked()
    {
        //setting other 50/50 buttons in other panels off 
        q25050Button.SetActive(false);
        q35050Button.SetActive(false);
        q45050Button.SetActive(false);
        //setting two buttons off after 50/50 button clicked
        option1Q1.SetActive(false);
        option4Q1.SetActive(false);
    }
    //50/50 button clicked in q2
    public void q25050ButtonClicked()
    {
        //setting other 50/50 buttons in other panels off 
        q35050Button.SetActive(false);
        q45050Button.SetActive(false);
        //setting two buttons off after 50/50 button clicked
        option3Q2.SetActive(false);
        option4Q2.SetActive(false);
    }
    //50/50 button clicked in q3
    public void q35050ButtonClicked()
    {
        //setting other 50/50 buttons in other panels off 
        q45050Button.SetActive(false);
        //setting two buttons off after 50/50 button clicked
        option2Q3.SetActive(false);
        option3Q3.SetActive(false);
    }
    //50/50 button clicked in q4
    public void q45050ButtonClicked()
    {
        //setting two buttons off after 50/50 button clicked
        option2Q4.SetActive(false);
        option4Q4.SetActive(false);
    }

    //quit button q1 clicked
    public void quitButtonQ1()
    {
        //setting q1 menu off and wrong menu1 on
        SceneManager.LoadScene(sceneSix);
        /*question1Menu.SetActive(false);
        wrongMenu1.SetActive(true);*/
    }
    //quit button q2 clicked
    public void quitButtonQ2()
    {
        //setting q2 menu off and wrong men2 on
        question2Menu.SetActive(false);
        wrongMenu2.SetActive(true);
    }
    //quit button q3 clicked
    public void quitButtonQ3()
    {
        //setting q3 menu off and wrong menu3 on
        question3Menu.SetActive(false);
        wrongMenu3.SetActive(true);
    }
    //quit button q4 clicked
    public void quitButtonQ4()
    {
        //setting q4 menu off and wrong menu4 on
        question4Menu.SetActive(false);
        wrongMenu4.SetActive(true);
    }
    

    //display wrong menu1 after incorrect button was selected or quit option was chosen
    public void wrongMenu1Active()
    {
        question1Menu.SetActive(false);
        wrongMenu1.SetActive(true);
    }
    //display wrong menu2 after incorrect button was selected or quit option was chosen
    public void wrongMenu2Active()
    {
        question2Menu.SetActive(false);
        wrongMenu2.SetActive(true);
    }
    //display wrong menu3 after incorrect button was selected or quit option was chosen
    public void wrongMenu3Active()
    {
        question3Menu.SetActive(false);
        wrongMenu3.SetActive(true);
    }
    //display wrong menu4 after incorrect button was selected or quit option was chosen
    public void wrongMenu4Active()
    {
        question4Menu.SetActive(false);
        wrongMenu4.SetActive(true);
    }
}
