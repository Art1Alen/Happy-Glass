using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{   [SerializeField]
    private Sprite suspense,happy, sad;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void ChnageSpriteToSuspense()
    {
        GetComponent<SpriteRenderer>().sprite = suspense;

    } 
    public void ChnageSpriteToHappy()
    {
        GetComponent<SpriteRenderer>().sprite = happy;
    } 
    public void ChnageSpriteToSad()
    {
        GetComponent<SpriteRenderer>().sprite = sad;

    }
}
