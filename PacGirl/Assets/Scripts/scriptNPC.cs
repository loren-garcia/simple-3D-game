using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptNPC : MonoBehaviour {

    public GameObject pc;
    UnityEngine.AI.NavMeshAgent npc;

    
    void Start () {

        npc = GetComponent<UnityEngine.AI.NavMeshAgent>();
        
        if (pc == null) {
            pc = GameObject.FindGameObjectWithTag("PC");
        }
    }
   
    void Update () {
        
        npc.destination = pc.transform.position;
    }

    
    public void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.tag == "PC") {
            SceneManager.LoadScene("Menu");
        }
    }
}
