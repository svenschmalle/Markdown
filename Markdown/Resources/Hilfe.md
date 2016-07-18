<span style="width:100%;position:fixed;text-align:right;">[Inhaltsverzeichnis](#inhaltsverzeichnis)</span>

# MarkDown Editor Syntax Hilfe

### Inhaltsverzeichnis
- [Überschriften](#uberschriften)
- [Text-Formatierung](#text-formatierung)
- [Listen](#listen)
- [Zitate](#zitate)
- [Links](#links)
- [Bilder](#bilder)
- [ToDo-Listen](#todo-listen)
- [Tabellen (Pipe-Style)](#tabellen-pipe-style)
- [Tabellen (grid-Style)](#tabellen-grid-style)  

----
#### Überschriften    
```
# Header 1
## Header 2
### Header 3
#### Header 4
##### Header 5
###### Header 6
```
# Header 1
## Header 2
### Header 3
#### Header 4
##### Header 5
###### Header 6
----
#### Text-Formatierung
```**Bold**``` 
**Bold** 

```*Italic*``` 
*Italic* 

```~~Strikethrough~~``` 
~~Strikethrough~~

-----
#### Listen
```
- Listenpunkt1
- Listenpunkt2
- Listenpunkt3
```
- Listenpunkt1
- Listenpunkt2
- Listenpunkt3

```
1. James Madison
2. James Monroe
3. John Quincy Adams
```
1. James Madison
2. James Monroe
3. John Quincy Adams

```
1. Make my changes
    1. Fix bug
    2. Improve formatting
    * Make the headings bigger
2. Push my commits to GitHub
3. Open a pull request
    * Describe my changes
    * Mention all the members of my team
        * Ask for feedback
```

1. Make my changes
    1. Fix bug
    2. Improve formatting
    * Make the headings bigger
2. Push my commits to GitHub
3. Open a pull request
    * Describe my changes
    * Mention all the members of my team
        * Ask for feedback

-----
#### Zitate

```
In the words of Abraham Lincoln:
> Pardon my French
```

In the words of Abraham Lincoln:
> Pardon my French

-----
#### Links

Syntax: 
`[Link Text](http://www.link.de)`

Beispiel:
```
Dies ist ein Beispiel [Link Text](http://www.link.de).
```

Ausgabe: 
Dies ist ein Beispiel [Link Text](http://www.link.de).

-----
#### Bilder

Syntax: 
`[![Tooltip Text](http://www.URLzumBild.de/Bild.jpg)]`

Beispiel:
```
[![Bild](data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAGYAAABmCAMAAAAOARRQAAAAY1BMVEX///8AAAAwMDCGhoZhYWH09PSlpaX19fXOzs78/PwYGBhMTEzq6uooKChlZWXj4+OsrKwfHx/X19c+Pj45OTm5ubl8fHyenp7d3d0QEBC/v7+Li4txcXGUlJRJSUlWVlZ4eHhwNMP8AAACLElEQVRoge2Z65KiMBCFuxUExAsCKuCFff+nXMARkk4yZmo7qdmqnF/qCXwk3XQuAgQFBQUFBQX9XnWHeuVIddR9QZoenSpvRkpZuaUgViVA4rgvo/oEzu4piGfw0JkhPLD1gdmCDwpiwPwnmFasRie18Vb0pRSV6tgnzEGsp2VN255S0b+JViYY2SdMJNVtpT5sJHstWrFgxD/DwEVuSlw2TJaLZrVzhIFGCM8+JSYfBs5LOl2px4hZwhNl1OLEwPPlnBQKL+a4nyg0MNyY19tzVTvDjMmG2x0SjcGLgSSqYt3vzBgoNYFxgDEoYAKGB9M19Ma7gmD6HW0it+8tMNcDrTCXC+3NRVOEZmV/bHqzwYd8WYFrisECzNpYDdoG2078nq40mNY8bMfWEoN1KVw1LAxUDOa6qjoqftqlwNjnaH7Y7I5aDD704cmkZdwHDM5Bf6ABo5vxBnXbn2DeMe7QhMFaN2zxXqJ8xOD0sOXKjJGXxF+SVng2mOdxeM8i/AYzbGCpxFy2w+A9me9owIgJOSklQ2aDwWvx/mTA4F2exXfq7twCs8iEIUvStXolDwbFrNYdaDBhqiWrj0pg+DCLNZULZ5i5Vj90FD5M9ZoFU83OmGKk97lQG99E/0bM6eLEcDjHtGEfNWa1NjAU848qdSPAj+k743kmJ6bVh58b8418YTwdQtJ5zolyXwfEno67PR3eAzSOw5O/txZd5OGPlaCgoKCgoKDfqL+n/yIR0u2vJwAAAABJRU5ErkJggg==)]
```

Ausgabe:
[![Bild](data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAGYAAABmCAMAAAAOARRQAAAAY1BMVEX///8AAAAwMDCGhoZhYWH09PSlpaX19fXOzs78/PwYGBhMTEzq6uooKChlZWXj4+OsrKwfHx/X19c+Pj45OTm5ubl8fHyenp7d3d0QEBC/v7+Li4txcXGUlJRJSUlWVlZ4eHhwNMP8AAACLElEQVRoge2Z65KiMBCFuxUExAsCKuCFff+nXMARkk4yZmo7qdmqnF/qCXwk3XQuAgQFBQUFBQX9XnWHeuVIddR9QZoenSpvRkpZuaUgViVA4rgvo/oEzu4piGfw0JkhPLD1gdmCDwpiwPwnmFasRie18Vb0pRSV6tgnzEGsp2VN255S0b+JViYY2SdMJNVtpT5sJHstWrFgxD/DwEVuSlw2TJaLZrVzhIFGCM8+JSYfBs5LOl2px4hZwhNl1OLEwPPlnBQKL+a4nyg0MNyY19tzVTvDjMmG2x0SjcGLgSSqYt3vzBgoNYFxgDEoYAKGB9M19Ma7gmD6HW0it+8tMNcDrTCXC+3NRVOEZmV/bHqzwYd8WYFrisECzNpYDdoG2078nq40mNY8bMfWEoN1KVw1LAxUDOa6qjoqftqlwNjnaH7Y7I5aDD704cmkZdwHDM5Bf6ABo5vxBnXbn2DeMe7QhMFaN2zxXqJ8xOD0sOXKjJGXxF+SVng2mOdxeM8i/AYzbGCpxFy2w+A9me9owIgJOSklQ2aDwWvx/mTA4F2exXfq7twCs8iEIUvStXolDwbFrNYdaDBhqiWrj0pg+DCLNZULZ5i5Vj90FD5M9ZoFU83OmGKk97lQG99E/0bM6eLEcDjHtGEfNWa1NjAU848qdSPAj+k743kmJ6bVh58b8418YTwdQtJ5zolyXwfEno67PR3eAzSOw5O/txZd5OGPlaCgoKCgoKDfqL+n/yIR0u2vJwAAAABJRU5ErkJggg==)](http://www.frickelblog.de)

Alternativ: Bild mit Link: 
`[![Tooltip Text](http://www.URLzumBild.de/Bild.jpg)](http://www.frickelblog.de)`

-----
#### ToDo-Listen

```
- [x] ToDo 1
- [ ] ToDo 2
- [ ] ToDo 3
```
- [x] ToDo 1
- [ ] ToDo 2
- [ ] ToDo 3

-----
#### Tabellen (Pipe-Style)

```
|Right | Left | Default | Center |
|-----:|:-----|---------|:------:|
|  12  |  12  |    12   |    12  |
| 123  |  123 |   123   |   123  |
|   1  |    1 |     1   |     1  |
```

|Right | Left | Default | Center |
|-----:|:-----|---------|:------:|
|  12  |  12  |    12   |    12  |
| 123  |  123 |   123   |   123  |
|   1  |    1 |     1   |     1  |


-----
#### Tabellen (Grid-Style)

```
+---------------+---------------+--------------------+
| Fruit         | Price         | Advantages         |
+===============+===============+====================+
| Bananas       | $1.34         | - built-in wrapper |
|               |               | - bright color     |
+---------------+---------------+--------------------+
| Oranges       | $2.10         | - cures scurvy     |
|               |               | - tasty            |
+---------------+---------------+--------------------+
```

+---------------+---------------+--------------------+
| Fruit         | Price         | Advantages         |
+===============+===============+====================+
| Bananas       | $1.34         | - built-in wrapper |
|               |               | - bright color     |
+---------------+---------------+--------------------+
| Oranges       | $2.10         | - cures scurvy     |
|               |               | - tasty            |
+---------------+---------------+--------------------+
