using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SaveName : MonoBehaviour
{
    public InputField inputname;


    public void Save()
    {
        PlayerPrefs.SetString("playername", inputname.text);
        SceneManager.LoadScene(1);  
    }

}
