using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomOpen : MonoBehaviour
{

    void Start()
    {

    }

    public void PlayGame (){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

public void QuitGame(){
  Application.Quit();
}

    void Update()
    {
        if (Input.GetKey("escape")){
          Application.Quit();
        }
    }
}
