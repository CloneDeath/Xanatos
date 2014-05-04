import Xanatos;

def PlayerInit(player):
	player.Resource("Peasant").Set(3);
	player.Resource("Lumber").Set(0);
	player.Resource("Lumberjack").Set(0);
Xanatos.OnPlayerInitialize = PlayerInit;