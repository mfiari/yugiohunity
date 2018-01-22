using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LangueScript : MonoBehaviour {

    public GameObject flag;

    void OnMouseDown()
    {
        SceneManager.LoadScene("menu");
    }
}
