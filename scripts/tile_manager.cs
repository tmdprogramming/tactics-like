using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile_manager : MonoBehaviour
{
    public Menu_Manager menu;
    public Battle_Controller battle_Controller;
    public GameObject move_tile;
    public GameObject attack_tile;
    public bool move;
    public bool attack;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnEnable()
    {
        if (menu.menu_move)
        {
            move = true;
        }
        if (menu.menu_attack)
        {
            attack = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        OnEnable();
        if (move)
        {

            for (int x = 1; x <= battle_Controller.goesNext.move; x++)
            {
                //shared = x;
                for (int j = x + 1; j <= battle_Controller.goesNext.move; j++)
                {
                    Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x + (1f * x) - (.5f * j), battle_Controller.goesNext.transform.position.y + .15f + (.25f * j)), Quaternion.identity);
                    Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x + (1f * x) - (.5f * j), battle_Controller.goesNext.transform.position.y + .15f + (-.25f * j)), Quaternion.identity);
                    Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x + (.5f * j), battle_Controller.goesNext.transform.position.y + .15f + (.5f * x) + (-.25f * j)), Quaternion.identity);
                    Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x - (.5f * j), battle_Controller.goesNext.transform.position.y + .15f + (.5f * x) + (-.25f * j)), Quaternion.identity);
                }
                Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x + .5f * x, battle_Controller.goesNext.transform.position.y + .15f + (.25f * x)), Quaternion.identity);
                Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x + .5f * x, battle_Controller.goesNext.transform.position.y + .15f + (-.25f * x)), Quaternion.identity);
                Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x - .5f * x, battle_Controller.goesNext.transform.position.y + .15f + (.25f * x)), Quaternion.identity);
                Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x - .5f * x, battle_Controller.goesNext.transform.position.y + .15f + (-.25f * x)), Quaternion.identity);
            }
            this.gameObject.SetActive(false);
        }


        if (attack)
        {
            for (int x = 1; x <= battle_Controller.goesNext.attack_range; x++)
            {
                //shared = x;
                for (int j = x + 1; j <= battle_Controller.goesNext.move; j++)
                {
                    Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x + (1f * x) - (.5f * j), battle_Controller.goesNext.transform.position.y + .15f + (.25f * j)), Quaternion.identity);
                    Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x + (1f * x) - (.5f * j), battle_Controller.goesNext.transform.position.y + .15f + (-.25f * j)), Quaternion.identity);
                    Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x + (.5f * j), battle_Controller.goesNext.transform.position.y + .15f + (.5f * x) + (-.25f * j)), Quaternion.identity);
                    Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x - (.5f * j), battle_Controller.goesNext.transform.position.y + .15f + (.5f * x) + (-.25f * j)), Quaternion.identity);
                }
                Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x + .5f * x, battle_Controller.goesNext.transform.position.y + .15f + (.25f * x)), Quaternion.identity);
                Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x + .5f * x, battle_Controller.goesNext.transform.position.y + .15f + (-.25f * x)), Quaternion.identity);
                Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x - .5f * x, battle_Controller.goesNext.transform.position.y + .15f + (.25f * x)), Quaternion.identity);
                Instantiate(move_tile, new Vector2(battle_Controller.goesNext.transform.position.x - .5f * x, battle_Controller.goesNext.transform.position.y + .15f + (-.25f * x)), Quaternion.identity);
            }
            this.gameObject.SetActive(false);
        }


    }
}
