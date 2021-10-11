using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_die_when_hit : MonoBehaviour {

    //How much does this score
    public int in_this_will_score = 100;
    //public string st_hit_by_tag_to_score = "Player";
    private PT_asteroids_game_manager mb_gamemanager;

    public string st_no_effect_tag = "Asteroid";

    void Start()
    {
        mb_gamemanager = GameObject.Find("Asteroids Game_Manager").GetComponent<PT_asteroids_game_manager>();
    }
    // ----------------------------------------------------------------------
    // Has this object collided with another 2D object?
    void OnCollisionEnter2D(Collision2D _cl_detected)
    {
        
        // when hit, loop through the array of objects spawning each one at this location
        if (_cl_detected.gameObject.tag != st_no_effect_tag)
        {
            Destroy(gameObject);
            mb_gamemanager.in_score = mb_gamemanager.in_score + in_this_will_score;
            
        }
    }//-----

}
