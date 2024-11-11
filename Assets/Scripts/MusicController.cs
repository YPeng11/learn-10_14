using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource audioSource; // 用于播放音频
    public Button pauseButton;       // 用于暂停的按钮
    public Sprite playSprite;        // 播放图标
    public Sprite pauseSprite;       // 暂停图标

    void Start()
    {
        // 自动播放音频
        audioSource.Play();

        // 设置按钮的点击事件
        pauseButton.onClick.AddListener(TogglePause);
        
        // 设置按钮的初始图像为播放图标
        pauseButton.GetComponent<Image>().sprite = playSprite; 
    }

    void TogglePause()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause(); // 暂停音频
            pauseButton.GetComponent<Image>().sprite = pauseSprite; // 切换到暂停图标
        }
        else
        {
            audioSource.UnPause(); // 继续播放音频
            pauseButton.GetComponent<Image>().sprite = playSprite; // 切换回播放图标
        }
    }
}
