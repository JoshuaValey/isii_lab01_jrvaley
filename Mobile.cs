using System;

public class Mobile: Singleton, Transient, Scope
{
	/*
		onCreate 1
		onStart 2
		onRestart 3
		onResume 4
		onPause 5
		onStop 6
		onDestroy 7
	 */
	public readonly string appState;

	public Mobile()
	{
		var stateValue = new Random().Next(0, 7);
		string state = "";
		switch (stateValue)
		{
			case 1:
				state = "OnCreate";
			break;
			case 2:
				state = "OnStart";
				break;
			case 3:
				state = "OnRestart";
			break ;
				case 4:
				state = "OnResume";
				break;
			case 5:
				state = "onPause";
				break;
			case 6:
				state = "onStope";
				break;
			case 7:
				state = "onDestroy";
				break;
			default:
				state = "errorAndroid";
			break;
        }



		appState = state;
	}
}
