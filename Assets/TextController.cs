using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {party_0, bar_0, date_0, coat_room_0, party_1, bar_1, coat_room_1, date_1, date_2, bar_2, outside, trapped, freedom_0, freedom_1};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.party_0;
	}
	
	// Update is called once per frame
	void Update () {
		if 		(myState == States.party_0) 	{party_0();} 
		else if (myState == States.bar_0)		{bar_0();} 
		else if (myState == States.coat_room_0) {coat_room_0();} 
		else if (myState == States.date_0) 		{date_0();} 
		else if (myState == States.party_1) 	{party_1();} 
		else if (myState == States.bar_1) 		{bar_1(); } 
		else if (myState == States.coat_room_1) {coat_room_1();} 
		else if (myState == States.date_1) 		{date_1();} 
		else if (myState == States.date_2) 		{date_2();} 
		else if (myState == States.bar_2) 		{bar_2();} 
		else if (myState == States.trapped) 	{trapped();} 
		else if (myState == States.outside) 	{outside();} 
		else if (myState == States.freedom_0) 	{freedom_0();} 
		else if (myState == States.freedom_1) 	{freedom_1();}
	}
	
	void party_0 () {
		text.text = "You are at a boring party with a date and really want to leave. You hope you and your date " + 
					"can leave the party without it being awkward. " + 
					"Before you can leave you have to settle your bar tab and get your " + 
					"coat from coat check.  \n\n" + 
					"Press B to settle your tab at the bar. \n" + 
					"Press D to tell your date you are ready to go. \n" + 
					"Press C to get your coats from coat check. ";	
		
		if 		(Input.GetKeyDown(KeyCode.B)) {myState = States.bar_0;} 
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.coat_room_0;} 
		else if (Input.GetKeyDown(KeyCode.D)) {myState = States.date_0;}
	}

	void bar_0 () {
		text.text = "The bartender hands you your bill. " + 
					"$13 bucks for a vodka tonic! These city prices are fucking absurd. " + 
					"Unfortunately, you still gotta pay up, but you left your wallet in your jacket pocket.  \n\n" + 
					"Press P to return to the Party";	
		
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.party_0;}
	}
	
	void coat_room_0 () {
		text.text = "An apathetic hipster asks you for your ticket. " + 
					"You realize you gave your tickets to your date to hold. \n\n" + 
					"Press P to Return to return to the Party.";
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.party_0;}
	}
	
	void date_0 () {
		text.text = "You walk up behind your date who is in the middle of a conversation. " + 
					"As politely as you can you whisper in her ear that you are ready to leave. " + 
					"She smiles, thanks you for saving her from that conversation and says she is to. \n" +
					"\'I feel bad leaving, but I can't be here anymore\' - She says \n" +  
					"\'Hopefully we can get out before anyone notices\' - You say back \n\n" +
					"Press G to Get your coat check tickets from your date.";
					
		if (Input.GetKeyDown(KeyCode.G)) {myState = States.party_1;} 
	}
	
	void party_1 () {
		text.text = "You have your coat check tickets now, But you still need to settle your tab before you can leave. \n\n" +
					"Press C to go to Coat check and get your coats. \n" +
					"Press B to go to the Bar and settle your tab.";
		
		if 		(Input.GetKeyDown(KeyCode.B)) {myState = States.bar_1;} 
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.coat_room_1;}
	}
	
	void bar_1 () {
		text.text = "Still don't have your wallet. That whiskey must be kicking in. \n\n" +
					"Press B to go back.";
		
		if (Input.GetKeyDown(KeyCode.B)) {myState = States.party_1;}
	}
	
	void coat_room_1 () {
		text.text = "The apethetic hipster looks up from his magazine. You give him your ticket this time and get your coats. \n\n" +
			"Press D to go back to your date and give her her coat. \n" + 
			"Press B to settle your tab at the bar.";
		
		if 		(Input.GetKeyDown(KeyCode.D)) {myState = States.date_1;} 
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.bar_2;}
	}
	
	void date_1 () {
		text.text = "Your date has been cornered into a conversation and the host is standing nearby. You have both of your jackets and you have your phone. \n\n" +  
					"Press B to settle your bar tab.\n" + 
					"Press G to Give your date her coat. \n" + 
					"Press L to leave the bar."; 

		if 		(Input.GetKeyDown(KeyCode.B)) {myState = States.bar_2;} 
		else if (Input.GetKeyDown(KeyCode.G)) {myState = States.trapped;} 
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.outside;}
	}
	
	void date_2 () {
		text.text = "Your date has been cornered into a conversation and the host is standing nearby. You have both of your jackets and you have your phone. \n\n" +  
					"Press G to Give your date her coat. \n" + 
					"Press L to leave the bar."; 
		
		if 		(Input.GetKeyDown(KeyCode.G)) {myState = States.trapped;} 
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.outside;}
	}
	
	void bar_2 () {
		text.text = "The bar is really crowded now. It takes a while, but you finally settle your tab. \n\n" +
					"Press B to go back to your date";
		
		if (Input.GetKeyDown(KeyCode.B)) {myState = States.date_2;}			
	}
	
	void trapped () {
		text.text = "Oh no! The host saw you from the corner of her eye and runs over to ask you not to leave yet. \n\n" + 
					"You are trapped and you guys are not ever leaving this party. Nice try though..." + 
					"\n\n Press P to Play again.";

		if (Input.GetKeyDown(KeyCode.P)) {myState = States.party_0;}
	}
	
	void outside () {
		text.text = "It's so cold outside! \n\n" + 
					"Press T to text your date to tell her you have her coat and she can meet you outside. \n" +
					"Press L to leave.";
					
		if 		(Input.GetKeyDown(KeyCode.T)) {myState = States.freedom_0;} 
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.freedom_1;}
	}
	
	void freedom_0 () {
		text.text = "She texts back that she is on her way. She is going to act like she is headed to the bathroom but then head outside to meet you. " +
					"This is going to take a minute, but you are happy you guys are gonna leave soon. All of this probably would have been easier by, I dunno.. " + 
					"making up an excuse that your dog was sick and you had to run home...or simply saying goodbye." + 
					"\n\n Press P to Play again.";
					
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.party_0;}
	}
	
	void freedom_1() {
		text.text = "Really? It was too cold to wait for your date so you just leave her there with no coat? How do you feel about yourself right now." + 
					"\n\n Press P to Play again.";

		if (Input.GetKeyDown(KeyCode.P)) {myState = States.party_0;}
	}
}
