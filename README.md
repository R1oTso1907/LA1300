# Projekt-Dokumentation

✍️ Ihr Gruppenname und Ihre Nachnamen

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

In unserem Projekt programmieren wir ein Ausweichspiel mit WinForms
### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |   muss          |funktional      |Als User möchte ich mich bewegen können und den Hindernissen ausweichen können.   |
| 2  |    muss             |funktional      |Als User möchte ich die Hindernisse sehen können damit ich diesen ausweichen kann.                       |
| 3     |        muss    | funktional         |   Als User möchte ich sehen was mein Score/Highscore ist| 
| 4      | muss   | funktional | Als User möchte ich sehen das ich immer schneller werde, so dass das Spiel immer schwieriger wird.| 
| 5      | kann | Randbedingung| Als User möchte ich eine schöne Figur haben, dass es angenehmer zum spielen ist.|
| 6      | kann  | Qualität  | Als User möchte ich Farben von meiner Figur auswählen.|
| 7      | kann  | Qualität |  Als User möchte ich nicht gleich in das Spiel reingeworfen werden, sondern einen Start/Menü-Screen haben.
| 8    | kann  | Qualität |  Als User möchte ich auf mehreren Ebenen spielen.|




### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete||
| 1.1  |  Das Spiel wurde gestartet |  Steuerung     |    Der Character bewegt sich nach den Eingaben des Users.               |
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
| 1.A  |1.12|Ben/Kilian |Visuelles Bild für Code|30 min|
| 2.A  |1.12|Damian/Ensar |Bewegungungscode für Spiel|50 min|
| 3.A  |1.12|Ben/Kilian |Gegner und Hindernisse|60 min|
| 4.A  |8.12|Ben/Damian/Ensar/Kilian |Score Zähler|20 min|
| 4.B  |8.12|Ben/Damian/Ensar/Kilian |High Score Speicher|35 min|
| 5.A  |8.12|Ben/Damian/Ensar/Kilian |Spiel wird schneller| 25 min|
| 6.A  |8.12|Ben/Damian/Ensar/Kilian |Regelmässige Änderung Farben| 15 min|


Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
