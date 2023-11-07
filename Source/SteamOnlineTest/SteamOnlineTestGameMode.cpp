// Copyright Epic Games, Inc. All Rights Reserved.

#include "SteamOnlineTestGameMode.h"
#include "SteamOnlineTestCharacter.h"
#include "UObject/ConstructorHelpers.h"

ASteamOnlineTestGameMode::ASteamOnlineTestGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
