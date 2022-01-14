using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnProjecttileController : MonoBehaviour
{
    public GameObject BulletPrefab;

    public int bullet_amount = 100;
    public TextMeshProUGUI bullet_value_textholder;

    public GameObject gameOver_panel;
    public TextMeshProUGUI sorry_out_of_textHolder;
    string sorry_out_of_message = "Sorry, you out of bullets.";

    public GameObject game_panel;
    
    void Update()
    {
        bullet_value_textholder.text = bullet_amount.ToString();
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, this.transform.position, transform.rotation, transform);
        bullet_amount--;

        if (bullet_amount == 0)
        {
            Time.timeScale = 0;
            sorry_out_of_textHolder.text = sorry_out_of_message;
            gameOver_panel.SetActive(true);
            game_panel.SetActive(false);
        }

        Destroy(bullet, 1.5f);
    }
}
