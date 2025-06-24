using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
       

        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayGeme()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
        
}
