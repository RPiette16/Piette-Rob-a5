using System;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool isPaused;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape)) 
      {
            isPaused = !isPaused;
      }

      if (isPaused)
      {
          ActivateMenu();
      }
      
      else 
      {
            DeactivateMenu();
      }
    }

    void ActivateMenu() 
    {
        pauseMenuUI.SetActive(true);
    }

    void DeactivateMenu() 
    {
        pauseMenuUI.SetActive(false);
    }
}
