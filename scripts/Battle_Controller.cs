using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_Controller : MonoBehaviour
{
    public bool new_turn;
    public bool moved;
    public bool moveable_space;
    public bool attackable_space;
    public bool attacked;
    public Character[] characters;
    public int length;
    public int xspeed = 0;
    public Character goesNext;
    public Camera main_camera;

    public GameObject battle_menu_canvas;
    public GameObject action_canvas;
    public GameObject move_selector;

    public Menu_Manager menu;
    

    public float seconds;
    public float timer;
    public float speed;
    public Vector2 end;
    public Vector2 Difference;
    public Vector2 start;

    //public selector selector;
    // Start is called before the first frame update
    void Start()
    {
        new_turn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (new_turn)
        {
            moved = false;
            attacked = false;
            xspeed = goesNext.speed;
            length = characters.Length;

            for (int x = 0; x < length; x++)
            {
                if (xspeed < characters[x].speed)
                {
                    xspeed = characters[x].speed;
                    goesNext = characters[x];
                }
            }

            battle_menu_canvas.SetActive(true);
            new_turn = false;
        }
        //move player to selector
        if (menu.menu_move)
        {

            
                move_selector.SetActive(true);
            
            battle_menu_canvas.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.B) && moveable_space)
        {
            move_selector.GetComponent<Move_Selector>().enabled = false;
            action_canvas.SetActive(true);
            moveable_space = false;
        }
        if (menu.menu_no && menu.menu_move)
        {
            
            menu.menu_no = false;
            menu.menu_move = false;
            action_canvas.SetActive(false);
            battle_menu_canvas.SetActive(true);
            move_selector.SetActive(true);
        }
        if (menu.menu_yes && menu.menu_move)
        {
           
            //on player move change sorting order
            
            action_canvas.SetActive(false);
            if (timer <= seconds)
            {

                timer += Time.deltaTime;
                start = new Vector2(goesNext.transform.position.x, goesNext.transform.position.y);
                end = new Vector2(move_selector.transform.position.x, move_selector.transform.position.y -.4f);
                goesNext.transform.position = Vector2.MoveTowards(start,end,speed * Time.deltaTime);
                //goesNext.GetComponent<SpriteRenderer>().sortingOrder = this.gameObject.GetComponent<SpriteRenderer>().sortingOrder;
                //if something is in way then move around it
            }
            if (timer > seconds || (goesNext.transform.position.x, goesNext.transform.position.y) == (move_selector.transform.position.x, move_selector.transform.position.y - .4f))
            {
                move_selector.GetComponent<Move_Selector>().enabled = true;
                menu.menu_yes = false;
                menu.menu_move = false;
                move_selector.SetActive(false);
                battle_menu_canvas.SetActive(true);
                timer = 0;
                moved = true;
            }
        }












        //move player to selector
        if (Input.GetKeyDown(KeyCode.B) && menu.menu_attack)
        {

            move_selector.SetActive(true);
            battle_menu_canvas.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.B) && attackable_space)
        {
            
            action_canvas.SetActive(true);
            move_selector.SetActive(false);
            attackable_space = false;
        }
        if (menu.menu_no && menu.menu_attack)
        {

            menu.menu_no = false;
            menu.menu_attack = false;
            action_canvas.SetActive(false);
            battle_menu_canvas.SetActive(true);
        }
        if (menu.menu_yes && menu.menu_attack)
        {
            Debug.Log("do attack");
            menu.menu_yes = false;
            menu.menu_attack = false;
            action_canvas.SetActive(false);
            battle_menu_canvas.SetActive(true);
            attacked = true;

        }


        if (menu.menu_wait)
        {
            battle_menu_canvas.SetActive(false);
            action_canvas.SetActive(true);
            move_selector.SetActive(false);
        }

        if (menu.menu_wait && menu.menu_yes)
        {
            goesNext.speed = 0;
            menu.menu_wait = false;
            menu.menu_yes = false;
            action_canvas.SetActive(false);
            moved = false;
            attacked = false;
            new_turn = true;
            main_camera.transform.position = new Vector3(goesNext.transform.position.x, goesNext.transform.position.y, main_camera.transform.position.z);
        }


        //back to battle-menu
        if (Input.GetKeyDown(KeyCode.V)) //V is to cancel back to battle-menu
        {
            // set all tiles to false;
            menu.menu_attack = false;
            menu.menu_move = false;
            menu.menu_wait = false;
            action_canvas.SetActive(false);
            move_selector.SetActive(false);
            battle_menu_canvas.SetActive(true);
        }


        if (new_turn)
            for (int x = 0; x < length; x++)
            {
                characters[x].speed++;

            }
    }
}





    
