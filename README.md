# Projekt-Dokumentation

## Dango: Müller, Eisenring, Yildirim, Stäuble

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|1.12.2022| 0.0.1 | In Zweiergruppen haben Wir mit Programmieren angefangen. wir haben die Grundlagen des Programmes geschrieben und die ersten Aufgaben der Projekt-Dokumentation erfüllt. |
|8.12.2022| 0.0.2 | Von zuhause aus haben wir Entities ins Programm eingefügt zum Beispiel den Gorilla und die Fleischhindernisse. Es wurden zusätzlich noch mehr Testfälle Geschrieben.|
|15.12.2022| 0.0.3 | Heute haben wir die restlichen Testfälle und mehrere Projekt-Dokumentationsaufgaben ergäntzt. Am Programm wurde auch gearbeitet so damit die Hindernisse zufällig auftauchen und dass der spieler nicht zu schnell ist. am ende der Stunde, haben wir unseren Fortschritt präsentiert. |

## 1 Informieren

### 1.1 Ihr Projekt

In unserem Projekt programmieren wir ein Ausweichspiel mit WinForms.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |   muss          |funktional      |Als User möchte ich mich bewegen können und den Hindernissen ausweichen können.   |
| 2  |    muss             |funktional      |Als User möchte ich die Hindernisse sehen können damit ich diesen ausweichen kann.                       |
|3|muss|funktional|Als User möchte ich nicht, das ein Hinderniss in mir Spawned kann, dass ich sterbe|
| 3     |        muss    | funktional         |   Als User möchte ich sehen was mein Score/Highscore ist| 
| 4      | muss   | funktional | Als User möchte ich sehen das ich immer schneller werde, so dass das Spiel immer schwieriger wird.| 
| 5      | kann | Randbedingung| Als User möchte ich eine schöne Figur haben, dass es angenehmer zum spielen ist.|
| 6      | kann  | Qualität  | Als User möchte ich Farben von meiner Figur auswählen.|
| 7      | kann  | Qualität |  Als User möchte ich nicht gleich in das Spiel eingeworfen werden sondern dass ich vorbereitet bin.|
| 8    | kann  | Qualität |  Als User möchte ich ein Hilfsmenu haben, damit ich weiss wie das Spiel funktioniert.|
| 9|    kann | Qualität| Als User möchte ich in verschiedenen Maps spielen können.|
| 10| kann|   Qualität|  Als User möchte ich entscheiden können mit welchen Tasten ich spiele.|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Das Spiel wurde gestartet            |  Steuerung     |    Der Character bewegt sich nach den Eingaben des Users.               |
| 1.2 | Das Spiel wurde gestartet | Leertaste | Der Character springt über die Gegner. | 
| 1.3 | Das Spiel wurde gestartet | Leertaste | Der Character weichte den Hindernissen aus. |
| 2.1 |Der User spielt das Spiel |Leertaste| Der User sieht das Hinderniss 1. |
| 2.2  | Der User spielt das Spiel |    Leertaste   |  Der User sieht das Hinderniss 2.              |
|2.3| Der User spielt das Spiel |Leertaste|  Der User sieht das Hinderniss 3. |
|  3.1|Der User spielt das Spiel  | Leertaste| Der User kann seinen Score sehen. |
| 3.2 | Der User ist gestorben und im Menü | Leertaste | Der User kann seinen Highscore sehen. |
| 3.3 | Der User ist gestorben und im Menü | Leertaste |  Der User kann seinen Overall Highscore sehen.|
|4.1| Der User spielt das Spiel | Leertaste| Der Character wird immer schneller, je länger der User überlebt. |
|4.2| Der User spielt das Spiel  | Leertaste | Der Character wird gleichmässig und stetig schneller.  |
|4.3| Der User spielt das Spiel |Leertaste | Der Character wird nicht zu schnell schneller. |
| 5.1 | Der User spielt das Spiel |Leertaste| Der User hat einen anschaulichen Skin.|
|5.2| Der User spielt das Spiel | Leertaste | Der Skin passt zum Thema des Spiels. |
| 5.3 | Der User spielt das Spiel | Leertaste | Der Skin passt sich in Drehungen der Steuerung des Users an. |
|6.1| Der User ist im Menü | Maus | Der User hat eine Auswahl an Skins. |
| 6.2 | Der User ist im Menü | Maus | Die Skins haben verschiedene Farben. |
| 6.3 | Der User ist im Menü | Maus | Der User kann die verschiedenen Skins auswählen. |
| 7.1 | Der User hat das Spiel gelauncht | Maus | Der User wird nicht direkt in eine Spielrunde geworfen. |
| 7.2 | Der User hat das Spiel gelauncht | Maus | Der User sieht einen Menü/Start-screen. |
| 7.3 | Der User hat das Spiel gelauncht | Maus | Der User kann die einzelnen Auswahlmöglichkeiten klicken und diese reagieren. |
| 8.1 | Der User spielt das Spiel | Leertaste |  Der User kann sieht die einzelnen Ebenen. |
| 8.2 | Der User spielt das Spiel | Leertaste | Der User kann vom Boden auf die Ebene springen. |
| 8.3 | Der User spielt das Spiel | Leertaste | Der User kann von der Ebene wieder auf den Boden springen. |


### 1.4 Diagramme

