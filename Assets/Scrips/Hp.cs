using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Hp : MonoBehaviour
{
    public int health = 3;
    public Sprite[] hpImage;
    public Image hpBar;
    void Start()
    {
        hpBar.sprite = hpImage[health];
    }

    public void Damage(Vector3 enemyPosition)
    {
        health--;
        Vector3 impulse = transform.position - enemyPosition;
        transform.Translate(impulse * 1f);
        if (health <= 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        hpBar.sprite = hpImage[health];

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Luffy"))
            Damage(collider.gameObject.transform.position);
    }
}
