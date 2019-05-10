using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class numberscene : MonoBehaviour
{
    // Start is called before the first frame update
    public string [] scenename;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            SceneManager.LoadScene(scenename[0]);

        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            SceneManager.LoadScene(scenename[1]);

        }
        else if(Input.GetKeyDown(KeyCode.Keypad3))
        {
            SceneManager.LoadScene(scenename[2]);

        }
        else if(Input.GetKeyDown(KeyCode.Keypad4))
        {
            SceneManager.LoadScene(scenename[3]);

        }
    }
}
