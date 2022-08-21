using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SkipIntro : MonoBehaviour
{

    public int idScene;

    void Start()
    {
        Debug.Log("Press Space to skip");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(idScene);
        }
    }
}
