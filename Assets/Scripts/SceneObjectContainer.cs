using UnityEngine;
using UnityEngine.UI;
public static class SceneObjectContainer
{
    private static float _playerScore = 0;
    private static GameObject _player;
    private static GameObject _startText;
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
    public static GameObject StartText 
    {
        get 
        {
            if(_startText == null){
                _startText = GameObject.Find("StartText");
            }
            return _startText;
        }
    }
    private static Text ScoreBar 
    {
        get 
        {
            if(_scoreBar == null){
                _scoreBar = GameObject.Find("ScoreBar").GetComponent<Text>();
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
    public static void OnSceneReload(){
        ScoreBar.text = "0";
        _playerScore = 0;
    }
    
}
