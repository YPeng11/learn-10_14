using UnityEngine;
using UnityEngine.Playables; // 引入Playables命名空间

public class BirdController : MonoBehaviour
{
    public PlayableDirector playableDirector; // PlayableDirector类型的变量

    void OnMouseDown()
    {
        if (playableDirector != null)
        {
            playableDirector.Play(); // 点击时播放Timeline
        }
    }
}
