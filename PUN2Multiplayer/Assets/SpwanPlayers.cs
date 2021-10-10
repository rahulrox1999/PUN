using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpwanPlayers : MonoBehaviour
{
    /* public GameObject policeCar;
     public GameObject OldCar;
     public GameObject RacingCar;

     */


    public GameObject Character;
    public float minX;
    public float maxX;

    public float minY;
    public float maxY;

    public float minZ;
    public float maxZ;


    public  void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));

        PhotonNetwork.Instantiate(Character.name, randomPosition, Quaternion.identity);

    }

    public void PoliceCar()
    {
        
    }
}
