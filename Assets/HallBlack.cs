using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HallBlack : MonoBehaviour
{
    // Start is called before the first frame update
    public GameProcessor processor;
    void Start()
    {
        processor = FindFirstObjectByType<GameProcessor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "WhitePlay") {

            Destroy(collision.gameObject);

     
           // processor.MaxMark();
            if (processor != null) {
                processor.MaxMark();
            }else
            {
                Debug.Log("done");
            }
        }
    }
}
