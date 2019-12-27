using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CaptionSpeed : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_tmPro;
    [SerializeField] private float m_stockInterval; //表示間隔

    private string m_textData = "Good-morning, everyone!";
    private char[] m_char;  //表示する文字列をchar配列に変換

    private int m_textLength;   //文字列の長さ

    private int m_currCount = 0;    //現在の文字の場所

    private void Start()
    {
        m_textLength = m_textData.Length;
        m_char = m_textData.ToCharArray();
        m_tmPro.text = "";  //テキストの初期化
    }

    public void DisplayText()
    {
        StartCoroutine(StockCharacter());
    }

    public IEnumerator StockCharacter()
    {
        while (m_currCount < m_textLength)
        {
            m_tmPro.text += m_char[m_currCount];
            yield return new WaitForSeconds(m_stockInterval);
            m_currCount++;
        }
    }
}
