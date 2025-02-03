using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Asteroid : MonoBehaviour
{
    int count = 0;
    private float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(0, 0, speed) * Time.deltaTime;
        if (transform.position.z < -5)
        {
            float randomX = Random.Range(-30f, 30f);//ランダムなｘ座標の範囲
            float randomY = Random.Range(-20f, 20f);//ランダムなｙ座標の範囲
            transform.position = new Vector3(randomX, randomY, 30f);//ランダムなx,y座標とｚ座標30に移動
            count++;//count=count+1
        }



        if (count > 10)
        {
            SceneManager.LoadScene("Clear");//クリアシーン移動
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("End");//Endシーン移動

        }
    }
}
