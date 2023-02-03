using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallSpaceship : MonoBehaviour
{
  private GameObject player;
  private GameObject winnerSpaceShip;
  private Animation spaceshipAnimatation;

  private void Start()
  {
    player = GameObject.FindGameObjectWithTag("Player");
    winnerSpaceShip = GameObject.FindGameObjectWithTag("WinnerSpaceShip");
    spaceshipAnimatation = winnerSpaceShip.GetComponent<Animation>();
    spaceshipAnimatation.enabled = false;
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject == player)
    {
      spaceshipAnimatation.enabled = true;
      
    }
  }
  
}
