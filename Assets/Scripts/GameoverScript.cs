using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverScript : MonoBehaviour {
    public GameObject objToDestroy;
    public GameObject platform;
    [SerializeField]
    private GameObject gameOverUI;

    
    public void EndGame()
    {
        Debug.Log("gameoverBG");
         gameOverUI.SetActive(true);
       
        

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.relativeVelocity.y <= 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                SoundManagerScript.PlaySound("Bounce Sound Effect");
                Destroy(objToDestroy);
                Destroy(platform);
                EndGame();
              

            }


}
        }




}