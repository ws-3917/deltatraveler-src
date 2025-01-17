using System.Collections.Generic;
using UnityEngine;

public static class Localizer
{
	private static readonly Dictionary<string, string> english = new Dictionary<string, string>
	{
		{ "phone_toriel_0_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_0_0_1", "tori_worry`snd_txttor`* Kris...?^10\n* Is something wrong?" },
		{ "phone_toriel_0_0_2", "tori_worry`snd_txttor`* You sound upset." },
		{ "phone_toriel_0_0_3", "tori_worry`snd_txttor`* Why don't you hurry\n  over to my home?" },
		{ "phone_toriel_0_0_4", "tori_worry`snd_txttor`* You can tell me\n  everything on your\n  mind when you come." },
		{ "phone_toriel_0_0_5", "* (Click...)" },
		{ "phone_toriel_7_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_7_0_1", "tori_worry`snd_txttor`* The bed of flowers?" },
		{ "phone_toriel_7_0_2", "tori_happy`snd_txttor`* I am so glad that\n  they were able to\n  cushion your fall." },
		{ "phone_toriel_7_0_3", "tori_neutral`snd_txttor`* I care for them from\n  time to time." },
		{ "phone_toriel_7_0_4", "tori_worry`snd_txttor`* I do wonder if they\n  are okay after you\n  two landed on them." },
		{ "phone_toriel_7_0_5", "* (Click...)" },
		{ "phone_toriel_8_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_8_0_1", "tori_worry`snd_txttor`* There was a flower\n  harrassing you two?" },
		{ "phone_toriel_8_0_2", "tori_worry`snd_txttor`* I am so terribly\n  sorry about that." },
		{ "phone_toriel_8_0_3", "tori_neutral`snd_txttor`* I may have seen that\n  flower around here from\n  time to time." },
		{ "phone_toriel_8_0_4", "tori_worry`snd_txttor`* I wonder what would\n  have made a flower so\n  rude." },
		{ "phone_toriel_8_0_5", "* (Click...)" },
		{ "phone_toriel_9_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_9_0_1", "tori_neutral`snd_txttor`* The entrance of the\n  RUINS is quite tranquil,\n  ^10yes?" },
		{ "phone_toriel_9_0_2", "tori_neutral`snd_txttor`* I wanted to make this\n  place appear inviting." },
		{ "phone_toriel_9_0_3", "tori_annoyed`snd_txttor`* Of course,^10 this is in\n  spite of the reputation\n  that humans have here." },
		{ "phone_toriel_9_0_4", "tori_worry`snd_txttor`* I will tell you\n  about that later." },
		{ "phone_toriel_9_0_5", "* (Click...)" },
		{ "phone_toriel_9_1_0", "tori_worry`snd_txttor`* If you get to my\n  home,^10 I will talk\n  to you about it." },
		{ "phone_toriel_9_1_1", "* (Click...)" },
		{ "phone_toriel_10_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_10_0_1", "tori_happy`snd_txttor`* Ah,^10 the first puzzle\n  of the RUINS." },
		{ "phone_toriel_10_0_2", "tori_neutral`snd_txttor`* I would have told you\n  about how the RUINS\n  puzzles had worked." },
		{ "phone_toriel_10_0_3", "tori_worry`snd_txttor`* But of course,^10 I was\n  quickly moving away,^10 so\n  I did not have time." },
		{ "phone_toriel_10_0_4", "tori_neutral`snd_txttor`* Though,^10 you can always\n  pretend that the puzzle\n  is not complete." },
		{ "phone_toriel_10_0_5", "tori_happy`snd_txttor`* Have fun,^10 dear!" },
		{ "phone_toriel_10_0_6", "* (Click...)" },
		{ "phone_toriel_10_1_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_10_1_1", "tori_weird`snd_txttor`* You need help with\n  pretending to solve the\n  first puzzle?" },
		{ "phone_toriel_10_1_2", "tori_weird`snd_txttor`* ..." },
		{ "phone_toriel_10_1_3", "tori_neutral`snd_txttor`* Start from the bottom\n  left button." },
		{ "phone_toriel_10_1_4", "tori_neutral`snd_txttor`* Move around to the top\n  left button in a\n  counter-clockwise circle." },
		{ "phone_toriel_10_1_5", "tori_neutral`snd_txttor`* Do not step on the\n  center switches." },
		{ "phone_toriel_10_1_6", "tori_neutral`snd_txttor`* Then push down on\n  the wall switch." },
		{ "phone_toriel_10_1_7", "tori_happy`snd_txttor`* I hope that helps!" },
		{ "phone_toriel_10_1_8", "* (Click...)" },
		{ "phone_toriel_10_0_0_h", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_10_0_1_h", "tori_happy`snd_txttor`* Ah,^10 the first puzzle\n  of the RUINS." },
		{ "phone_toriel_10_0_2_h", "tori_worry`snd_txttor`* ... I am unsure why\n  you are asking about\n  it." },
		{ "phone_toriel_10_0_3_h", "tori_worry`snd_txttor`* I told you everything\n  that you need to\n  know about puzzles." },
		{ "phone_toriel_10_0_4_h", "tori_neutral`snd_txttor`* If anything else\n  comes to mind, I\n  will tell you." },
		{ "phone_toriel_10_0_5_h", "* (Click...)" },
		{ "phone_toriel_10_1_0_h", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_10_1_1_h", "tori_worry`snd_txttor`* Oh,^10 you are wondering\n  if anything came to\n  mind?" },
		{ "phone_toriel_10_1_2_h", "tori_neutral`snd_txttor`* ..." },
		{ "phone_toriel_10_1_3_h", "tori_worry`snd_txttor`* Unfortunately not." },
		{ "phone_toriel_10_1_5_h", "* (Click...)" },
		{ "phone_toriel_11_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_11_0_1", "tori_worry`snd_txttor`* The hall of wall\n  switches?" },
		{ "phone_toriel_11_0_2", "tori_worry`snd_txttor`* Well,^10 I already did the\n  puzzle,^10 so I cannot\n  really help you with it." },
		{ "phone_toriel_11_0_3", "tori_neutral`snd_txttor`* I apologize." },
		{ "phone_toriel_11_0_4", "* (Click...)" },
		{ "phone_toriel_11_1_0", "tori_weird`snd_txttor`* No,^10 you cannot pull\n  the unlabelled switch." },
		{ "phone_toriel_11_1_1", "* (Click...)" },
		{ "phone_toriel_11_1_0_h", "tori_weird`snd_txttor`* No,^10 you cannot pull\n  the last switch." },
		{ "phone_toriel_11_1_1_h", "* (Click...)" },
		{ "phone_toriel_12_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_12_0_1", "tori_neutral`snd_txttor`* Oh, you fought the\n  dummy?" },
		{ "phone_toriel_12_0_2", "tori_happy`snd_txttor`* I am glad that you\n  got some use out of\n  it!" },
		{ "phone_toriel_12_0_3", "tori_worry`snd_txttor`* I do hope that you\n  did not destroy it." },
		{ "phone_toriel_12_0_4", "tori_worry`snd_txttor`* That is to teach other\n  humans that may fall\n  down here on FIGHTing." },
		{ "phone_toriel_12_0_5", "* (Click...)" },
		{ "phone_toriel_12_0_0_h", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_12_0_1_h", "tori_neutral`snd_txttor`* Oh,^10 the training\n  dummy?" },
		{ "phone_toriel_12_0_2_h", "tori_happy`snd_txttor`* Yes,^05 well..." },
		{ "phone_toriel_12_0_3_h", "tori_blush`snd_txttor`* Oh,^05 that reminds\n  me!" },
		{ "phone_toriel_12_0_4_h", "tori_happy`snd_txttor`* Did you know that\n  a ghost lives in\n  the training dummy?" },
		{ "phone_toriel_12_0_5_h", "tori_neutral`snd_txttor`* One time,^05 when I\n  was honing my ACTing\n  skills..." },
		{ "phone_toriel_12_0_6_h", "tori_happy`snd_txttor`* It actually responded\n  to me!" },
		{ "phone_toriel_12_0_7_h", "tori_worry`snd_txttor`* What?^10\n* Was I hallucinating?" },
		{ "phone_toriel_12_0_8_h", "tori_wack`snd_txttor`* Hahaha!^10\n* That's silly!" },
		{ "phone_toriel_12_0_9_h", "* (Click...)" },
		{ "phone_toriel_12_1_0_h", "tori_wack`snd_txttor`* Let us drop this\n  topic." },
		{ "phone_toriel_12_1_1_h", "* (Click...)" },
		{ "phone_toriel_13_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_13_0_1", "tori_worry`snd_txttor`* Oh,^10 the spiked floor?" },
		{ "phone_toriel_13_0_2", "tori_neutral`snd_txttor`* Well,^10 the light path\n  before the hall reveals\n  a safe pathway." },
		{ "phone_toriel_13_0_3", "tori_neutral`snd_txttor`* If you follow it,^10 then\n  there will be no worry\n  of stepping on spikes." },
		{ "phone_toriel_13_0_4", "tori_happy`snd_txttor`* I hope that helps,^10 dear." },
		{ "phone_toriel_13_0_5", "* (Click...)" },
		{ "phone_toriel_13_0_6", "su_annoyed`snd_txtsus`* Damn,^05 I really wanted\n  to stab myself on\n  the spikes." },
		{ "phone_toriel_13_1_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_13_1_1", "tori_weird`snd_txttor`* ...^05 Susie wants to stab\n  herself on the spikes?" },
		{ "phone_toriel_13_1_2", "tori_weird`snd_txttor`* ..." },
		{ "phone_toriel_13_1_3", "tori_wack`snd_txttor`* Well, I hope that\n  she enjoys it!" },
		{ "phone_toriel_13_1_4", "* (Click...)" },
		{ "phone_toriel_13_0_0_h", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_13_0_1_h", "tori_worry`snd_txttor`* Oh,^10 the spiked floor?" },
		{ "phone_toriel_13_0_2_h", "tori_neutral`snd_txttor`* Well,^10 I already took\n  you through the\n  safe pathway." },
		{ "phone_toriel_13_0_3_h", "tori_neutral`snd_txttor`* If you follow it,^10 then\n  there will be no worry\n  of stepping on spikes." },
		{ "phone_toriel_13_0_4_h", "tori_happy`snd_txttor`* I hope that helps,^10 dear." },
		{ "phone_toriel_13_0_5_h", "* (Click...)" },
		{ "phone_toriel_13_0_6_h", "su_annoyed`snd_txtsus`* Damn,^05 I really wanted\n  to stab myself on\n  the spikes." },
		{ "phone_toriel_13_1_0_h", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_13_1_1_h", "tori_weird`snd_txttor`* ...^05 Susie wants to stab\n  herself on the spikes?" },
		{ "phone_toriel_13_1_2_h", "tori_weird`snd_txttor`* ..." },
		{ "phone_toriel_13_1_3_h", "tori_wack`snd_txttor`* Did she not do\n  that earlier?" },
		{ "phone_toriel_13_1_4_h", "* (Click...)" },
		{ "phone_toriel_14_0_0", "tori_worry`snd_txttor`* Oh dear..." },
		{ "phone_toriel_14_0_1", "tori_worry`snd_txttor`* It is the Long Hallway\n  of Independence." },
		{ "phone_toriel_14_0_2", "tori_neutral`snd_txttor`* It is a test of\n  independence that I give\n  for any human child." },
		{ "phone_toriel_14_0_3", "tori_neutral`snd_txttor`* Luckily,^10 you do not\n  have to face it alone." },
		{ "phone_toriel_14_0_4", "tori_happy`snd_txttor`* You have Susie,^10 do\n  you not?" },
		{ "phone_toriel_14_0_5", "* (Click...)" },
		{ "phone_toriel_15_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_15_0_1", "tori_worry`snd_txttor`* Oh,^10 the frog?" },
		{ "phone_toriel_15_0_2", "tori_happy`snd_txttor`* That is Froggit!" },
		{ "phone_toriel_15_0_3", "tori_neutral`snd_txttor`* They are scatterbrained\n  admittedly,^10 but they are\n  not evil." },
		{ "phone_toriel_15_0_4", "tori_worry`snd_txttor`* Please try to not\n  attack them." },
		{ "phone_toriel_15_0_5", "* (Click...)" },
		{ "phone_toriel_15_0_6", "su_inquisitive`snd_txtsus`* Huh." },
		{ "phone_toriel_15_1_0", "tori_neutral`snd_txttor`* Hello,^10 Kris." },
		{ "phone_toriel_15_1_1", "tori_worry`snd_txttor`* I hope that you\n  did not attack\n  Froggit." },
		{ "phone_toriel_15_1_2", "* (Click...)" },
		{ "phone_toriel_15_1_0_h", "tori_neutral`snd_txttor`* Hello,^10 my child." },
		{ "phone_toriel_15_1_1_h", "tori_worry`snd_txttor`* I hope that you\n  did not attack\n  Froggit." },
		{ "phone_toriel_15_1_2_h", "* (Click...)" },
		{ "phone_toriel_16_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_16_0_1", "tori_worry`snd_txttor`* The candy room?" },
		{ "phone_toriel_16_0_2", "tori_happy`snd_txttor`* Those are some candies\n  that I left out for\n  everyone." },
		{ "phone_toriel_16_0_3", "tori_neutral`snd_txttor`* Feel free to take one." },
		{ "phone_toriel_16_0_4", "* (Click...)" },
		{ "phone_toriel_17_0_0", "tori_blush`snd_txttor`* Ooh,^05 Kris!^10\n* I just remembered!" },
		{ "phone_toriel_17_0_1", "tori_neutral`snd_txttor`* There are some puzzles\n  that require you to\n  fall down." },
		{ "phone_toriel_17_0_2", "tori_worry`snd_txttor`* Be sure to inform\n  Susie about this, please." },
		{ "phone_toriel_17_0_3", "* (Click...)" },
		{ "phone_toriel_17_0_4", "su_side`snd_txtsus`* What were you two\n  talking about?" },
		{ "phone_toriel_17_0_0_h", "tori_blush`snd_txttor`* Ooh,^05 my child!^10\n* I just remembered!" },
		{ "phone_toriel_17_0_1_h", "tori_neutral`snd_txttor`* There are some puzzles\n  that require you to\n  fall down." },
		{ "phone_toriel_17_0_2_h", "tori_worry`snd_txttor`* Be sure to inform\n  Susie about this, please." },
		{ "phone_toriel_17_0_3_h", "* (Click...)" },
		{ "phone_toriel_17_0_4_h", "su_side`snd_txtsus`* What were you two\n  talking about?" },
		{ "phone_toriel_19_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_19_0_1", "tori_worry`snd_txttor`* A fragile floor maze?" },
		{ "phone_toriel_19_0_2", "tori_neutral`snd_txttor`* Follow the clear path." },
		{ "phone_toriel_19_0_3", "tori_happy`snd_txttor`* Have fun,^05 honey." },
		{ "phone_toriel_19_0_4", "tori_worry`snd_txttor`* Oh,^10 and please do not\n  step on the leaves." },
		{ "phone_toriel_19_0_5", "* (Click...)" },
		{ "phone_toriel_19_0_6", "su_smile`snd_txtsus`* Like we're gonna listen\n  to that,^05 right Kris?" },
		{ "phone_toriel_19_0_0_h", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_19_0_1_h", "tori_worry`snd_txttor`* A fragile floor maze?" },
		{ "phone_toriel_19_0_2_h", "tori_neutral`snd_txttor`* Follow the clear path." },
		{ "phone_toriel_19_0_3_h", "tori_happy`snd_txttor`* Have fun,^05 honey." },
		{ "phone_toriel_19_0_4_h", "tori_worry`snd_txttor`* Oh,^10 and please do not\n  step on the leaves." },
		{ "phone_toriel_19_0_5_h", "* (Click...)" },
		{ "phone_toriel_19_0_6_h", "su_smile`snd_txtsus`* Hey,^05 let's step on\n  the leaves." },
		{ "phone_toriel_19_1_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_19_1_1", "tori_worry`snd_txttor`* You did not step on\n  the leaves,^10 did you?" },
		{ "phone_toriel_19_1_2", "tori_weird`snd_txttor`* You did?^10\n* And you're proud?" },
		{ "phone_toriel_19_1_3", "tori_wack`snd_txttor`* My,^10 what an interesting\n  child you are!" },
		{ "phone_toriel_19_1_4", "* (Click...)" },
		{ "phone_toriel_19_1_0_h", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_19_1_1_h", "tori_worry`snd_txttor`* You did not step on\n  the leaves,^10 did you?" },
		{ "phone_toriel_19_1_2_h", "su_angry`snd_txtsus`* WE STEPPED ON THE\n  LEAVES!!!\n^05* ALL OVER THEM!!!" },
		{ "phone_toriel_19_1_3_h", "tori_weird`snd_txttor`* ..." },
		{ "phone_toriel_19_1_4_h", "tori_wack`snd_txttor`* My,^10 how interesting,^05\n  Susie!" },
		{ "phone_toriel_19_1_5_h", "* (Click...)" },
		{ "phone_toriel_20_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_20_0_1", "tori_worry`snd_txttor`* Rocks?^10\n* Speaking of..." },
		{ "phone_toriel_20_0_2", "tori_neutral`snd_txttor`* Did you know that\n  3 of 4 rocks..." },
		{ "phone_toriel_20_0_3", "tori_happy`snd_txttor`* Are fine with being\n  pushed?" },
		{ "phone_toriel_20_0_4", "tori_worry`snd_txttor`* The other one,^10 you\n  may need to ask." },
		{ "phone_toriel_20_0_5", "tori_wack`snd_txttor`* Or if they say no,^10\n  you may need to throw\n  them regardless!" },
		{ "phone_toriel_20_0_6", "* (Click...)" },
		{ "phone_toriel_20_1_0", "tori_blush`snd_txttor`* Did I throw the\n  odd rock out?" },
		{ "phone_toriel_20_1_1", "tori_worry`snd_txttor`* Of course not." },
		{ "phone_toriel_20_1_2", "tori_worry`snd_txttor`* After all,^10 I would need\n  to be pushed quite\n  far myself to do so." },
		{ "phone_toriel_20_1_3", "tori_wack`snd_txttor`* Of course,^10 if said rock\n  scolded me for watering\n  the flowers at night..." },
		{ "phone_toriel_20_1_4", "tori_wack`snd_txttor`* ..." },
		{ "phone_toriel_20_1_5", "tori_worry`snd_txttor`* I suppose that answers\n  that." },
		{ "phone_toriel_20_1_6", "* (Click...)" },
		{ "phone_toriel_21_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_21_0_1", "tori_weird`snd_txttor`* Table cheese?" },
		{ "phone_toriel_21_0_2", "tori_worry`snd_txttor`* Please do not eat\n  that.\n* You will get sick." },
		{ "phone_toriel_21_0_3", "* (Click...)" },
		{ "phone_toriel_24_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_24_0_1", "tori_worry`snd_txttor`* I apologize,^05 but I\n  am quite busy." },
		{ "phone_toriel_24_0_2", "tori_worry`snd_txttor`* Please only call if\n  you absolutely need\n  my assistance." },
		{ "phone_toriel_24_0_3", "* (Click...)" },
		{ "phone_toriel_26_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_26_0_1", "tori_worry`snd_txttor`* The colored switches?" },
		{ "phone_toriel_26_0_2", "tori_neutral`snd_txttor`* Each room has the\n  same arrangement of\n  switches." },
		{ "phone_toriel_26_0_3", "tori_neutral`snd_txttor`* So their position is\n  the same in each\n  room." },
		{ "phone_toriel_26_0_4", "tori_worry`snd_txttor`* If I recall,^05 the\n  blue switch is near\n  the room entrance..." },
		{ "phone_toriel_26_0_5", "tori_worry`snd_txttor`* And the red switch\n  is near the room\n  exit." },
		{ "phone_toriel_26_0_6", "tori_worry`snd_txttor`* With a green switch\n  closer towards the\n  corner." },
		{ "phone_toriel_26_0_7", "tori_happy`snd_txttor`* I hope this helps,^05\n  dear." },
		{ "phone_toriel_26_0_8", "* (Click...)" },
		{ "phone_toriel_27_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_27_0_1", "tori_worry`snd_txttor`* The colored switches?" },
		{ "phone_toriel_27_0_2", "tori_neutral`snd_txttor`* Each room has the\n  same arrangement of\n  switches." },
		{ "phone_toriel_27_0_3", "tori_neutral`snd_txttor`* So their position is\n  the same in each\n  room." },
		{ "phone_toriel_27_0_4", "tori_worry`snd_txttor`* If I recall,^05 the\n  blue switch is near\n  the room entrance..." },
		{ "phone_toriel_27_0_5", "tori_worry`snd_txttor`* And the red switch\n  is near the room\n  exit." },
		{ "phone_toriel_27_0_6", "tori_worry`snd_txttor`* With a green switch\n  closer towards the\n  corner." },
		{ "phone_toriel_27_0_7", "tori_happy`snd_txttor`* I hope this helps,^05\n  dear." },
		{ "phone_toriel_27_0_8", "* (Click...)" },
		{ "phone_toriel_28_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_28_0_1", "tori_worry`snd_txttor`* The colored switches?" },
		{ "phone_toriel_28_0_2", "tori_neutral`snd_txttor`* Each room has the\n  same arrangement of\n  switches." },
		{ "phone_toriel_28_0_3", "tori_neutral`snd_txttor`* So their position is\n  the same in each\n  room." },
		{ "phone_toriel_28_0_4", "tori_worry`snd_txttor`* If I recall,^05 the\n  blue switch is near\n  the room entrance..." },
		{ "phone_toriel_28_0_5", "tori_worry`snd_txttor`* And the red switch\n  is near the room\n  exit." },
		{ "phone_toriel_28_0_6", "tori_worry`snd_txttor`* With a green switch\n  closer towards the\n  corner." },
		{ "phone_toriel_28_0_7", "tori_happy`snd_txttor`* I hope this helps,^05\n  dear." },
		{ "phone_toriel_28_0_8", "* (Click...)" },
		{ "phone_toriel_29_0_0", "tori_neutral`snd_txttor`* Hello.\n^10* This is TORIEL." },
		{ "phone_toriel_29_0_1", "tori_worry`snd_txttor`* The colored switches?" },
		{ "phone_toriel_29_0_2", "tori_neutral`snd_txttor`* Each room has the\n  same arrangement of\n  switches." },
		{ "phone_toriel_29_0_3", "tori_neutral`snd_txttor`* So their position is\n  the same in each\n  room." },
		{ "phone_toriel_29_0_4", "tori_worry`snd_txttor`* If I recall,^05 the\n  blue switch is near\n  the room entrance..." },
		{ "phone_toriel_29_0_5", "tori_worry`snd_txttor`* And the red switch\n  is near the room\n  exit." },
		{ "phone_toriel_29_0_6", "tori_worry`snd_txttor`* With a green switch\n  closer towards the\n  corner." },
		{ "phone_toriel_29_0_7", "tori_happy`snd_txttor`* I hope this helps,^05\n  dear." },
		{ "phone_toriel_29_0_8", "* (Click...)" },
		{ "phone_home_0_0", "* ..." },
		{ "phone_home_0_1", "* It doesn't seem to be\n  working." },
		{ "phone_home_1_0", "torid_happy`snd_txttor`* My,^05 Kris,^05 I am rather\n  impressed." },
		{ "phone_home_1_1", "torid_wack`snd_txttor`* You and Susie woke up\n  before I did!" },
		{ "phone_home_1_2", "torid_relief`snd_txttor`* You must have really\n  wanted to spend\n  time together." },
		{ "phone_home_1_3", "torid_neutral`snd_txttor`* I hope that you two\n  have fun wherever you\n  are." },
		{ "phone_home_1_4", "* (Click...)" },
		{ "phone_home_2_0", "torid_happy`snd_txttor`* Hello,^05 Kris." },
		{ "phone_home_2_1", "torid_neutral`snd_txttor`* I have finally gotten\n  around to painting that\n  wall damage." },
		{ "phone_home_2_2", "torid_worry`snd_txttor`* Which gets me thinking..." },
		{ "phone_home_2_3", "torid_neutral`snd_txttor`* You are aware of\n  the effects of\n  lightning,^05 yes?" },
		{ "phone_home_2_4", "torid_worry`snd_txttor`* It is capable of\n  ending ones self\n  when hit directly." },
		{ "phone_home_2_5", "torid_worry`snd_txttor`* I am unsure of why\n  I thought of this,^05 as\n  the weather is great." },
		{ "phone_home_2_6", "torid_wack`snd_txttor`* So unless you see a\n  magical painter who\n  can shoot lightning..." },
		{ "phone_home_2_7", "torid_neutral`snd_txttor`* You should be fine." },
		{ "phone_home_2_8", "torid_neutral`snd_txttor`* Be safe,^05 honey." },
		{ "phone_home_2_9", "* (Click...)" },
		{ "phone_home_3_0", "torid_happy`snd_txttor`* Hello,^05 Kris." },
		{ "phone_home_3_1", "torid_neutral`snd_txttor`* I have finally gotten\n  around to painting that\n  wall damage." },
		{ "phone_home_3_2", "torid_worry`snd_txttor`* Which gets me thinking..." },
		{ "phone_home_3_3", "torid_neutral`snd_txttor`* You are aware of\n  the effects of\n  lightning,^05 yes?" },
		{ "phone_home_3_4", "torid_worry`snd_txttor`* ...^05 Kris?^10\n* Are you okay,^05 dear?" },
		{ "phone_home_3_5", "torid_worry`snd_txttor`* You don't sound too\n  well." },
		{ "phone_home_3_6", "torid_neutral`snd_txttor`* If you need to\n  come back home,^05 then\n  please do." },
		{ "phone_home_3_7", "torid_worry`snd_txttor`* I do not want you\n  to be out if you\n  are ill." },
		{ "phone_home_3_8", "* (Click...)" },
		{ "phone_home_4_0", "torid_happy`snd_txttor`* Hello,^05 Kris." },
		{ "phone_home_4_1", "torid_neutral`snd_txttor`* I am currently\n  reading a book on\n  moles." },
		{ "phone_home_4_2", "torid_happy`snd_txttor`* Did you know that\n  they are very good\n  at detecting friends?" },
		{ "phone_home_4_3", "torid_neutral`snd_txttor`* They are able to\n  tell if you are \n  friendly..." },
		{ "phone_home_4_4", "torid_neutral`snd_txttor`* ... Or if you are\n  a predator." },
		{ "phone_home_4_5", "torid_happy`snd_txttor`* They are also very\n  cute!" },
		{ "phone_home_4_6", "torid_worry`snd_txttor`* So if you ever\n  encounter one,^05 treat\n  it nicely." },
		{ "phone_home_4_7", "torid_neutral`snd_txttor`* It will not harm\n  you out of malice." },
		{ "phone_home_4_8", "* (Click...)" },
		{ "phone_home_5_0", "torid_happy`snd_txttor`* Hello,^05 Kris." },
		{ "phone_home_5_1", "torid_weird`snd_txttor`* Umm...^15 why is it so\n  windy where you are." },
		{ "phone_home_5_2", "torid_blush`snd_txttor`* It isn't even that\n  breezy today." },
		{ "phone_home_5_3", "torid_mad`snd_txttor`* Where even are you?" },
		{ "phone_home_5_4", "torid_weird`snd_txttor`* ...^10 In a snowy\n  forest underground?\n^10* Travelling dimensions?!" },
		{ "phone_home_5_5", "torid_mad`snd_txttor`* Kris..." },
		{ "phone_home_5_6", "torid_worry`snd_txttor`* ...^10 Please stay safe." },
		{ "phone_home_5_7", "* (Click...)" },
		{ "phone_home_e_0", "torid_happy`snd_txttor`* Hello,^05 Kris." },
		{ "phone_home_e_1", "torid_weird`snd_txttor`* Umm...^15 what am I\n  hearing in the\n  background." },
		{ "phone_home_e_2", "torid_mad`snd_txttor`* Where even are you?" },
		{ "phone_home_e_3", "torid_weird`snd_txttor`* ...^10 * Travelling dimensions?!^10\n* With Susie and Noelle?!" },
		{ "phone_home_e_4", "torid_mad`snd_txttor`* Kris..." },
		{ "phone_home_e_5", "torid_worry`snd_txttor`* ...^10 Please stay safe." },
		{ "phone_home_e_6", "* (Click...)" },
		{ "phone_home_6_0", "torid_happy`snd_txttor`* Hello,^05 Kris." },
		{ "phone_home_6_1", "torid_neutral`snd_txttor`* ..." },
		{ "phone_home_6_2", "torid_worry`snd_txttor`* ...\n* ..." },
		{ "phone_home_6_3", "torid_weird`snd_txttor`* ...\n* ...\n* ..." },
		{ "phone_home_6_4", "torid_confused`snd_txttor`* ...?" },
		{ "phone_home_6_5", "torid_worry`snd_txttor`* Kris...?^05\n* Hello?" },
		{ "phone_home_6_6", "* (Click...)" },
		{ "phone_home_7_0", "torid_worry`snd_txttor`* Kris..." },
		{ "phone_home_7_1", "torid_weird`snd_txttor`* I have no clue\n  where you even are..." },
		{ "phone_home_7_2", "torid_worry`snd_txttor`* But if you need\n  assistance,^05 I will see\n  what I can do." },
		{ "phone_home_7_3", "torid_wack`snd_txttor`* Perhaps the angel will\n  grant me motherly\n  insight!" },
		{ "phone_home_7_4", "torid_worry`snd_txttor`* Do be careful,^05 okay?" },
		{ "phone_home_7_5", "* (Click...)" },
		{ "phone_home_8_0", "torid_neutral`snd_txttor`* Hello,^05 Kris." },
		{ "phone_home_8_1", "torid_worry`snd_txttor`* What?^05\n* Letter from a killer\n  skeleton?" },
		{ "phone_home_8_2", "torid_worry`snd_txttor`* Hmm..." },
		{ "phone_home_8_3", "torid_neutral`snd_txttor`* Does the skeleton know\n  magic?" },
		{ "phone_home_8_4", "torid_worry`snd_txttor`* If he does,^05 then\n  I would not recommend\n  opening the letter." },
		{ "phone_home_8_5", "torid_weird`snd_txttor`* Who knows what they\n  could have placed in\n  it?" },
		{ "phone_home_8_6", "torid_neutral`snd_txttor`* So,^05 just walk past\n  it." },
		{ "phone_home_8_7", "torid_happy`snd_txttor`* I hope that helps,^05\n  dear." },
		{ "phone_home_8_8", "* (Click...)" },
		{ "phone_home_9_0", "torid_neutral`snd_txttor`* Hello,^05 Kris." },
		{ "phone_home_9_1", "torid_worry`snd_txttor`* If I may ask..." },
		{ "phone_home_9_2", "torid_worry`snd_txttor`* What did you mean\n  by \"killer skeleton?\"" },
		{ "phone_home_9_3", "torid_neutral`snd_txttor`* Surely it isn't\n  someone we know,^05 right?" },
		{ "phone_home_9_4", "torid_neutral`snd_txttor`* ..." },
		{ "phone_home_9_5", "torid_blush`snd_txttor`* ...^05 It was Sans???" },
		{ "phone_home_9_6", "torid_weird`snd_txttor`* No,^05 no,^05 that cannot\n  be right." },
		{ "phone_home_9_7", "torid_worry`snd_txttor`* He would never hurt\n  anyone!" },
		{ "phone_home_9_8", "torid_worry`snd_txttor`* Surely he must have\n  suffered some sort of\n  tragedy to act that way." },
		{ "phone_home_9_9", "torid_worry`snd_txttor`* Otherwise,^05 I would say\n  it isn't him." },
		{ "phone_home_9_10", "* (Click...)" },
		{ "phone_home_10_0", "torid_neutral`snd_txttor`* Hello,^05 Kris." },
		{ "phone_home_10_1", "torid_weird`snd_txttor`* ... You were attacked\n  by Sans???" },
		{ "phone_home_10_2", "torid_worry`snd_txttor`* I am still in\n  disbelief that he\n  would do that." },
		{ "phone_home_10_3", "torid_neutral`snd_txttor`* I've been trying\n  to find him around\n  town." },
		{ "phone_home_10_4", "torid_neutral`snd_txttor`* But it seems he's\n  at home,^05 not answering\n  the door." },
		{ "phone_home_10_5", "torid_worry`snd_txttor`* How odd..." },
		{ "phone_home_10_6", "torid_worry`snd_txttor`* Just stay safe,^05\n  honey." },
		{ "phone_home_10_7", "* (Click...)" },
		{ "phone_home_11_0", "torid_neutral`snd_txttor`* Hello,^05 Kris." },
		{ "phone_home_11_1", "torid_wack`snd_txttor`* Oh,^05 you are finally\n  some place safe?" },
		{ "phone_home_11_2", "torid_relief`snd_txttor`* Thank goodness..." },
		{ "phone_home_11_3", "torid_worry`snd_txttor`* I was so worried\n  that you would\n  get hurt,^05 or worse." },
		{ "phone_home_11_4", "torid_worry`snd_txttor`* I still am worried." },
		{ "phone_home_11_5", "torid_worry`snd_txttor`* However on Earth\n  you ended up in\n  another world..." },
		{ "phone_home_11_6", "torid_worry`snd_txttor`* I hope you can\n  find your way home." },
		{ "phone_home_11_7", "torid_worry`snd_txttor`* Stay safe,^05 dear." },
		{ "phone_home_11_8", "* (Click...)" },
		{ "uno_default", "Uno!" },
		{ "uno_papyrus_0", "UNO!" },
		{ "uno_papyrus_1", "UNO!\n^10GET BONED, \nBONEHEAD!" },
		{ "uno_papyrus_2", "UNO!\n^10I CAN SMELL \nVICTORY!" },
		{ "uno_susie_0", "Uno." },
		{ "uno_susie_2", "Uno!^10\nSo close..." },
		{ "uno_susie_1", "Uno.^10\nGet drawing, punk." },
		{ "uno_noelle_0", "Uno!" },
		{ "uno_noelle_1", "Uno!\n^10Oops,^10 sorry!" },
		{ "uno_noelle_2", "Uno!\n^10I've got this!" },
		{ "uno_papyrus_hard_0", "UNO!" },
		{ "uno_papyrus_hard_1", "UNO!" },
		{ "uno_papyrus_hard_2", "UNO!" },
		{ "uno_check_kris", "* Error lol" },
		{ "uno_check_susie", "* SUSIE - {0} ATK {1} DEF\n* Strong-headed \"mean girl\"\n  struggling in Uno." },
		{ "uno_check_noelle", "* NOELLE - {0} ATK {1} DEF\n* The festive, cheery, yet timid\n  girl next door." },
		{ "uno_check_papyrus", "* PAPYRUS - ATK 20 DEF 20\n* He likes to say:\n  \"Nyeh heh heh!\"" },
		{ "uno_check_papyrus_hard", "* PAPYRUS - ATK 20 DEF 20\n* He likes to say:\n  \"Nyeh heh heh!\"" },
		{ "music/mus_date", "Dating Start!`From UNDERTALE\nBy Toby Fox" },
		{ "music/mus_date_fight", "Dating Fight!`From UNDERTALE\nBy Toby Fox" },
		{ "music/mus_battle1", "Enemy Approaching`From UNDERTALE\nBy Toby Fox" },
		{ "music/mus_battle2", "Stronger Monsters`From UNDERTALE\nBy Toby Fox" },
		{ "music/mus_muscle", "sans.`From UNDERTALE\nBy Toby Fox" },
		{ "music/mus_sansfight", "Song That Might Play When You Fight Sans`From UNDERTALE\nBy Toby Fox" },
		{ "music/mus_undyneboss", "Spear of Justice`From UNDERTALE\nBy Toby Fox" },
		{ "music/mus_justice", "Beta Undyne Battle`From UNDERTALE\nBy Toby Fox" },
		{ "music/mus_spider", "Spider Dance`From UNDERTALE\nBy Toby Fox" },
		{ "music/mus_mewmew", "Mad Mew Mew`From UNDERTALE\nBy Toby Fox" },
		{ "music/mus_battledelta", "Rude Buster`From DELTARUNE\nBy Toby Fox" },
		{ "music/mus_checkers", "Checker Dance`From DELTARUNE\nBy Toby Fox" },
		{ "music/mus_mansion", "Pandora Palace`From DELTARUNE\nBy Toby Fox" },
		{ "music/mus_queen_boss", "Attack of the Killer Queen`From DELTARUNE\nBy Toby Fox" },
		{ "music/mus_spamton_battle", "NOW'S YOUR CHANCE TO BE A`From DELTARUNE\nBy Toby Fox" },
		{ "music/mus_spamton_neo_mix_ex_wip", "BIG SHOT`From DELTARUNE\nBy Toby Fox" },
		{ "music/mus_mansion_entrance", "Elegant Entrance`From DELTARUNE\nBy Toby Fox" },
		{ "music/mus_berdly_chase", "Smart Race`From DELTARUNE\nBy Toby Fox" },
		{ "music/mus_battle", "Rude Encounter`From DELTATRAVELER\nBy RENREN" },
		{ "music/mus_battle_hard", "Ruder Monsters`From DELTATRAVELER\nBy RENREN" },
		{ "music/mus_battle_eb", "Battle Against A Rude Opponent`From DELTATRAVELER\nBy LazyGales" },
		{ "music/mus_unsettling_battle", "Battle Against An Unsettling Opponent`From Earthbound\nBy Keiichi Suzuki & Hirokazu Tanaka" },
		{ "music/mus_floweyboss", "FLOWEY`From DELTATRAVELER\nBy RENREN" },
		{ "music/mus_pokeyboss_intro", "Porky's Mayhem`From DELTATRAVELER\nBy LazyGales" },
		{ "music/mus_vsufsans_intro", "Eye for an Eye`From GG!UNDERFELL\nBy TheTuneHero" },
		{ "music/mus_frankness_intro", "Frankness`From UNDERTALE: Papyrus's Belief\nBy Nikolas" },
		{ "music/mus_sandstorm_approaching", "Sandstorm Approaching`From UNDERTALE Yellow\nBy MyNewSoundtrack" },
		{ "music/mus_deal_em_out", "Deal 'Em Out`From UNDERTALE Yellow\nBy emBer" },
		{ "music/mus_decibat", "Fever Pitch`From UNDERTALE Yellow\nBy MasterSwordRemix & MyNewSoundtrack" },
		{ "music/mus_dalv_intro", "Forlorn`From UNDERTALE Yellow\nBy MasterSwordRemix & MyNewSoundtrack" },
		{ "music/mus_protocol", "Protocol`From UNDERTALE Yellow\nBy MasterSwordRemix & MyNewSoundtrack" },
		{ "music/mus_apprehension", "Apprehension`From UNDERTALE Yellow\nBy MasterSwordRemix & MyNewSoundtrack" },
		{ "music/mus_showdown", "Showdown!`From UNDERTALE Yellow\nBy MasterSwordRemix" },
		{ "music/mus_guns_blazing", "Guns Blazing`From UNDERTALE Yellow\nBy MasterSwordRemix & MyNewSoundtrack" },
		{ "music/mus_end_of_the_line", "END OF THE LINE_`From UNDERTALE Yellow\nBy Figburn" },
		{ "music/mus_some_point_of_no_return", "Some Point of No Return`From UNDERTALE Yellow\nBy MasterSwordRemix & MyNewSoundtrack" }
	};

	public static string GetText(string key, params string[] formatting)
	{
		if (english.ContainsKey(key))
		{
			return string.Format(english[key], formatting);
		}
		Debug.LogWarning("invalid localizer key " + key);
		return "INVALID";
	}

	public static bool HasText(string key)
	{
		return english.ContainsKey(key);
	}

	public static Dictionary<string, string>.KeyCollection GetKeys()
	{
		return english.Keys;
	}

	public static string GetGlobalFont()
	{
		return "DTM-Sans";
	}

	public static string[] FormatArray(string[] strings, params object[] vars)
	{
		List<string> list = new List<string>();
		foreach (string format in strings)
		{
			list.Add(string.Format(format, vars));
		}
		return list.ToArray();
	}
}
