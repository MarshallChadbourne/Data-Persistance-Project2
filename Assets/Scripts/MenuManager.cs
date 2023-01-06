using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public TMP_InputField inputField;

    public Button loadButton;

    public static string playerName;

    private void Start() 
    {
        if(Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }


    public void LoadMainScene()
    {
        StorePlayerName();
        SceneManager.LoadScene("main");
    }

    private void StorePlayerName() => playerName = inputField.text;
    
}
