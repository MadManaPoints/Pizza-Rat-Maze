using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class Chase : MonoBehaviour
{
    NavMeshAgent agent;
    Rigidbody snakeRb; 
    [SerializeField] Transform player;
    [SerializeField] GameObject playerLocation; 
    [SerializeField] float speed; 
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        snakeRb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        agent.transform.LookAt(player);

        //Vector3 direction = (player.transform.position - transform.position).normalized;
        //Vector3 move = direction * speed * Time.deltaTime;
        //oops, don't need this with NavMeshAgent 

        //move to palyer position 
        Vector3 playerTarget = player.transform.position; 
        //agent.SetDestination(playerTarget);
    }

    void GameOver(){
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
