using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;//引入命名空间

public class SpeechKey : MonoBehaviour
{

    public GameObject m_player;

    private Player player;

    // 短语识别器
    private KeywordRecognizer m_PhraseRecognizer;

    // 关键字
    public string[] keywords;

    // 可信度
    public ConfidenceLevel m_confidenceLevel = ConfidenceLevel.Medium;


    void Start()
    {
        player = m_player.GetComponent<Player>();
        //创建一个识别器
        m_PhraseRecognizer = new KeywordRecognizer(keywords, m_confidenceLevel);
        //通过注册监听的方法
        m_PhraseRecognizer.OnPhraseRecognized += M_PhraseRecognizer_OnPhraseRecognized;
        //开启识别器
        m_PhraseRecognizer.Start();
    }

    // 当识别到关键字时，会调用这个方法
    private void M_PhraseRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        if(args.text=="站立")
        {
            player.Idle();
        }
        if (args.text == "攻击")
        {
            player.Attack();
        }
        if (args.text == "移动")
        {
            player.Move();
        }


    }
    private void OnDestroy()
    {
        //用完释放
        m_PhraseRecognizer.Dispose();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
