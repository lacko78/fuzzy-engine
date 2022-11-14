#almafarm

rekesz=int(input("Add meg a rendelt rekeszek számát: (5-20)"))
almadb=int(input("A leszüretelt almák darabszáma: (100-200)"))
rendel=rekesz*12
rendeles=almadb//12
if rendel <= almadb: print("A rendelt mennyiség teljeíthető")
else: print("A kért rendelés nem teljesíthető! Max %d rekesz értékesíthető." %(rendeles))
