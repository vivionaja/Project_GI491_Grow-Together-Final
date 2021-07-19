using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAnim : MonoBehaviour
{
    Player player;
    Animator anim;
    public static bool isWash;
    public static bool isBath;
    public static bool isEat;
    public static bool isSleep;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {   
        anim.SetBool("isWash", isWash);
        anim.SetBool("isBath", isBath);
        anim.SetBool("isEat",isEat);
    }
    

}
