Console Reader  
===========

[![Build Status](https://travis-ci.org/rickvanschalkwijk/console_reader.svg?branch=develop)](https://travis-ci.org/rickvanschalkwijk/console_reader)

A small console application for parsing CSV, TSV and JSON files

Contributing
------------

1. Fork it.
2. Create a branch (`git checkout -b my_console_reader`)
3. Commit your changes (`git commit -am "Added some cool new feature"`)
4. Push to the branch (`git push origin my_console_reader`)
5. Open a [Pull Request][1]
6. Enjoy a refreshing Diet Coke and wait


Assignment
----------
De opdracht:

Ontwikkel een kleine console applicatie, die in staat is om CSV bestanden, TSV bestand en JSON gebaseerde records kan parsen. 
Pas hierin alle principes toe die tot op heden zijn behandeld, YAGNI, DRY, SOLID, GRASP, Implement an Interface, Unit Test Verwachtingen, codeer vanuit het principe dat elk object altijd in een valid-state is (bij invalid states throw je exceptions). 
Elke type bestand kent zijn eigen record-definitie. In een CSV en TSV file, beslaat een record 1 volle regel en wordt per record de velden gescheiden obv een komma of een tab. In een JSON bestand werkt dat natuurlijk op basis van de standaard JSON structuur.

De werking van de applicatie is als volgt, ik start de applicatie op en geef het een pad naar een directory mee. 
In deze directory staan verschillende bestanden, die uitgelezen moeten worden. Na het uitlezen van de directory moet de applicatie op de console weergeven hoeveel bestanden er zijn, hoeveel records er zijn, welke type record het meest aanwezig is en per soort record aangeven welke velden beschikbaar zijn. 
Ook wil ik per soort record weten hoeveel data daarvoor beschikbaar is. Per veld van een record wil ik weten, hoeveel deze ingevuld is en indien het gaat om een cijfer invulling wat de min, max en wat het gewogen gemiddelde is.
