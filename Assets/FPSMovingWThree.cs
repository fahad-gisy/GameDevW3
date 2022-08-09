using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;


public class FPSMovingWThree : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    [SerializeField] public float speed = 10;
    [SerializeField] private LayerMask groundLayerMask;
    [SerializeField] private Transform groundCheck;
    private bool isJumping = true;
    private float facing;
    public SoundActions _soundActionsScript;
    public float jumpH = 250f;
    public int coinCount = 0;
    private GameObject winObj;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI heartText;
    public float health = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        winObj = GameObject.Find("WinObj");
        winObj.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {  //getting our X and Z input > H = X & V = Z
        float inputH = Input.GetAxis("Horizontal") * speed;
        float inputV = Input.GetAxis("Vertical") * speed;
        //put our input inside v3
        Vector3 movements = new Vector3(inputH, 0, inputV);
        //moving by our rigidbody's velocity
        // rb.velocity = new Vector3(movements.x, rb.velocity.y, movements.z);
         rb.velocity = new Vector3(movements.x, rb.velocity.y, movements.z);
        //if the player moving then...
        if (movements.x !=0 || movements.z !=0)
        {  //face the way the player moving to
            facing = Mathf.Atan2(movements.x, movements.z) * Mathf.Rad2Deg;
        }//rotating our rigidbody to the way the player moving to
        rb.rotation = Quaternion.Euler(0,facing,0);
        
        
        coinText.text = coinCount.ToString();//Coin text
        heartText.text = health.ToString(); // Health text
        Jump();
        Win();
        Lose();




    }//Horizontal //Vertical

    private void Lose()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
        
    }

    private void Jump()
   {
       bool grounded = Physics.Linecast(transform.position, groundCheck.position, groundLayerMask);
       if (grounded)
       {
           if (Input.GetKeyDown(KeyCode.Space))
           {
               rb.AddForce(Vector3.up * jumpH);
               _soundActionsScript.PlayerJumpSound();
           }
       }
       else
       {
           isJumping = false;
       }
   }

   private void Win()
   {
       if (coinCount >= 20)
       {
           Debug.Log("GZ YOU NOW HAVE 20 COINS");
           _soundActionsScript.PlayerWinSound();
           winObj.SetActive(true);
       }
   }
}