![image](https://user-images.githubusercontent.com/111044296/203766353-50212203-1d61-4fad-a07c-e2055feba23a.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |1.12|Ben/Kilian |Visuelles Bild für Spielfigur|30 min|
| 1.B |1.12|Ben/Kilian |Visuelles Bild für den Gegner am Boden|30 min|
| 1.C  |1.12|Ben/Kilian |Visuelles Bild für den Gegner in der Luft|30 min|
| 2.A  |1.12|Damian/Ensar |Die Figur bewegt sich autmatisch richtung rechts|50 min|
| 2.B  |1.12|Damian/Ensar |Die Figur kann sprigen|50 min|
| 2.C |1.12|Damian/Ensar |Die Figur wird sollte über die Zeit schneller werden|20 min |
| 3.A  |1.12|Ben/Kilian |Gegner und Hindernisse werden angezeigt|30 min|
| 3.B  |1.12|Ben/Kilian |Wenn Gegner und Hindernisse sich mit der Figur berühren endet das Spiel.|30 min|
| 3.C  |1.12|Ben/Kilian |Gegner und Hindernisse bewegen sich automatisch|30 min|
| 4.A  |8.12|Damian/Ensar |Score Zähler|20 min|
| 4.B  |8.12|Damian/Ensar |High Score Speicher|35 min|
| 5.A  |8.12| Ensar/Kilian |Startmenu designen| 15 min|
| 5.B  |8.12| Ensar/Kilian |Möglich machen aus dem Startmenu entweder zu spielen oder sich in ein Hilfemenu zu bewegen| 15 min|
| 6.A  |8.12|Ben/Damian |Aufrufen eines Menus zur Hilfe sollte möglich sein.| 25 min|
| 6.B |8.12|Ben/Damian |Menu gestallten|25 min|
| 6.C |8.12|Ben/Damian |Möglich machen das man aus dem Menu zurück in das Spiel kommt.| 15 min|
| 7.A  |8.12| Ensar/Kilian |Spawnschutz für den Spieler, falls ein Hinderniss in ihm spawned| 15 min|


Total: 7h 45 


## 3 Entscheiden

Wir haben uns entschieden alle User-Stories umzusetzen und die verschiedenen Charaktere am Schluss zu gestalten als Bonus, falls noch Zeit zur Verfügung stände.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |1.12|  Ben/Kilian    |30 min| 30min|
| 1.B  | 1.12 | Ben/Kilian | 30 min | 40min|
| 1.C  | 1.12| Ben/Kilian |  30 min |  30min   |
| 2.A  | 1.12 | Damian/Ensar |50 min | 55min   |
| 2.B  | 1.12 |  Damian/Ensar |50 min |40min |
| 2.C  |  1.12| Damian/Ensar | 20 min |20min|
| 3.A  | 1.12 | Ben/Kilian |30 min  |35min|
| 3.B  | 1.12 | Ben/Kilian |  30 min | 25min  |
| 3.C  | 1.12  | Ben/Kilian  |30 min  |30min   |
| 4.A  |8.12 | Damian/Ensar | 20 min  |20min   |
| 4.B  |  8.12 |  Damian/Ensar  |35 min  |  30min  |
| 5.A  |8.12| Ensar/Kilian |  15 min |20min |
| 5.B  |8.12|  Ensar/Kilian | 15 min  | 20min|
| 6.A  | 8.12| Ben/Damian |  25 min     |30min    |
| 6.B  |8.12 | Ben/Damian  |  25 min   | 20min  |
| 6.C  |8.12|Ben/Damian  |  15 min    | 15min |
| 7.A  | 8.12 |  Ensar/Kilian  | 15 min | 10min  |
| ...  |       |           |               |                   |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 22.12|funktioniert  | Damian Eisenring |
| 1.2  | 22.12|funktioniert  | Damian Eisenring |
| 1.3| 22.12|funktioniert  | Damian Eisenring |
| 2.1  | 22.12|funktioniert  | Damian Eisenring |
| 2.2  | 22.12|funktioniert  | Damian Eisenring |
| 2.3  | 22.12|funktioniert  | Damian Eisenring |
| 3.1  | 22.12|funktioniert  | Damian Eisenring |
| 3.2  | 22.12|funktioniert nicht  | Damian Eisenring |
| 3.3  | 22.12|funktioniert nicht| Damian Eisenring |
| 4.1  | 22.12|funktioniert  | Damian Eisenring |
| 4.2  | 22.12|funktioniert  | Damian Eisenring |
| 4.3  | 22.12|funktioniert  | Damian Eisenring |
| 5.1  | 22.12|funktioniert  | Damian Eisenring |
| 5.2  | 22.12|funktioniert  | Damian Eisenring |
| 5.3  | 22.12|funktioniert  | Damian Eisenring |
| 6.1 | 22.12|funktioniert nicht | Damian Eisenring |
| 6.2| 22.12|funktioniert nicht | Damian Eisenring |
|6.3 | 22.12|funktioniert nicht | Damian Eisenring |
|7.1  | 22.12|funktioniert  | Damian Eisenring |
|7.2  | 22.12|funktioniert  | Damian Eisenring |
|7.3  | 22.12|funktioniert  | Damian Eisenring |
|8.1  | 22.12|funktioniert nicht  | Damian Eisenring |
|8.2  | 22.12|funktioniert nicht | Damian Eisenring |
|8.3  | 22.12|funktioniert nicht | Damian Eisenring |
| ...  |       |          |        |

Wir konnten viele Testfälle umsetzten, leider konnten wir nicht alles Grafisch umsetzten wie wir wollten. Ausserdem konnten wir das Prinzip mit dem Highscore umsetzten. Sonst verlief alle Testfälle umsetzten.

## 6 Auswerten
[Lernbericht](https://github.com/R1oTso1907/LA1300/blob/main/Lernbericht.md)
