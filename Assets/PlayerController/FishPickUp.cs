using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FishPickUp : MonoBehaviour
{
    public GameObject player;

    public TextMeshProUGUI FishText;
    // Update is called once per frame
    void Update()
    {
        //Could've added this to an event, but this feels more consistent   
        inRange();
    }
    private void inRange()
    {
        //Triggers wouldn't work so I did this instead

        //Getting the distance between my player and my fish
        Vector3 distance = player.transform.position - gameObject.transform.position;
        //If my player is within distance, add my hold method into interact event 
        if (distance.magnitude <= .5f)
        {        
            PlayerInputActions.InteractEvent += HoldItem;
        }
        //If my player isn't within distance, tale away my hold method from interact event 
        else
        {
            PlayerInputActions.InteractEvent -= HoldItem;
        }
    }
    private void OnDestroy()
    {
        gameObject.SetActive(false);
    }
    void DropItem()
    {
        //Updaing my text when item drops
        FishText.text = "Well now the fish is dirty";
        //Moving my fish to the player position
        gameObject.transform.position = player.transform.position;
        //A fish will appear 
        gameObject.SetActive(true);
    }
    void HoldItem()
    {
        //Updaing my text when item is picked up
        FishText.text = "Keep a hold on that fish";
        //Hiding my fish from the player 
        gameObject.SetActive(false);
        //Had a bug that let players pickup from a far, this fixed it...
        PlayerInputActions.InteractEvent -= HoldItem;
    }
    private void OnEnable()
    {
        //Taking away my drop method on drop event
        PlayerInputActions.DropEvent -= DropItem;
    }
    private void OnDisable()
    {
        //Adding my drop method to drop event when game object is disable 
        PlayerInputActions.DropEvent += DropItem;
    }
}
