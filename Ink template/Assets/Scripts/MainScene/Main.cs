using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public static int currentStage = 0;
    public static int clearStage = 0;

    GameObject stage2Button;
    GameObject stage3Button;


    Transform inkmanTransform;
    // Start is called before the first frame update
    void Start()
    {
        inkmanTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Debug.Log("2");
    }

    // Update is called once per frame
    void Update()
    {
        switch (clearStage)
        {
            case 0:
                inkmanTransform.position = new Vector2(-6.8f, 0.6f);
                break;
            case 1:
                inkmanTransform.position = new Vector2(-5f, -3f);
                break;
            case 2:
                inkmanTransform.position = new Vector2(5f, -1.2f);
                break;
            case 3:
                inkmanTransform.position = new Vector2(6.9f, -3.8f);
                break;
        }
    }

    public void ToExit() 
    {
        Application.Quit();
    }

    public void toTutorial()
    {
        currentStage = 1;
        SceneManager.LoadScene("Stage_tutorial");
    }

    public void toStage1()
    {
        currentStage = 2;
        SceneManager.LoadScene("Stage1");
    }
    public void toBoss()
    {
        currentStage = 3;
        SceneManager.LoadScene("Stage_boss");
    }
}
