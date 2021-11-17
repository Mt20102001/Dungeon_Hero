using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat_Player : MonoBehaviour
{
    #region Public Value
    public Animator animator;
    public bool CanMove;
    #endregion

    #region Private Value

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        CanMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            animator.SetBool("StopAttack", true);
            animator.SetTrigger("Attack");
            CanMove = false;
        }

    }

    private void FixedUpdate()
    {

    }
}
