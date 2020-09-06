using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class touchscript : MonoBehaviour
{
    bool gDraw = false;
    public Vector3 touchpos;
    string boxContent;

    public Object animal;

    public Text scoreDisplayText;
    public Text QuestionDisplayText;
    public Text timeRemainingDisplayText;


    private float timeRemaining;
    private bool isRoundActive;
    private int playerScore;
    private int questionIndex;

    public string[] questionArrary;
    // Start is called before the first frame update
    void Start()
    {
        questionIndex = 0;
        playerScore = 0;
        timeRemaining = 120;

        questionArrary[0] ="HORSE";
        questionArrary[1] = "GOOSE";
        questionArrary[2] = "DOG";

       

        Update();
        
        ShowQuestion();
  
    }

    private void ShowQuestion()
    {
        QuestionDisplayText.text = questionArrary[questionIndex];
    }


    // Update is called once per frame
    void Update()
    {
       
        touchClick();
       
    }

    



    private void UpdateQuestionDisplay()
    {
        QuestionDisplayText.text = questionArrary[questionIndex];
    }
    public void EndRound()
    {
        
        SceneManager.LoadScene("GameFinished");
    }


    void touchClick()
    {
       if(Input.GetMouseButtonDown(0))
       {
            RaycastHit hit;
        
            Ray touchray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Physics.Raycast(touchray, out hit);

            if(hit.collider != null)
            {
                if(gDraw == false)
                {
                    gDraw = true;
                }
                else
                {
                    gDraw = false;
                }
                Debug.Log(hit.collider.gameObject.name);

                if (QuestionDisplayText.text.Equals(hit.collider.gameObject.name))
                {
                    playerScore += 10;
                    scoreDisplayText.text = "Score: " + playerScore.ToString();
                    questionIndex++;
                    

                    scoreDisplayText.text = questionArrary[questionIndex];
                    QuestionDisplayText.text = questionArrary[questionIndex];
                }

                if (questionIndex > questionArrary.Length)
                {
                    EndRound();
                }
                  
            }
       }
       if(Input.touchCount>=1)
       {
           touchpos=Input.GetTouch(0).position;
           boxContent = "위치\r\n"+touchpos;
       }


    }
}
