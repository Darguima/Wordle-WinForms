#!/bin/python

from string import ascii_uppercase
import urllib.request
import zipfile
import xml.etree.ElementTree as ET
import unidecode
import json

words = {
	"four": [],
	"five": [],
	"six": [],
	"seven": []
}

OUTPUT_FILE = "scripts/dictionary.json"
URL = 'https://dicionario-aberto.net/resources/xmls.zip'

print("\nDownloading ...", end="\r")

filehandle, _ = urllib.request.urlretrieve(URL)

print("Unzipping the file ...", end="\r")

zip_file_object = zipfile.ZipFile(filehandle, 'r')

print("Reading the file ...  \n")

for letter in ascii_uppercase:

	file = zip_file_object.open(f"xmls/{letter}.xml")
	content = file.read()

	xml_tree = ET.fromstring(content)

	for orth in xml_tree.iter('orth'):
		word = orth.text

		if not 4 <= len(word) <= 7:
			continue

		word = unidecode.unidecode(word).lower()

		if not word.isalpha():
			continue

		match len(word):
			case 4:
				if not word in words["four"]:
					words["four"].append(word)

			case 5:
				if not word in words["five"]:
					words["five"].append(word)

			case 6:
				if not word in words["six"]:
					words["six"].append(word)
					
			case 7:
				if not word in words["seven"]:
					words["seven"].append(word)

print("\nDone!!")

print(f"\n\nFour Letter: {(len(words['four']))} words")
print(f"Five Letter: {(len(words['five']))} words")
print(f"Six Letter: {(len(words['six']))} words")
print(f"Seven Letter: {(len(words['seven']))} words")

with open(OUTPUT_FILE, 'w') as outfile:
    json.dump(words, outfile)

print(f"\nWords saved in \"{OUTPUT_FILE}\"\n")
