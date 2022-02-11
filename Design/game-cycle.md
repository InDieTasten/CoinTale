Game Cycle
==========

- Round based
- Command input
- Text generation

Main Loop
---------

The main gameplay loop consists of the game describing the state of the game, after which the player inputs a desired action as a command. The command will be executed and the game responds with a new state of the game.

Example:
```
You are in the Tavern of Hopes. Rolling Rick and Fletiching Finn are telling eachother stories over a grog. You see a shelf of tankards and some grog barrels.

> Take tankard

You are holding the tankard.

> Fill tankard with grog

You've filled your tankard with the most refined grog in the Sea of Thieves. Cheers!

> Drink tankard

You empty your tankard into your dry mouth. The nuances and spices of the grog give you a sensation of warmth. Feeling home. Be careful not to trip!

> Leave tavern

You walk outside the tavern. You can see the jetty over at the beach. Palm leaves are weaving in the light breeze. The sun is up high.

> _
```

Some actions will not change the state of the game, but merely describe the current state more detailed.

Example:
```
You are in the Tavern of Hopes. Rolling Rick and Fletching Finn are telling eachother stories over a grog. You see a shelf of tankards and some grog barrels.

> Look around

You see Rolling Rick, Fletching Finn, tables, stools, a bench, a doorway leading outside, barrels of grog and a shelf of tankards.

> Inspect barrels of grog

You take a closer look at the barrels of grog. One of them is blue and has a stencil depicting some kind of monster. It might be this kraken thing some of the sailors have been talking about. The other barrel is colored blue with skull painting on the front.

> _
```
