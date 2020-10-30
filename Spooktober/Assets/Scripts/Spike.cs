using Bolt;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public GameObject Ded;
    public GameObject player;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        player.GetComponent<FlowMachine>().enabled = false;
        Ded.SetActive(true);
        Debug.Log("ded");
    }
}
