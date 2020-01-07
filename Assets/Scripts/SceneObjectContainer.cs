using UnityEngine;
using UnityEngine.UI;
public class SceneObjectContainer : MonoBehaviour
{
    private static float _playerScore = 0;
    private static GameObject _player;
    private static Text _scoreBar;
    public static GameObject Player 
    {
        get 
        {
            if(_player == null){
                _player = GameObject.Find("Player");
            }
            return _player;
        }
    }
    private static Text ScoreBar 
    {
        get 
        {
            if(_scoreBar == null){
                _scoreBar = GameObject.Find("Player").GetComponent<Text>();
            }
            return _scoreBar;
        }
    }
    public static float PlayerScore
    {
        set
        {
            _playerScore += value;
            ScoreBar.text = _playerScore.ToString();
        }
    }
    
}
