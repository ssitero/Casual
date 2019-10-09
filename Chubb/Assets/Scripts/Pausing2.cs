using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausing2 : MonoBehaviour
{
  public static bool GameIsPaused = false;
  public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.P)){

      if (GameIsPaused){
      Resume();
      }
      else {
      Pause();
      }
      }
    }

    public void Resume (){
    PauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
    GameIsPaused = false;

    }

    void Pause(){

    PauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
    GameIsPaused = true;



    }
    public void quitmenu (){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}
