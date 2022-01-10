using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int speed;
    public int move;
    public int maxHealth;
    public int currentHealth;
    public int maxMana;
    public int currentMana;
    public int attack_power;
    public int attack_range;

    public bool move_up;
    public bool move_down;
    //needs a climb up method
    //needs a move obstacle method


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move_up)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sortingOrder += 1;
        }
        if (move_down)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sortingOrder -= 1;
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("moveupleft") && this.gameObject.GetComponent<SpriteRenderer>().sortingOrder == other.gameObject.GetComponent<SpriteRenderer>().sortingOrder)
        {
            move_up = true;
        }
        if (other.gameObject.CompareTag("moveupright") && this.gameObject.GetComponent<SpriteRenderer>().sortingOrder == other.gameObject.GetComponent<SpriteRenderer>().sortingOrder)
        {
            move_up = true;
        }
        if (other.gameObject.CompareTag("moveupdleft") && this.gameObject.GetComponent<SpriteRenderer>().sortingOrder == other.gameObject.GetComponent<SpriteRenderer>().sortingOrder)
        {
            move_up= true;
        }
        if (other.gameObject.CompareTag("moveupdright") && this.gameObject.GetComponent<SpriteRenderer>().sortingOrder == other.gameObject.GetComponent<SpriteRenderer>().sortingOrder)
        {
            move_up = true;
        }
        if (other.gameObject.CompareTag("movedownleft") && this.gameObject.GetComponent<SpriteRenderer>().sortingOrder == other.gameObject.GetComponent<SpriteRenderer>().sortingOrder)
        {
            move_down = true;
        }
        if (other.gameObject.CompareTag("movedownright") && this.gameObject.GetComponent<SpriteRenderer>().sortingOrder == other.gameObject.GetComponent<SpriteRenderer>().sortingOrder)
        {
            move_down = true;
        }
        if (other.gameObject.CompareTag("movedowndleft") && this.gameObject.GetComponent<SpriteRenderer>().sortingOrder == other.gameObject.GetComponent<SpriteRenderer>().sortingOrder)
        {
            move_down = true;
        }
        if (other.gameObject.CompareTag("movedowndright") && this.gameObject.GetComponent<SpriteRenderer>().sortingOrder == other.gameObject.GetComponent<SpriteRenderer>().sortingOrder)
        {
            move_down = true;
        }

    }
        private void OnTriggerExit2D(Collider2D other)
        {
       
            if (other.gameObject.CompareTag("moveupleft")) //do not need to compare sorting level when leaving the trigger
            {
                move_up = false;
            }
            if (other.gameObject.CompareTag("moveupright"))
            {
                move_up = false;
            }
            if (other.gameObject.CompareTag("moveupdleft"))
            {
                move_up = false;
            }
            if (other.gameObject.CompareTag("moveupdright"))
            {
                move_up = false;
            }
            if (other.gameObject.CompareTag("movedownleft"))
            {
                move_down = false;
            }
            if (other.gameObject.CompareTag("movedownright"))
            {
                move_down = false;
            }
            if (other.gameObject.CompareTag("movedowndleft"))
            {
                move_down = false;
            }
            if (other.gameObject.CompareTag("movedowndright"))
            {
                move_down = false;
            }
           
        }
}
