<h1 align="center">
	<a href="https://github.com/Darguima/Wordle-WinForms">
		<img alt="Wordle" src="./assets/wordleLogo.png" width="350px">
	</a>
</h1>

This game is the final project created to a subject at my High School. `Wordle Tuga` is a portuguese version of [`Wordle`](https://www.nytimes.com/games/wordle/index.html) game.

###### Technologies used: `C#` & `Windows Forms` & `Python`

<p align="center">
	<img src="./assets/LandingPage.jpg" width="350px"/>
	<img src="./assets/TutorialPage.jpg" width="350px"/>
	<img src="./assets/OptionsPage.jpg" width="350px"/>
	<img src="./assets/GamePage.jpg" width="350px"/>
</p>

### Requirements

1. Install `Newtonsoft.Json` on NuGet.

#### Scripts
##### `wordsScraper.py`

In order to get a big list of portuguese words I developed a Python script to scrape them from a site.

<img src="./assets/wordsScrapper.png" width="250px"/>

###### Dependencies

```console
$ pip install unidecode beautifulsoup4
```

###### Run

```console
$ python scripts/wordsScraper.py
```

The  file `scripts/words.json` will be generated with the words JSON.
