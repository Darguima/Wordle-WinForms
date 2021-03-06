<h1 align="center">
	<a href="https://github.com/Darguima/Wordle-WinForms">
		<img alt="Wordle" src="./assets/wordleLogo.png" width="350px">
	</a>
</h1>

This game is the final project created to a subject at my High School. `Wordle Tuga` is a portuguese version of [`Wordle`](https://www.nytimes.com/games/wordle/index.html) game.

Download the game [here](https://github.com/Darguima/Wordle-WinForms/releases/tag/v1.1.1).

###### Technologies used: `C#` & `Windows Forms` & `Python`

#### Don't forget to install the [dependencies](#dependencies)!!

<p align="center">
	<img src="./assets/LandingPage.jpg" width="350px"/>
	<img src="./assets/TutorialPage.jpg" width="350px"/>
	<img src="./assets/OptionsPage.jpg" width="350px"/>
	<img src="./assets/GamePage.jpg" width="350px"/>
	<img src="./assets/StatisticsPage.jpg" width="350px"/>
	<img src="./assets/ScorePage.jpg" width="350px"/>
</p>

### Dependencies

1. Install `Newtonsoft.Json` on NuGet.

#### Scripts
##### `dictionaryScraper.py`

In order to get a big list of portuguese words I developed a Python script to scrape them from a [dictionary in XML](https://dicionario-aberto.net/recursos).

<img src="./assets/dictionaryScraper.png" width="250px"/>

###### Dependencies

```console
$ pip install unidecode
```

###### Run

```console
$ python scripts/dictionaryScraper.py
```

The  file `scripts/dictionary.json` will be generated with the words JSON.
