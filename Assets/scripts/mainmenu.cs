
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{

    public void PlayGame(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        SceneManager.LoadScene("Levels",LoadSceneMode.Single);
    }

    public void QuitGame(){
        Debug.Log("quit");
        Application.Quit();
    }

    public void MainMenu(){
        SceneManager.LoadScene("mainmenu");
    }



    public void Restart()
    {
  
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        playercontroller player = GameObject.Find("Player").GetComponent<playercontroller>();

        player.Finished = false;
        

    }
    public void Levels(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
