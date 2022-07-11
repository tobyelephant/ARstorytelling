using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    // Start is called before the first frame update
   public void MainMenu()
   {
       SceneManager.LoadScene("homePage");
   }

   public void ARScene()
   {
       SceneManager.LoadScene("ARscene");
   }

   public void QuitApp()
   {
       Application.Quit();
   }
}
