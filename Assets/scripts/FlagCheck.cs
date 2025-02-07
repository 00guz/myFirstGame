
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagCheck : MonoBehaviour
{
    public Animator animator;
    public GameObject winAudio;

    private bool CoinDestroy = false;

    public GameObject coins;

    void Update(){

        coins = GameObject.FindWithTag("Coins");
        if(coins == null){
            CoinDestroy = true;
        }

        
    }
    

    void OnTriggerEnter2D(Collider2D other){
        
        if(other.gameObject.tag == "Player"){
            
            if(CoinDestroy == true){
                playercontroller player = other.gameObject.GetComponent<playercontroller>();
                player.animator.SetFloat("Speed", 0);
                player.Finished = true;
                Instantiate(winAudio);
                animator.SetTrigger("Transition");
                
            }
            

        }
    }
    public void OnAnimationComplete(){
        SceneManager.LoadScene("Congratulations",LoadSceneMode.Single);
    }
}
