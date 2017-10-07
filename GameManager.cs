# Unity_NGUI
something about NGUI
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager:MonoBehaviour{
  public void OnStartGame(int index){
      Application.LoadLevel(index);//窗口的可见与否
  }


}
