
using UnityEngine;
using TMPro;

public class playercontroller : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 velocity;

    public int score;

    public float speed;

    public float jump;

    public Animator animator;

    public TextMeshProUGUI scoreText;

    public GameObject enemyses;

    public bool Finished = false;

    public GameObject backgroundMusic;
    public GameObject Gameover;

    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
        

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score :" + score.ToString();
        if(Finished == false){
        velocity = new Vector3(Input.GetAxis("Horizontal"),0f);
        transform.position += velocity * Time.deltaTime * speed;
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

        if (Input.GetButtonDown("Jump") && animator.GetBool("isJumping") == false){
            rb.AddForce(Vector3.up * jump ,ForceMode2D.Impulse);
            animator.SetBool("isJumping", true);
        }
        

        if (Input.GetAxisRaw("Horizontal") == -1){
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1){
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        }
    }
    private void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.name == "Ground"){
            animator.SetBool("isJumping", false);
        }
        else if (other.gameObject.tag == "Enemy"){
            if(transform.position.y> other.transform.position.y+0.8f){
                enemybehavior enemy = other.gameObject.GetComponent<enemybehavior>();
                if(enemy != null){
                    Instantiate(enemyses);
                    enemy.TakeDamage(1);
                }
            }
            else{
                
                Gameover.SetActive(true);
                backgroundMusic.SetActive(false);
                Finished = true;
            }

          

    }
    }

    private void OnCollisionStay2D(Collision2D other){
        if (other.gameObject.name == "Ground"){
            animator.SetBool("isJumping", false);
        }
    }

    private void OnCollisionExit2D(Collision2D other){
        if (other.gameObject.name == "Ground" ){
            animator.SetBool("isJumping", true);
        }
    }



    


}
