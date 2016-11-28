#define USE_NGUI_2X

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum PopUpType {
	NONE,
	DEFAULT,

    PACKAGE_LIST,
    PACKAGE_INTRO,
    PACKAGE_FORCELEVEL_LOCK,
    PACKAGE_TIME_LOCK,
    PACKAGE_Q_ANSWERED,
    PACKAGE_COMPLETE,

    CARRIER_INTRO,
    CARRIER_Q_ANSWERED,
    CARRIER_FAIL,
    CARRIER_LEVEL_UP,

    MINIGAME_LIST,
    MINIGAME_INTRO,
    MINIGAME_CURRENCLEVEL_LOCK,


	BUY_BUILDING,
	PLACE_BUILDING,
	RESOURCE,
	BUY_RESOURCES,
	SHOP,
	FPS_EXIT,
	QUEST,
	QUEST_TASKS,
	QUEST_COMPLETE,
	LEVEL_UP,

    CURRENCY_SHOP,
	JAM
}