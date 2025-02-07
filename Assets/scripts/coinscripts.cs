
using UnityEngine;

public class bronzecoinscripts : MonoBehaviour
{
    public GameObject Ses;
    
    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.tag =="Player"){
            
            Instantiate(Ses);        
            playercontroller player = other.gameObject.GetComponent<playercontroller>();
            if (gameObject.name == "BronzeCoin"){           
                player.score +=5;
                Destroy(gameObject);
            }        
            else if(gameObject.name == "SilverCoin"){            
                player.score +=10;
                Destroy(gameObject);
            }
            else{
                player.score+=20;            
                Destroy(gameObject);
            }
        }
    }
}