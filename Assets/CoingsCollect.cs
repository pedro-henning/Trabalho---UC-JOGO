using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoingsCollect : MonoBehaviour
{
   public Coins coinmanager;
private void OnTriggerEnter2D(Collider2D collision)
{
coinmanager.coins += 1;
Destroy(this.gameObject);
}

}
