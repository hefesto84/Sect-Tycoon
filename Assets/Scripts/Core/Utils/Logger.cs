using UnityEngine;
using System.Collections;

public class Logger {

	private static Logger _instance = null;

	private Logger(){

	}

	public static Logger getInstance(){
		if (_instance == null) {
			_instance = new Logger ();
		}
		return _instance;
	}

	public void log(string str){
		if(isEnabled())
			Debug.Log (str);
	}

	public void error(string str){
		if(isEnabled())
			Debug.LogError (str);
	}

	public void warning(string str){
		if(isEnabled())
			Debug.LogWarning (str);
	}

	private bool isEnabled(){
		return Constants.C_ENABLE_LOGGING;
	}
}
