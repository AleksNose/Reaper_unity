using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject[] allFormsHuman;
    public CharacterController controller;
    private PlayerInteraction playerInteraction;
    private PlayerAction cotrolPlayer;

    private Vector3 move;
    private bool isReaper;
    private float speed;

    void Start(){
        speed = 7f;
        isReaper = true;
        playerInteraction = new PlayerInteraction(player);
        this.GetComponent<SpriteRenderer>().material.color = Color.black;
    }

    private void Awake() {
        cotrolPlayer = new PlayerAction();
    }

    private void OnEnable() {
        cotrolPlayer.Enable();
    }

    private void onDisable() {
        cotrolPlayer.Disable();
    }

    private void Update() {

        MovingPlayer();
        playerInteraction.FindHumansInRangePlayer();
        if(cotrolPlayer.Interact.ChangeCharacter.triggered){
            ChangeCharacterPlayer();
        }

        if(cotrolPlayer.Interact.KillPerson.triggered && playerInteraction.humanTheClosestPlayer != null){
            GameObject humanInteract = playerInteraction.humanTheClosestPlayer;
            Instantiate(allFormsHuman[0], humanInteract.transform.position, humanInteract.transform.rotation);
            Instantiate(allFormsHuman[1], humanInteract.transform.position, humanInteract.transform.rotation);
            Destroy(humanInteract);
        }

    }

    private void MovingPlayer(){
        float x = cotrolPlayer.Land.Horizontal.ReadValue<float>();
        float y = cotrolPlayer.Land.Vertical.ReadValue<float>();

        move = transform.right * x + transform.up * y;

        controller.Move(move * speed * Time.deltaTime);
    }

    private void ChangeCharacterPlayer() {
        if (isReaper) {
            isReaper = false;
            this.GetComponent<SpriteRenderer>().material.color = new Color(0.7075472f, 0.7075472f, 0.7075472f, 1f);
            speed = 10f;
        }
        else {
            isReaper = true;
            this.GetComponent<SpriteRenderer>().material.color = Color.black;
            speed = 7f;
        }
    }
}
