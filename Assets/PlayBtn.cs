using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBtn : MonoBehaviour
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

    public void HitOn() {
    
        processor.PlayShoot();
    }
}
