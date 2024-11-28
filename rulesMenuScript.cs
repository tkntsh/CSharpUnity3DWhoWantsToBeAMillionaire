using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rulesMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //continue button function
    public void question1MenuActive()
    {
        //setting q1 menu scene active after clicking continue button
        SceneManager.LoadScene("question1MenuScene");
    }
}
