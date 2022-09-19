using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class GameHandler : MonoBehaviour
{
    public GameObject p2healthGO;
    public int p2hp =100;
    // Start is called before the first frame update
    public static float gameDuration = 100f;
    public GameObject timerGO;
    public GameObject videoplayerGO;
    public VideoClip vc1;
     public VideoClip vc2;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        videoplayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc2;
        StartCoroutine(delayedHelloWorld());
    }

    // Update is called once per frame
    void Update()
    {
        //timerGO.gameObject.GetComponent <TMPro.TextMeshProUGUI>().text = gameDuration + "";
        Debug.Log(gameDuration + "");
    }

    void FixedUpdate(){
        gameDuration -= Time.deltaTime;
    }
    
    public void NextScene(){
        SceneManager.LoadScene(1);
    }

    IEnumerator delayedHelloWorld(){
        yield return new WaitForSeconds(5f);
        Debug.Log("delayed message");
    }
}
