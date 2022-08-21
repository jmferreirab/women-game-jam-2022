using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public int idScene;
    private bool place;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && place == true){
            SceneManager.LoadScene(idScene);
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            Debug.Log("Player In - Press Space to Enter");
            place = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if(other.tag == "Player"){
            Debug.Log("Player Exit");
            place = true;
        }
    }
}
