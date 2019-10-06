using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restartbut : MonoBehaviour
{


    void Update ()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

   

      
        
}
