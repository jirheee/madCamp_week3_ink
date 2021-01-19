using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Gameplay;
using Platformer.Model;
using Platformer.Core;

public class Bullet : MonoBehaviour
{
    Transform playerTransform;
    float deltaX = -3f;
    float xPosition;
    float yPosition;
    GameObject bullet;
    PlatformerModel model = Simulation.GetModel<PlatformerModel>();
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        xPosition = transform.position.x;
        yPosition = transform.position.y;
        
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 22.5f) 
        {
            xPosition += deltaX * Time.deltaTime;
            transform.position = new Vector3(xPosition, yPosition, 0);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("line"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            var player = model.player;
            if (player.health.IsAlive)
            {
                player.health.Die();
                model.virtualCamera.m_Follow = null;
                model.virtualCamera.m_LookAt = null;
                // player.collider.enabled = false;
                player.controlEnabled = false;

                if (player.audioSource && player.ouchAudio)
                    player.audioSource.PlayOneShot(player.ouchAudio);
                player.animator.SetTrigger("hurt");
                player.animator.SetBool("dead", true);
                Simulation.Schedule<PlayerSpawn>(2);
            }
        }
        Destroy(gameObject);
    }
}