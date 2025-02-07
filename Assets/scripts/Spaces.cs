using UnityEngine;


public class Spaces : MonoBehaviour
{



    void OnTriggerEnter2D(Collider2D other){

        if (other.gameObject.tag == "Player"){
            
            

            playercontroller player = other.gameObject.GetComponent<playercontroller>();
            player.Gameover.SetActive(true);
            player.backgroundMusic.SetActive(false);
            player.Finished = true;

            
        }

            


    }
   
        
    
}

