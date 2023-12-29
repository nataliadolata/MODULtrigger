using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Start()
    {
        
    }
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            text.text = "Doom";
        }
        
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}
