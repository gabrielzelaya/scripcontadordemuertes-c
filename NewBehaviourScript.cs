using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GanasPuntos : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public Text ganaste;

    // Start is called before the first frame update
    void Start()
    {
        score = 0
        scoreText.text = "PUNTOS : " + score.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy"){
            Destroy(collision.gameObject);
            score +=10;
            scoreText.text = "PUNTOS : " + score.ToString();

            if (score >= 30)

                ganaste.text = "GANASTE";
                
        }

    }
}
/* 
⣠⠴⠒⢛⣋⣉⣉⣉⣉⣛⠓⠦⣤⣀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣠⠴⢚⡭⠖⠚⠉⠉⠁⠀⠀⠀⠀⠉⠉⠓⠲⢭⡓⢦⡀⠀⠀⠀
⠀⠀⠀⠀⣠⢞⡥⠚⠉⠀⠀⠀⠀ ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠳⡝⢦⠀
⠀⠀⠀⣰⣫⠞⡤⡀⠀⢀⠀⠀⠀⠀⡀⠀⡀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠘⣎⢧
⠀⠀⢰⣷⠇⠈⠛⣵⠄⠀⢁⡆⠀⢠⠇⠸⢼⡀⠾⠻⠢⡄⠀⠀⠀⠀⠀⠘⡾⡆
⠀⠀⡏⡼⠀⠀⣼⠏⠀⢠⣾⠀⢀⡞⣳⡀⠈⣧⠀⠀⠀⢹⡄⢀⡶⣛⣓⣦⢹⣷
⠀⢸⠁⡇⠀⣸⠁⠀⣠⢯⡇⢀⣾⣀⠀⢳⡄⢻⡄⠀⠀⠈⣿⣸⣸⠁⠀⢸⠈⢹
⠀⢸⠀⡇⢠⠇⢀⡜⢁⣟⡴⠋⠀⠉⠉⠓⠻⡜⡇⠀⢀⣖⡿⠿⠋⠀⠀⠋⠉⢻
⠀⢿⠀⣇⢸⡞⠁⢠⡾⠋⠀⠀⠀⠀⠀⠀⠀⢻⡇⠀⠸⣟⠁⠀⠀⡟⢦⠀⠀⣸
⠀⢸⠀⠹⡾⡯⠿⠦⡄⠀⠀⠀⢀⣤⣦⣄⡀⠀⣧⠀⠀⠈⡷⠆⠀⣇⠸⡆⢾⡷
⠀⢸⠀⠀⡇⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠃⣿⠀⠀⠸⣇⠀⢀⣿⠀⠹⣾⠃
⠀⢸⠀⠀⡇⣿⠀⠀⠘⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠀⠀⢸⣿⣿⠉⢸⠀⠀⢙⠀
⠀⠈⡇⠀⢧⢻⡀⠀⠀⣀⠀⠀⠀⣀⠀⠀⠀⠀⣿⠀⠀⢸⠉⢸⠀⠈⡇⠀⠀⢧
⠀⠀⢹⠀⢸⠈⢷⣄⠀⠈⠃⠘⠉⠁⠀⠀⠀⣠⣿⠀⠀⡏⠀⠘⡀⠀⢿⠀⠀⠈
⠀⠀⠀⢇⠀⢇⠀⠙⠳⣤⡀⠀⢀⣠⡤⢖⣋⡥⡇⠀⣸⠀⠀⠀⣇⠀⢹⡇⠀⠀
⠀⠀⠀⠈⢇⠘⣄⠀⠀⠀⠉⢩⢿⣷⣿⡉⠀⢸⠇⢸⠟⢳⠤⠤⠼⣄⡘⣿⡀⠀
⠀⠀⠀⠀⠈⣧⡙⣴⠋⠉⠉⣻⣾⣇⣿⣧⠀⣼⣰⠃⣰⠋⢀⡤⠖⠂⠈⢳⣧⠀
⠀⠀⠀⢠⡞⣫⠽⢿⣇⡴⡏⢻⣿⣿⣟⣟⣿⡷⠃⣰⠃⡴⠋⠀⠀⠀⠀⠀⣿⢧
⠀⠀⠀⢸⡇⠐⠚⠡⣿⢧⠁⠀⠛⢻⠄⡏⠞⠀⢰⢇⡞⠁⠀⠀⢀⠤⡀⠀⣿⠘
⠀⠀⠀⣸⡇⠀⠀⢸⡏⠈⠀⠀⠀⢸⣶⠛⢦⠴⣻⡞⣀⣀⣰⠮⠶⠚⠁⠀⣿⡄
⠀⢀⡏⡿⢧⡀⠀⠀⣧⠀⠀⢀⣠⠞⣿⣤⠞⢰⠋⠉⠁⠀⠀⠀⢀⣤⠀⢸⡏⢧
⠀⢸⠁⠙⢦⣙⠦⠼⣿⡖⠚⣉⣠⠖⠁⠸⡄⡿⠀⠀⠀⠀⠠⠚⠉⠀⠀⡞⡇⢸ Easter egg
⠀⡟⠀⠀⠀⠎⡍⠉⢹⢿⡏⠁⠀⠀⠀⠀⢹⡅⠀⠀⠀⠀⠀⠀⠀⠀⡼⢡⣷⠀
⡼⠃⠀⠀⠀⠆⡇⢀⠟⡆⠀⠀⠀⠀⠀⠀⠀⢷⠀⠀⠀⠀⠀⠀⠀⣸⠁⢸⢻⠀
⠁⠀⠀⠀⠀⠀⠁⡾⠀⢹⡘⠃⠀⠀⠀⠀⠀⠈⢣⢤⡀⠀⠀⠀⢠⠇⠀⢸⢸⡆
⠀⠀⠀⠀⠀⠀⢾⡇⠀⠀⢳⡀⠀⠀⠀⠀⠀⠀⠀⢧⠙⠆⠀⢠⠏⠀⠀⡟⠀⡇
⠀⠀⠀⠀⠀⠀⢸⠁⠀⠀⠀⢷⠀⠀⠀⠀⠀⠀⠀⠈⠁⠀⢠⠏⠀⠀⠀⡇⠀⡇

*/