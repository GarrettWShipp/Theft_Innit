using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform pos1, pos2; //Positions that the platform moves to.
    public Transform startPos;
    public float speed;
    public Animator anmi;
    

    Vector3 nextPos;

    // bool platformOn = true;

    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pos1.position) //Checks current pos to pos1.
        {
            nextPos = pos2.position; //tells the platform that it will be moving to pos2
            anmi.SetTrigger("Enemy");
        }
        if (transform.position == pos2.position) //Checks current pos to pos2.
        {
            nextPos = pos1.position;//tells the platform that it will be moving to pos1
            anmi.SetTrigger("Enemy");
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime); //Movement


    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
