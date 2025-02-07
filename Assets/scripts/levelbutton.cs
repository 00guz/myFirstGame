
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelbutton : MonoBehaviour
{
    public int levelId;
    public Button button;

    public void OpenLevel(){
        SceneManager.LoadScene("Level" + levelId.ToString());
    } 
}
