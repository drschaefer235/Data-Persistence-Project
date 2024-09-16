using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField field;
  
    private void Start()
    {
        //inputField = new GameObject.Find("PlayerNameInputField").GetComponent<InputField>();
        //Debug.Log(field.text);
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        DataManager.Instance.SaveNameAndScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void PlayerNameInput()
    {
        //field = GameObject.Find("PlayerNameInputField").GetComponent<InputField>();
        Debug.Log(field.text);
        string playerName = field.text;
        DataManager.Instance.playerName = playerName;
    }
}
