using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallW : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rb2d;
   
    public GameArrow gameArrow;
    public float arrowRorationSpeed;
    private float arrowRoration;
    public GameObject arrowHeader;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        gameArrow = GetComponentInChildren<GameArrow>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        MoveMouseGame();
        NotifyVelocity();

        arrowRoration += arrowRorationSpeed * Time.deltaTime;
        gameArrow.transform.rotation = Quaternion.Euler(0, 0, arrowRoration);
    }

    public void HitOn(float moveSpeed) { 
      
        Vector2 playSide = (arrowHeader .transform.position - this.transform.position).normalized;

       
             
            rb2d.AddForce(playSide * moveSpeed, ForceMode2D.Impulse);
        

        
    }


    public void MoveMouseGame() {

        //Vector3 movuseMove = Input.mousePosition;
        //if (Input.GetKeyDown(KeyCode.K))
        //{

        //    Debug.Log(movuseMove.x.ToString() + " ---- " + movuseMove.y.ToString());
        //}

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null)
        {
            //this.gameObject.name == "whileBall"
            if (hit.collider.gameObject.name == this.gameObject.name && Input.GetMouseButtonDown(0) ) {

                gameArrow.gameObject.SetActive(true);
                
            }

            if (hit.collider.gameObject.name == this.gameObject.name && Input.GetMouseButtonUp(0))
            {

                gameArrow.gameObject.SetActive(false);
            }
        }
    }


    void NotifyVelocity()
    {
        //Debug.Log(rb2d.velocity.magnitude);


        if (rb2d.velocity.magnitude < 1.1f)
        {
            //Debug.Log("Stop");
            rb2d.velocity = Vector2.zero * 0f;
            this.transform.rotation = Quaternion.identity;
            gameArrow.gameObject.SetActive(true);
        }
        else {


            gameArrow.gameObject.SetActive(false);
        }
    }


}
