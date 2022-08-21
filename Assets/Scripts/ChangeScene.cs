using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public bool changeScene;
    public int idScene;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            SceneManager.LoadScene(idScene);
        }
    }

    public void ChangeSceneEnter(int idScene){
        SceneManager.LoadScene(idScene);
    }
}
