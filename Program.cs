using System;

namespace Eureka
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// setting up game loop
			bool gameisrunning = true;
			string start = "0";

			// main menu

			while (start != "1") { 
				Console.Clear ();
				Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~EUREKA~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~A Lucas Kanabe game~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~1) Start a New Game~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~2) Quit~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				start = Console.ReadLine ();
				if (start == "1") {
					Console.Clear ();
				} else if (start == "2") {
					Environment.Exit (0);
				}
			}

			// game loop

			while (gameisrunning == true) { 
				string answer1 = "0";
				string answer2 = "0";
				string answer3 = "0";
				string answer4 = "0";
				string answer5 = "0";
				string answer6 = "0";
				string answer7 = "0";
				string answer8 = "0";
				string answer9 = "0";
				string answer10 = "0";
				Player player1 = new Player ();
				Mugger mugger1 = new Mugger ();
				Random rng = new Random ();
				string gender = "0";
				while (gender != "1" && gender != "2") {
					Console.Clear ();
					Console.WriteLine ("You find yourself without memory and without purpose.");
					Console.WriteLine ("You are without form, ethereal, but feel the desire to continue your existence.");
					Console.WriteLine ("There are two corpses, fresh but without life. One a woman, one a man.");
					Console.WriteLine ("You are drawn to one. Which do you chose?");
					Console.WriteLine ("");
					Console.WriteLine ("1) Male");
					Console.WriteLine ("2) Female");
					Console.WriteLine ("");
					gender = Console.ReadLine ();
				}

				// chosing gender and setting into player1 using method ChosenSex

				if (gender == "1") {
					Console.Clear ();
					Console.WriteLine ("Your form begins to change, you look down into a puddle and see a face.");
					Console.WriteLine ("You speak and the voice you hear is deep, but unrecognizable.");
					player1.ChosenSex ("Male");
				} else if (gender == "2") {
					Console.Clear ();
					Console.WriteLine ("Your form begins to change, you look down into a puddle and see a face.");
					Console.WriteLine ("You speak and the voice you hear is feminine, but unrecognizable.");
					player1.ChosenSex ("Female");
				}

				// regular text follows

				Console.WriteLine ("");
				Console.WriteLine ("Press any key to continue");
				Console.WriteLine ("");
				Console.ReadKey ();
				Console.Clear ();
				Console.WriteLine ("You hear a voice in the distance.");
				Console.WriteLine ("");
				Console.WriteLine ("Next");
				Console.WriteLine ("");
				Console.ReadKey ();
				Console.Clear ();
				Console.WriteLine ("'...Hello?'");
				Console.WriteLine ("");
				Console.WriteLine ("Next");
				Console.WriteLine ("");
				Console.ReadKey ();
				Console.Clear ();
				Console.WriteLine ("'Hello? Is anyone there?'");
				Console.WriteLine ("");
				Console.WriteLine ("Next");
				Console.WriteLine ("");
				Console.ReadKey ();

				// forcing  response of the proper options

				while (answer1 != "1" && answer1 != "2") {
					Console.Clear ();
					Console.WriteLine ("'Please say something! Anybody...'");
					Console.WriteLine ("");
					Console.WriteLine ("1) 'I'm here, what's wrong?'");
					Console.WriteLine ("2) Don't Respond");
					Console.WriteLine ("");
					answer1 = Console.ReadLine ();
				}
				if (answer1 == "1" && player1.Sex == "Male") {
					while (answer2 != "1") {
						Console.Clear ();
						Console.WriteLine ("You: 'I'm here, what's wrong?'");
						Console.WriteLine ("");
						Console.WriteLine ("'Oh thank god there's someone else here.'");
						Console.WriteLine ("'I'm lost and have no idea how I got here, what's your name mister?'");
						Console.WriteLine ("");
						Console.WriteLine ("Enter your name:");
						Console.WriteLine ("");
						player1.Name = Console.ReadLine ();
						Console.Clear ();
						Console.WriteLine ("Your name will be {0}, is that correct?", player1.Name);
						Console.WriteLine ("");
						Console.WriteLine ("1) Yes");
						Console.WriteLine ("Enter) No");
						Console.WriteLine ("");
						answer2 = Console.ReadLine (); 
					}
					Console.Clear ();
					Console.WriteLine ("You: '{0}'", player1.Name);
					Console.WriteLine ("");
					Console.WriteLine ("'Okay...{0}.'", player1.Name);
					Console.WriteLine ("Jessica: 'My names Jessica, if you're wondering.'");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
				} else if (answer1 == "1" && player1.Sex == "Female") {
					while (answer2 != "1") {
						Console.Clear ();
						Console.WriteLine ("You: 'I'm here, what's wrong?'");
						Console.WriteLine ("");
						Console.WriteLine ("'Oh thank god there's someone else here.'");
						Console.WriteLine ("'I'm lost and have no idea how I got here, what's your name mister?'");
						Console.WriteLine ("");
						Console.WriteLine ("Enter your name:");
						Console.WriteLine ("");
						player1.Name = Console.ReadLine ();
						Console.Clear ();
						Console.WriteLine ("Your name will be {0}, is that correct?", player1.Name);
						Console.WriteLine ("");
						Console.WriteLine ("1) Yes");
						Console.WriteLine ("Enter) No");
						Console.WriteLine ("");
						answer2 = Console.ReadLine ();
					}
					Console.Clear ();
					Console.WriteLine ("You: '{0}'", player1.Name);
					Console.WriteLine ("");
					Console.WriteLine ("'Okay...{0}.'", player1.Name);
					Console.WriteLine ("Jessica: 'My names Jessica, if you're wondering.'");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
				} else if (answer1 != "1") {
					while (answer1 != "1") {
						Console.Clear ();
						Console.WriteLine ("You're existence forces you to respond, there's something special about this person.");
						Console.WriteLine ("");
						Console.WriteLine ("1) 'I'm here, what's wrong?'");
						Console.WriteLine ("2) Resist the urge, even though it's pointless");
						Console.WriteLine ("");
						answer1 = Console.ReadLine ();
					}
					if (answer1 == "1" && player1.Sex == "Male") {
						while (answer2 != "1") {
							Console.Clear ();
							Console.WriteLine ("You: 'I'm here, what's wrong?'");
							Console.WriteLine ("");
							Console.WriteLine ("'Oh thank god there's someone else here.'");
							Console.WriteLine ("'I'm lost and have no idea how I got here, what's your name mister?'");
							Console.WriteLine ("");
							Console.WriteLine ("Enter your name:");
							Console.WriteLine ("");
							player1.Name = Console.ReadLine ();
							Console.Clear ();
							Console.WriteLine ("Your name will be {0}, is that correct?", player1.Name);
							Console.WriteLine ("");
							Console.WriteLine ("1) Yes");
							Console.WriteLine ("Enter) No");
							Console.WriteLine ("");
							answer2 = Console.ReadLine ();
						}
						Console.Clear ();
						Console.WriteLine ("You: '{0}'", player1.Name);
						Console.WriteLine ("");
						Console.WriteLine ("'Okay...{0}.'", player1.Name);
						Console.WriteLine ("Jessica: 'My names Jessica, if you're wondering.'");
						Console.WriteLine ("");
						Console.WriteLine ("Next");
						Console.WriteLine ("");
						Console.ReadKey ();


					} else if (answer1 == "1" && player1.Sex == "Female") {
						while (answer2 != "1") {
							Console.Clear ();
							Console.WriteLine ("You: 'I'm here, what's wrong?'");
							Console.WriteLine ("");
							Console.WriteLine ("'Oh thank god there's someone else here.'");
							Console.WriteLine ("'I'm lost and have no idea how I got here, what's your name miss?'");
							Console.WriteLine ("");
							Console.WriteLine ("Enter your name:");
							Console.WriteLine ("");
							player1.Name = Console.ReadLine ();
							Console.Clear ();
							Console.WriteLine ("Your name will be {0}, is that correct?", player1.Name);
							Console.WriteLine ("");
							Console.WriteLine ("1) Yes");
							Console.WriteLine ("Enter) No");
							Console.WriteLine ("");
							answer2 = Console.ReadLine ();
						}
						Console.Clear ();
						Console.WriteLine ("You: '{0}'", player1.Name);
						Console.WriteLine ("");
						Console.WriteLine ("'Okay...{0}.'", player1.Name);
						Console.WriteLine ("Jessica: 'My names Jessica, if you're wondering.'");
						Console.WriteLine ("");
						Console.WriteLine ("Next");
						Console.WriteLine ("");
						Console.ReadKey ();
					}
				}
				player1.gainLevel (1);
				player1.scoreIncrease (100);
				Console.Clear ();
				Console.WriteLine ("*You just gained a level!*");
				Console.WriteLine ("");
				Console.WriteLine ("*Your level is now {0}.*", player1.Level);
				Console.WriteLine ("*Your score is now {0}.*", player1.Score);
				Console.WriteLine ("");
				Console.WriteLine ("Next");
				Console.WriteLine ("");
				Console.ReadKey ();
				while (answer3 != "1" && answer3 != "2") {
					Console.Clear ();
					Console.WriteLine ("Jessica: 'So, {0}. Do you have any idea where we are?'", player1.Name);
					Console.WriteLine ("");
					Console.WriteLine ("1) 'I was hoping you knew the answer to that...'");
					Console.WriteLine ("2) 'All I see are trees and fog, could be a forest.'");
					Console.WriteLine ("");
					answer3 = Console.ReadLine ();
				}
				if (answer3 == "1") {
					Console.Clear ();
					Console.WriteLine ("You: 'I was hoping you knew the answer to that...'");
					Console.WriteLine ("");
					Console.WriteLine ("Jessica: 'I just woke up here. I don't remember how it happened.");
					Console.WriteLine ("'I thought maybe you were someone who could help, but I guess we're in the same boat then.");
					Console.WriteLine ("'Do you have anything on you that could help us find our way out? A cell phone? Anything?'");
				} else if (answer3 == "2") {
					Console.Clear ();
					Console.WriteLine ("You: 'All I see are trees and fog, could be a forest.'");
					Console.WriteLine ("");
					Console.WriteLine ("Jessica: 'Yeah I gathered that, but how did we get here?'");
					Console.WriteLine ("'There's been no signs of anybody around until you. We're totally lost.'");
					Console.WriteLine ("'Do you have anything on you that could help us find our way out? A cell phone? Anything?'");
				}
				Console.WriteLine ("");
				Console.WriteLine ("Next");
				Console.WriteLine ("");
				player1.foundLeatherGloves ();
				Console.ReadKey ();
				while (answer4 != "2") {
					Console.Clear ();
					Console.WriteLine ("You reach into your pockets but find nothing but a pair of leather gloves.");
					Console.WriteLine ("You put them on, and gain 2 health.");
					Console.WriteLine ("");
					Console.WriteLine ("1) Check your Health");
					Console.WriteLine ("2) 'Nothing useful, sorry.'");
					Console.WriteLine ("");
					answer4 = Console.ReadLine ();
					if (answer4 == "1") {
						Console.Clear ();
						Console.WriteLine ("You have {0} health.", player1.Health);
						Console.WriteLine ("");
						Console.WriteLine ("Press Enter to exit");
						Console.WriteLine ("");
						Console.ReadKey ();
					} 
				}
				while (answer5 != "1" && answer5 != "2") {
					Console.Clear ();
					Console.WriteLine ("You: 'Nothing useful, sorry.'");
					Console.WriteLine ("");
					Console.WriteLine ("Jessica: 'Damn, okay. You see the clearing over there? Feel like checking it out?'");
					Console.WriteLine ("");
					Console.WriteLine ("1) Seems promising, but let me check it out alone first.");
					Console.WriteLine ("2) Alright, let's go.");
					Console.WriteLine ("");
					answer5 = Console.ReadLine ();
				}
				if (answer5 == "1") {
					Console.Clear ();
					Console.WriteLine ("You: 'Seems promising, but let me check it out alone first.");
					Console.WriteLine ("");
					Console.WriteLine ("Jessica: 'Okay, I'll be waiting here. Doing nothing...'");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
					Console.Clear ();
					Console.WriteLine ("You start walking towards the clearing, but something stops you.");
					Console.WriteLine ("A flash. You hear someone yelling, crying, while overwhelming sadness swamps over you.");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
					Console.Clear ();
					Console.WriteLine ("Back in the forest, you look down at your hands. They're trembling uncontrollably.");
					Console.WriteLine ("You don't know what you saw, but it doesn't seem to be about you.");
					Console.WriteLine ("The clearing seems safe enough, so you head back to Jessica");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
					Console.Clear ();
					Console.WriteLine ("You: 'The clearing's all good, let's go.'");
					Console.WriteLine ("");
					Console.WriteLine ("Jessica: 'Took long enough.'");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
				} else if (answer5 == "2") { 
					Console.Clear ();
					Console.WriteLine ("You: 'Alright, let's go.'");
					Console.WriteLine ("");
					Console.WriteLine ("Jessica: 'After you.'");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
					Console.Clear ();
					Console.WriteLine ("You start walking towards the clearing, but something stops you.");
					Console.WriteLine ("A flash. You hear someone yelling, crying, while overwhelming sadness swamps over you.");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
					Console.Clear ();
					Console.WriteLine ("Back in the forest, you look down at your hands. They're trembling uncontrollably.");
					Console.WriteLine ("You don't know what you saw, but it doesn't seem to be about you.");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
					Console.Clear ();
					Console.WriteLine ("Jessica: 'Hey are you okay? You just dazed out there for a second.'");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
					Console.Clear ();
					Console.WriteLine ("You: 'Yeah, it was nothing. Just remembered I left the oven on back home.'");
					Console.WriteLine ("");
					if (player1.Sex == "Male") {
						Console.WriteLine ("Jessica: 'Alright then, funny guy.'");
					} else if (player1.Sex == "Female") {
						Console.WriteLine ("Jessica: 'Someone's sassy.'");
					}
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
				}
				while (answer6 != "1" && answer6 != "2") {
					Console.Clear ();
					Console.WriteLine ("Jessica: 'So you never told me how you got here.'");
					Console.WriteLine ("");
					Console.WriteLine ("1) Same as you, I don't know.");
					Console.WriteLine ("2) I'm looking for someone.");
					Console.WriteLine ("");
					answer6 = Console.ReadLine ();
				}
				if (answer6 == "1") {
					while (answer7 != "1") {
						Console.Clear ();
						Console.WriteLine ("You: 'Same as you, I don't know.'");
						Console.WriteLine ("");
						Console.WriteLine ("Jessica: 'I'm starting to think there's something wro-'");
						Console.WriteLine ("");
						Console.WriteLine ("From the corner of your eye you see a figure running up behind Jessica.");
						Console.WriteLine ("There's a reflection of light around his hand, there's only one option.");
						Console.WriteLine ("");
						Console.WriteLine ("1) Attack mugger");
						answer7 = Console.ReadLine ();
					}
				} else if (answer6 == "2") {
					while (answer7 != "1") {
						Console.Clear ();
						Console.WriteLine ("You: 'I'm looking for someone.'");
						Console.WriteLine ("");
						Console.WriteLine ("Jessica: 'Who would be here in thi-'");
						Console.WriteLine ("");
						Console.WriteLine ("From the corner of your eye you see a figure running up behind Jessica.");
						Console.WriteLine ("You see a reflection of light around his hand, there's only one option.");
						Console.WriteLine ("");
						Console.WriteLine ("1) Attack mugger");
						Console.WriteLine ("");
						answer7 = Console.ReadLine ();
					}
				}
				while (mugger1.muggerHealth > 0 && player1.Health > 0) {
					while (answer8 != "1" && answer8 != "2") {
						Console.Clear ();
						Console.WriteLine ("You have {0} health.", player1.Health);
						Console.WriteLine ("");
						Console.WriteLine ("The mugger has {0} health.", mugger1.muggerHealth);
						Console.WriteLine ("");
						Console.WriteLine ("1) Attack");
						Console.WriteLine ("2) Run Away");
						Console.WriteLine ("");
						answer8 = Console.ReadLine ();
					}
					if (answer8 == "1") {
						if (player1.attackPower == 1) {
							mugger1.muggerIsHit (rng.Next (1, 3));
							player1.takeDamage (mugger1.muggerAttack);
							Console.Clear ();
							Console.WriteLine ("You hit the mugger for {0} damage!", rng.Next (1, 3));
							Console.WriteLine ("");
							Console.WriteLine ("You are hit for {0} damage!", mugger1.muggerAttack);
							Console.WriteLine ("");
							Console.ReadKey ();
						} else if (player1.attackPower == 2) {
							mugger1.muggerIsHit (rng.Next (2, 4));
							player1.takeDamage (mugger1.muggerAttack);
							Console.Clear ();
							Console.WriteLine ("You hit the mugger for {0} damage!", rng.Next (2, 4));
							Console.WriteLine ("You are hit for {0} damage!", mugger1.muggerAttack);
							Console.WriteLine ("");
							Console.ReadKey ();
						}
					} else if (answer8 == "2") {
						Console.Clear ();
						Console.WriteLine ("You look at Jessica, she's frozen in place. You can't run away without her!");
						Console.WriteLine ("");
						Console.WriteLine ("Press Enter to go back into battle");
						Console.WriteLine ("");
						Console.ReadKey ();
					}
					answer8 = "0";
				}
				if (mugger1.muggerHealth <= 0) {
					Console.Clear ();
					player1.defeatMugger ();
					player1.foundKnife ();
					Console.WriteLine ("You kill the mugger, and take his knife.");
					Console.WriteLine ("");
					Console.WriteLine ("+100 score");
					Console.WriteLine ("");
					Console.WriteLine ("*You gained a level!*");
					Console.WriteLine ("");
					Console.WriteLine ("*You are now Level {0}*", player1.Level);
					Console.WriteLine ("");
					Console.WriteLine ("*Your score is now {0}*", player1.Score);
					Console.WriteLine ("");
					Console.ReadKey ();
				} else if (player1.Health <= 0) {
					gameisrunning = false;
				}
				while (answer9 != "1" && answer9 != "2") {
					Console.Clear ();
					Console.WriteLine ("Jessica: '...You just killed that man. He was going to kill me, but still.'");
					Console.WriteLine ("");
					Console.WriteLine ("1) I don't know how I did that.");
					Console.WriteLine ("2) I had to defend you, I'm sorry.");
					Console.WriteLine ("");
					answer9 = Console.ReadLine ();
				}
				if (answer9 == "1") {
					Console.Clear ();
					Console.WriteLine ("You: 'I don't know how I did that.'");
					Console.WriteLine ("");
					Console.WriteLine ("Jessica: 'What are you saying? You dodged his stabs like a professional and snapped his neck.'");
					Console.WriteLine ("'There's no way you didn't have some training for that. Anyway, it doesn't matter.'");
				} else if (answer9 == "2") {
					Console.Clear ();
					Console.WriteLine ("You: 'I had to defend you, I'm sorry.");
					Console.WriteLine ("");
					Console.WriteLine ("Jessica: 'Where did you learn to do that? Nevermind, doesn't matter.'");
				}

				Console.WriteLine ("'Let's just out of here. You've obviously got your own agenda I don't want anything to do with it.'");
				Console.WriteLine ("");
				Console.WriteLine ("Next");
				Console.WriteLine ("");
				Console.ReadKey ();
						




						
					




				


				gameisrunning = false;
				if (player1.Health <= 0) {
					Console.Clear ();
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Game Over~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Thanks for Playing!~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~A Lucas Kanabe Game~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				} else if (player1.Health > 0) {
					Console.Clear ();
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Fin~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Thanks for Playing!~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~A Lucas Kanabe Game~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				}
			}
		}
	}

}