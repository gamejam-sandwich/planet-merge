using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsHS : MonoBehaviour
{
    //This script is to control the buttons of the home screen.
    //Includes play button, settings button, and sliders.

    public Button theButton;

    void Start()
    {
        Button btn = theButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    public static GameObject FindObjectByName(string name)
    {
        GameObject[] objs = Resources.FindObjectsOfTypeAll<GameObject>();
        
        foreach(GameObject obj in objs)
        {
            if(obj.name == name)
            {
                return obj;
            }
        }
        return null;
    }

    void SwitchObject(string name, bool onOff)
    {
        GameObject obj = FindObjectByName(name);
        if (obj != null) obj.SetActive(onOff);
    }

    async void TaskOnClick()
    {
        if (theButton.name == "PlayBtn")
        {
            SceneManager.LoadScene("GameScreen");
        }
        else if (theButton.name == "SettingsBtn")
        {
            SwitchObject("SettingsPanel", true);
        }
        else if (theButton.name == "BackBtn")
        {
            SwitchObject("SettingsPanel", false);
        }
    }
}
