using System.Collections;
using UnityEngine;

public class enemybehavior : MonoBehaviour
{
    public float speed;
    public float turnDelay;

    bool faceRight = false;

    int health = 1;
   
    void Start()
    {
        
        
        
        StartCoroutine(SwitchDirections());

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    IEnumerator SwitchDirections(){
        yield return new WaitForSeconds(turnDelay);
        Switch();
        
    }
    private void Switch(){
        
        faceRight = !faceRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;

        speed *= -1;

        StartCoroutine(SwitchDirections());
        
    }
    public void TakeDamage(int damage){
        health -= damage;

        if(health <= 0){

            Destroy(gameObject);

        }
        
    }
}
