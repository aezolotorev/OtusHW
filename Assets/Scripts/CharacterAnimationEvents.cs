using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEvents : MonoBehaviour
{
    Character character;
    void Start()
    {
        character = GetComponentInParent<Character>();
    }

    void ShootEnd()
    {
        character.SetState(Character.State.Idle);
    }

    void AttackEnd()
    {
        character.SetState(Character.State.RunningFromEnemy);
    }

    void GiveDamage()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray,  out hit))
        {            
            GameObject hitobject = hit.transform.gameObject;
            Debug.Log(hitobject.name);
            if (hitobject.GetComponentInParent<Character>())
            {
                Debug.Log("2");
                hitobject.GetComponentInParent<Character>().SetState(Character.State.Die);
            }
        } 

    }
  
    


   
}
