using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    GameObject[] humans;
    GameObject player;
    public GameObject humanTheClosestPlayer;

    public PlayerInteraction(GameObject newPlayer) {
        player = newPlayer;
    }

    public void FindHumansInRangePlayer() {
        humans = null;
        humans = GameObject.FindGameObjectsWithTag("human");

        if(humans != null) {
            humanTheClosestPlayer = humans[0];
            for(int i = 1; i < humans.Length; i++) {
                
                if(LenHumanFromPlayer(humanTheClosestPlayer) > LenHumanFromPlayer(humans[i]) && LenHumanFromPlayer(humans[i]) < 1.2){
                    humanTheClosestPlayer = humans[i];
                }
            }

            if(humanTheClosestPlayer == humans[0] && LenHumanFromPlayer(humans[0]) > 1.2){
                humanTheClosestPlayer = null;
            }

        }
        Debug.Log(humanTheClosestPlayer);
    }

    private float LenHumanFromPlayer(GameObject person){
        float[] playerPosition2D = {player.transform.position.x, player.transform.position.y};
        float[] personPosition2D = {person.transform.position.x, person.transform.position.y};

        return Mathf.Sqrt(Mathf.Pow(playerPosition2D[0] - personPosition2D[0], 2) + Mathf.Pow(playerPosition2D[1] - personPosition2D[1], 2));
    }
}
