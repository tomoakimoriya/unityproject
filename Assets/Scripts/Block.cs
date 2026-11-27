using UnityEngine;
using TMPro;

public class Block : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject textui = GameObject.Find("Score");
        int score = int.Parse(textui.GetComponent<TextMeshProUGUI>().text);
        score += 100;
        textui.GetComponent<TextMeshProUGUI>().text = score.ToString();

        Destroy(this.gameObject);
    }
}
