using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class userInterfaceScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //start button function
    public void startApp()
    {
        //setting user interface scene menu active
        SceneManager.LoadScene("userInterfaceScene");
    }
    //start button function
    public void rulesMenuActive()
    {
        //setting rules menu scene active
        SceneManager.LoadScene("rulesMenuScene");
    }
}
