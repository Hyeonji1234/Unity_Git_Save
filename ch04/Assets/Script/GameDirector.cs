using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public GameObject distance;

    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("distance");
    }

    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;
        distance.GetComponent<TextMeshProUGUI>().text = "Distance: " + length.ToString("F2") + "m";
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReloadScene()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
}
