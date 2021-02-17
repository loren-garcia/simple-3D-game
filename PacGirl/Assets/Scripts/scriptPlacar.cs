using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptPlacar : MonoBehaviour {
    
    public Text placar;
    private int countFlowers = 0;

    private void Update() {
        placar.text = "Flores: " + countFlowers.ToString();

        if(countFlowers == 50) { // Coletou todas as flores
            SceneManager.LoadScene("Menu");
        }
    }

    private void OnTriggerEnter(Collider col) {
        
        if(col.CompareTag("flower")) {
            
            countFlowers += 1;
            Destroy(col.gameObject);
        }
    }
}
