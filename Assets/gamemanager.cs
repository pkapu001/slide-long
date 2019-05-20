using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    private float slowdown = 10f;

    public void endgame()
    {
        StartCoroutine(restartlevel());
    }

    IEnumerator restartlevel()
    {
         Time.timeScale = 1f / slowdown;
         Time.fixedDeltaTime = Time.fixedDeltaTime / slowdown;

         yield return new WaitForSeconds(1f/slowdown);
         Time.timeScale = 1f ;
         Time.fixedDeltaTime = 0.02f;
      
      // yield return new WaitForSeconds(2f );
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
