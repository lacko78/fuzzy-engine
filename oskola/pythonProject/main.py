# készítette MakLac

# kiíratás print paranccsal
print("Hello!")
'''
#adatok beolvasás, bekérése input() paranccsal
nev=input("Kérek egy nevet: ") #értékadó utasítás
print(nev)'''
'''
#kérj be kettő neved majd írasd ki őket
nev1=input("Kérem az első nevet: ")
nev2=input("Kérem az második nevet: ")
#feldolgozás
nev3=nev1+nev2 # fűzzük össze a neveket és írassuk ki
#kiíratás
print(nev1, nev2) #írassuk ki egymás mellé
print(nev3)

# kérj be kettő számot és írasd ki az összegüket
szam1 = int(input("Kérem az első számot: "))
szam2 = int(input("Kérem a második számot: "))
szam3 = int(input("Kérem a harmadik számot: "))

osszeg = szam1 + szam2 + szam3
szorzat = szam1 * szam2 * szam3

print(osszeg)
print(szorzat)

print(szam1, szam2, szam3)

print(szam1 + szam2 + szam3)
print(szam1 * szam2 * szam3)

print(osszeg, szorzat)
print("Összegük: ", osszeg, "Szorzatuk: ", szorzat)
print("Összegük: " + str(osszeg) + "Szorzatuk: " + str(szorzat))
'''
# Elágazások
# Kérjünk be két számot és írassuk ki a nagyobbat

szam1 = int(input("Kérem az első számot: "))
szam2 = int(input("Kérem a második számot: "))
szam3 = int(input("Kérem a harmadik számot: "))

if szam1 >= szam2 or szam3:
    if szam2>= szam1 or szam3:
        if szam3>=szam1 or szam2:


