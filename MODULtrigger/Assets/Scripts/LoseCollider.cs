using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "UFO")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
