using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wrongMenu3Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //taking user to main menu after clicking button
    public void mainMenuActive()
    {
        SceneManager.LoadScene("userInterfaceScene");
    }
}
