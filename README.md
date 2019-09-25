# oefening-observer-1

Dit project is bijna klaar.  Bekijk eerst wat er al is. Je hebt al een ISubject en IObserver interface. De Player is hier het subject en die kan verschillende acties uitvoeren. Ook dat is al mogelijk via het menu.

De Player kan verschillende events genereren. We gebruiken de enum `PlayerAction` om door te geven over welke actie het gaat.

Boven het menu zie je dat er ook andere objecten gedeclareerd zijn: AudioPlayer, XPBar en Achievements. Deze drie objecten moeten observers worden, maar zijn dat nu nog niet.

### opdracht 1
- *AudioPlayer* moet luisteren naar de acties `PICK_UP_ITEM`, `PUNCH_ENEMY` en `PLANT_CROP`. Bij elk van deze acties moet het juiste geluid "afgespeeld" worden.
- *XPBar* luistert enkel naar de actie  `PUNCH_ENEMY`. Bij elke punch verhoog je XP met 1. En toon je de XPBar op het scherm via de `DrawXPBar` functie.
- *Achievements* luistert naar `PUNCH_ENEMY`, `DRINK_POTION` en `PLANT_CROP`. Je update de bijbehorende functie. Die houdt zelf bij hoeveel keer een actie uitgevoerd werd en toont een achievement wanneer nodig.

### opdracht 2
- Voeg een player Actie toe met de naam `KICK_ENEMY`. Zorg ook voor een extra menu optie, een achievement, xp update en geluid.
- Voeg een optie toe om sla te planten.
- Voeg een player Actie toe met de naam `DROP_ITEM`. Zorg ook voor een extra menu optie en een achievement.
  
### opdracht 3
- Voeg een class `Bag` toe. Wanneer de player een item opneemt of laat vallen, dan moet het aantal elementen in de bag geupdated worden. Je toont dan ook op het scherm hoeveel items er nu in de bag zitten. Uiteraard implementeer je `Bag` met een `IObserver` interface.

### opdracht 4
- Voeg een class `Enemy` toe. Deze heeft een property `life` met waarde 10. Bij elke punch verminder je `life` met 1 en toon je de tekst "Enemy screams in pain. What are you doing?" op het scherm. Bij elke kick toon je de tekst "Missed!" op het scherm.
- Extra moeilijk: Zorg er ook voor dat je Enemy zichzelf kan unsubscriben als observer wanneer zijn life minder of gelijk is aan 0.

