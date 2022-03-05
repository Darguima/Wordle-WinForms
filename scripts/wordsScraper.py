#!/bin/python

import requests
from bs4 import BeautifulSoup
import unidecode
import json

OUTPUT_FILE = "scripts/words.json"
URLS = [
	{
		"letters": "four",
		"url": "https://www.dicio.com.br/palavras-com-quatro-letras",
	},

	{
		"letters": "five",
		"url": "https://www.dicio.com.br/palavras-com-cinco-letras",
	},

	{
		"letters": "six",
		"url": "https://www.dicio.com.br/palavras-com-seis-letras",
	},

	{
		"letters": "seven",
		"url": "https://www.dicio.com.br/palavras-com-sete-letras",
	}
]

words = {}

print("\n\n===== Scraper =====\n\n")

for url in URLS:
	page = requests.get(url["url"])
	soup = BeautifulSoup(page.content, "html.parser")

	words_html = str(soup.find_all('p')[1])[3:-10].split("<br/>")

	words_html = list(map(lambda word: unidecode.unidecode(word), words_html))

	words[url["letters"]] = words_html
	
	print(url["letters"] + f"letters: {len(words_html)}")

with open(OUTPUT_FILE, 'w') as outfile:
    json.dump(words, outfile)

print(f"\nWords saved in \"{OUTPUT_FILE}\"\n")
